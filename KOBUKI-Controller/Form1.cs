using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KOBUKI_Controller
{
    static class Constants
    {
        public const byte HeaderFirst = 0xAA;
        public const byte HeaderSecond = 0x55;
        public const byte SpeedPayloadLen = 6;
        public const byte BaseControlId = 1;
        public const byte BaseControlLen = 4;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct SpeedMessage
    {
        public byte headerFirst;
        public byte headerSecond;
        public byte payloadLen;
        public byte subPayloadId;
        public byte subPayloadLen;
        public UInt16 speed;
        public UInt16 radius;
    };

    public partial class Form1 : Form
    {
        private bool isRunning;
        private Thread thread;
        private int modifingIndex;

        public Form1()
        {
            InitializeComponent();
            isRunning = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitListView();
            InitComboBoxCmdType();
            InitConfig();
        }

        private void InitComboBoxCmdType()
        {
            cbCmdType.BeginUpdate();

            cbCmdType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCmdType.Items.Add("speed");
            cbCmdType.Items.Add("sleep");
            cbCmdType.SelectedIndex = 0;

            cbCmdType.EndUpdate();
            cbCmdType.Refresh();
        }

        private void InitConfig()
        {
            tbKobukiIp.Text = "192.168.240.1";
            tbKobukiPort.Text = "5555";
            tbCmdSpeed.Text = "1.0";
            tbCmdRadius.Text = "0";
            tbCmdDegree.Text = "0";
            tbCmdDistance.Text = "1000";
            tbCmdDuration.Text = "3000";
        }

        private void InitListView()
        {
            modifingIndex = -1;

            listViewScript.BeginUpdate();
            listViewScript.View = View.Details;
            listViewScript.FullRowSelect = true;

            listViewScript.Columns.Add("Index", -2, HorizontalAlignment.Left);
            listViewScript.Columns.Add("Type", -2, HorizontalAlignment.Left);
            listViewScript.Columns.Add("Speed (km/h)", -2, HorizontalAlignment.Left);
            listViewScript.Columns.Add("Radius (mm)", -2, HorizontalAlignment.Left);
            listViewScript.Columns.Add("Degree (°)", -2, HorizontalAlignment.Left);
            listViewScript.Columns.Add("Distance (mm)", -2, HorizontalAlignment.Left);
            listViewScript.Columns.Add("Duration (msec)", -2, HorizontalAlignment.Left);

            RefreshListView();

            listViewScript.EndUpdate();
            this.Refresh();
        }

        private void RefreshListView()
        {
            foreach (ColumnHeader tmp in listViewScript.Columns)
            {
                tmp.Width = -2;
            }

            for (int i = 0; i < listViewScript.Items.Count; i++)
            {
                listViewScript.Items[i].Text = i.ToString();
            }
        }

        private void AddListViewItem(int cmdType, string speed, string radius, string degree, string distance)
        {
            listViewScript.BeginUpdate();

            ListViewItem lvi = new ListViewItem(listViewScript.Items.Count.ToString());
            lvi.SubItems.Add("speed");
            lvi.SubItems.Add(speed);
            lvi.SubItems.Add(radius);
            lvi.SubItems.Add(degree);
            lvi.SubItems.Add(distance);
            lvi.SubItems.Add("0");
            listViewScript.Items.Add(lvi);

            RefreshListView();
            listViewScript.EndUpdate();
            listViewScript.Refresh();
        }


        private void AddListViewItem(int cmdType, string duration)
        {
            listViewScript.BeginUpdate();

            ListViewItem lvi = new ListViewItem(listViewScript.Items.Count.ToString());
            lvi.SubItems.Add("sleep");
            lvi.SubItems.Add("0");
            lvi.SubItems.Add("0");
            lvi.SubItems.Add("0");
            lvi.SubItems.Add("0");
            lvi.SubItems.Add(duration);
            listViewScript.Items.Add(lvi);

            RefreshListView();
            listViewScript.EndUpdate();
            listViewScript.Refresh();
        }


        private void ModifyListViewItem(int index, int cmdType, string speed, string radius, string degree, string distance)
        {
            listViewScript.BeginUpdate();

            listViewScript.Items[index].SubItems[0].Text = index.ToString();
            listViewScript.Items[index].SubItems[1].Text = cmdType == 0 ? "speed" : "sleep";
            listViewScript.Items[index].SubItems[2].Text = speed;
            listViewScript.Items[index].SubItems[3].Text = radius;
            listViewScript.Items[index].SubItems[4].Text = degree;
            listViewScript.Items[index].SubItems[5].Text = distance;
            listViewScript.Items[index].SubItems[6].Text = "0";

            RefreshListView();
            listViewScript.EndUpdate();
            listViewScript.Refresh();
        }


        private void ModifyListViewItem(int index, int cmdType, string duration)
        {
            listViewScript.BeginUpdate();

            listViewScript.Items[index].SubItems[0].Text = index.ToString();
            listViewScript.Items[index].SubItems[1].Text = cmdType == 0 ? "speed" : "sleep";
            listViewScript.Items[index].SubItems[2].Text = "0";
            listViewScript.Items[index].SubItems[3].Text = "0";
            listViewScript.Items[index].SubItems[4].Text = "0";
            listViewScript.Items[index].SubItems[5].Text = "0";
            listViewScript.Items[index].SubItems[6].Text = duration;

            RefreshListView();
            listViewScript.EndUpdate();
            listViewScript.Refresh();
        }

        private void RemoveListViewItems(List<ListViewItem> items)
        {
            listViewScript.BeginUpdate();

            foreach (ListViewItem tmp in items)
            {
                tmp.Remove();
            }

            RefreshListView();
            listViewScript.EndUpdate();
            listViewScript.Refresh();
        }

        private void ResetColorListView()
        {
            listViewScript.BeginUpdate();
            foreach (ListViewItem rollback in listViewScript.Items)
            {
                rollback.BackColor = Color.White;
            }
            listViewScript.EndUpdate();
            listViewScript.Refresh();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbCmdType.SelectedIndex == 0)
            {
                if (modifingIndex == -1)
                {
                    AddListViewItem(cbCmdType.SelectedIndex, tbCmdSpeed.Text, tbCmdRadius.Text, tbCmdDegree.Text, tbCmdDistance.Text);
                }
                else
                {
                    ModifyListViewItem(modifingIndex, cbCmdType.SelectedIndex, tbCmdSpeed.Text, tbCmdRadius.Text, tbCmdDegree.Text, tbCmdDistance.Text);
                    modifingIndex = -1;
                    btAdd.Text = "Add";
                }
            }
            else
            {
                if (modifingIndex == -1)
                {
                    AddListViewItem(cbCmdType.SelectedIndex, tbCmdDuration.Text);
                } 
                else
                {
                    ModifyListViewItem(modifingIndex, cbCmdType.SelectedIndex, tbCmdDuration.Text);
                    modifingIndex = -1;
                    btAdd.Text = "Add";
                }
            }
        }

        private void ModifyCmd(ListViewItem item)
        {
            if (item.SubItems[1].Text.Equals("speed"))
            {
                cbCmdType.SelectedIndex = 0;
                tbCmdSpeed.Text = item.SubItems[2].Text;
                tbCmdRadius.Text = item.SubItems[3].Text;
                tbCmdDegree.Text = item.SubItems[4].Text;
                tbCmdDistance.Text = item.SubItems[5].Text;
                btAdd.Text = "Modify";
                modifingIndex = int.Parse(item.SubItems[0].Text);
            }
            else
            {
                cbCmdType.SelectedIndex = 1;
                tbCmdDuration.Text = item.SubItems[6].Text;
            }
        }

        private void listViewScript_MouseClick(object sender, MouseEventArgs e)
        {
            if (isRunning == true)
            {
                listViewScript.BeginUpdate();
                foreach (ListViewItem tmp in listViewScript.SelectedItems)
                {
                    tmp.Selected = false;
                    tmp.Focused = false;
                }
                listViewScript.EndUpdate();
                listViewScript.Refresh();
                return;
            }

            // 우클릭
            if (e.Button.Equals(MouseButtons.Right))
            {
                // 선택한 아이템들 저장
                List<ListViewItem> items = new List<ListViewItem>();
                foreach (ListViewItem tmp in listViewScript.SelectedItems)
                {
                    items.Add(tmp);
                }

                // 우클릭 메뉴 생성
                ContextMenu menu = new ContextMenu();
                MenuItem menuModify = new MenuItem();
                MenuItem menuDelete = new MenuItem();

                menuModify.Text = "Modify";
                menuDelete.Text = "Delete";

                menuModify.Click += (modifiySender, modifyArgs) =>
                {
                    ModifyCmd(items[0]);
                };

                menuDelete.Click += (deleteSender, deleteArgs) =>
                {
                    RemoveListViewItems(items);
                };

                menu.MenuItems.Add(menuModify);
                menu.MenuItems.Add(menuDelete);

                menu.Show(listViewScript, new Point(e.X, e.Y));
            }
        }

        private void menuStart_Click(object sender, EventArgs e)
        {
            isRunning = true;
            labelCurrentStatus.Text = "Working";
            thread = new Thread(new ThreadStart(ProcessScript));
            thread.Start();
        }

        private void ProcessScript()
        {

            // UDP 초기화
            IPEndPoint ip_end = new IPEndPoint(IPAddress.Parse(tbKobukiIp.Text), int.Parse(tbKobukiPort.Text));
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            SpeedMessage initMsg = new SpeedMessage();
            initMsg.headerFirst = Constants.HeaderFirst;
            initMsg.headerSecond = Constants.HeaderSecond;
            initMsg.payloadLen = Constants.SpeedPayloadLen;
            initMsg.subPayloadId = Constants.BaseControlId;
            initMsg.subPayloadLen = Constants.BaseControlLen;

            byte[] initMsgBytes = new byte[Marshal.SizeOf(initMsg)];
            IntPtr initMsgPtr = Marshal.AllocHGlobal(Marshal.SizeOf(initMsg));

             // UDP 메시지 전송
            initMsg.speed = 0;
            initMsg.radius = 0;

            Marshal.StructureToPtr(initMsg, initMsgPtr, true);
            Marshal.Copy(initMsgPtr, initMsgBytes, 0, Marshal.SizeOf(initMsg));
            Marshal.FreeHGlobal(initMsgPtr);

            // MessageBox.Show(BitConverter.ToString(speedMsgBytes));
            client.SendTo(initMsgBytes, initMsgBytes.Length, SocketFlags.None, ip_end);

            Thread.Sleep(1000);

            foreach (ListViewItem tmp in listViewScript.Items)
            {
                // 다 흰색으로 초기화
                ResetColorListView();
                
                listViewScript.BeginUpdate();

                // 지금 차례의 index는 파란색
                tmp.BackColor = Color.CornflowerBlue;

                SpeedMessage speedMsg = new SpeedMessage();
                speedMsg.headerFirst = Constants.HeaderFirst;
                speedMsg.headerSecond = Constants.HeaderSecond;
                speedMsg.payloadLen = Constants.SpeedPayloadLen;
                speedMsg.subPayloadId = Constants.BaseControlId;
                speedMsg.subPayloadLen = Constants.BaseControlLen;

                byte[] speedMsgBytes = new byte[Marshal.SizeOf(speedMsg)];
                IntPtr speedMsgPtr = Marshal.AllocHGlobal(Marshal.SizeOf(speedMsg));

                // speed 처리
                if (tmp.SubItems[1].Text.Equals("speed"))
                {
                    /**
                     * speed
                     * input; km/s 
                     * output: mm/s
                     * */
                    int speed = (int)(double.Parse(tmp.SubItems[2].Text) * 1000000 / 3600);
                    speedMsg.speed = (UInt16)speed;

                    /**
                     * radius
                     * input: mm
                     * output: mm
                     * */
                    int radius = (int)(double.Parse(tmp.SubItems[3].Text));
                    if (radius > 1) radius += 115;
                    else if (radius < -1) radius -= 115;
                    speedMsg.radius = (UInt16)radius;

                    /**
                     * radian
                     * input: degree
                     * output: radian
                     * */
                    double radian;
                    if (radius <= 1 && radius >= -1) radian = double.Parse(tmp.SubItems[4].Text) * Math.PI;
                    else radian = double.Parse(tmp.SubItems[4].Text) * Math.PI / 90;

                    /**
                     * distance
                     * input: mm
                     * output: mm
                     * */
                    int distance = (int)(double.Parse(tmp.SubItems[5].Text));

                    // 이동 시간 계산 ms 단위
                    double moveDuration = 0;
                    if (radius >= 1 || radius <= -1) moveDuration = (double)((radius * radian) / (double)speed);
                    else if (radius == 0) moveDuration = (double)(distance / (double)speed);

                    if (speed == 0)
                    {
                        moveDuration = 0;
                    }

                    if (moveDuration < 0)
                    {
                        moveDuration *= -1;
                    }

                    // moveDuration sec to msec
                    moveDuration = (int)(moveDuration * 1000);
                    tmp.SubItems[6].Text = moveDuration.ToString();
                    listViewScript.EndUpdate();
                    listViewScript.Refresh();

                    // UDP 메시지 전송
                    Marshal.StructureToPtr(speedMsg, speedMsgPtr, true);
                    Marshal.Copy(speedMsgPtr, speedMsgBytes, 0, Marshal.SizeOf(speedMsg));
                    Marshal.FreeHGlobal(speedMsgPtr);

                    // MessageBox.Show(BitConverter.ToString(speedMsgBytes));
                    client.SendTo(speedMsgBytes, speedMsgBytes.Length, SocketFlags.None, ip_end);

                    Thread.Sleep((int)moveDuration);
                }
                else if (tmp.SubItems[1].Text.Equals("sleep"))
                {
                    int duration = int.Parse(tmp.SubItems[6].Text);
                    listViewScript.EndUpdate();
                    listViewScript.Refresh();
                    Thread.Sleep(duration);
                }
            }

            // 다 끝나면 초기화
            ResetColorListView();

            isRunning = false;
        }

        private void menuStop_Click(object sender, EventArgs e)
        {
            if (thread.IsAlive)
            {
                isRunning = false;
                thread.Abort();
                labelCurrentStatus.Text = "Stop";
                ResetColorListView();
            }
        }

        private void cbCmdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // type: Speed
            if (cbCmdType.SelectedIndex == 0)
            {
                tbCmdSpeed.Enabled = true;
                tbCmdRadius.Enabled = true;
                tbCmdDegree.Enabled = true;
                tbCmdDistance.Enabled = true;
                tbCmdDuration.Enabled = false;
            }
            else
            {
                tbCmdSpeed.Enabled = false;
                tbCmdRadius.Enabled = false;
                tbCmdDegree.Enabled = false;
                tbCmdDistance.Enabled = false;
                tbCmdDuration.Enabled = true;
            }
        }
    }
}
