
namespace KOBUKI_Controller
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewScript = new System.Windows.Forms.ListView();
            this.btAdd = new System.Windows.Forms.Button();
            this.labelHeaderKobukiConfig = new System.Windows.Forms.Label();
            this.labelKobukiIp = new System.Windows.Forms.Label();
            this.labelKobukiPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCmdType = new System.Windows.Forms.Label();
            this.labelCmdSpeed = new System.Windows.Forms.Label();
            this.labelCmdRadius = new System.Windows.Forms.Label();
            this.labelCmdDistance = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.tbKobukiIp = new System.Windows.Forms.TextBox();
            this.tbKobukiPort = new System.Windows.Forms.TextBox();
            this.tbCmdSpeed = new System.Windows.Forms.TextBox();
            this.tbCmdRadius = new System.Windows.Forms.TextBox();
            this.tbCmdDistance = new System.Windows.Forms.TextBox();
            this.tbCmdDuration = new System.Windows.Forms.TextBox();
            this.cbCmdType = new System.Windows.Forms.ComboBox();
            this.tbCmdDegree = new System.Windows.Forms.TextBox();
            this.labelCmdDegree = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem,
            this.menuStart,
            this.menuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLoad,
            this.menuSave});
            this.저장ToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(54, 34);
            this.저장ToolStripMenuItem.Text = "File";
            // 
            // menuLoad
            // 
            this.menuLoad.Name = "menuLoad";
            this.menuLoad.Size = new System.Drawing.Size(122, 26);
            this.menuLoad.Text = "Load";
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(122, 26);
            this.menuSave.Text = "Save";
            // 
            // menuStart
            // 
            this.menuStart.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(62, 34);
            this.menuStart.Text = "Start";
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menuStop
            // 
            this.menuStop.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStop.Name = "menuStop";
            this.menuStop.Size = new System.Drawing.Size(54, 34);
            this.menuStop.Text = "Stop";
            this.menuStop.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus,
            this.labelCurrentStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1032, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 18);
            this.labelStatus.Text = "Status";
            // 
            // labelCurrentStatus
            // 
            this.labelCurrentStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentStatus.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelCurrentStatus.Name = "labelCurrentStatus";
            this.labelCurrentStatus.Size = new System.Drawing.Size(40, 18);
            this.labelCurrentStatus.Text = "Stop";
            // 
            // listViewScript
            // 
            this.listViewScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewScript.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewScript.HideSelection = false;
            this.listViewScript.Location = new System.Drawing.Point(12, 37);
            this.listViewScript.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewScript.Name = "listViewScript";
            this.listViewScript.Size = new System.Drawing.Size(684, 338);
            this.listViewScript.TabIndex = 2;
            this.listViewScript.UseCompatibleStateImageBehavior = false;
            this.listViewScript.View = System.Windows.Forms.View.Details;
            this.listViewScript.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewScript_MouseClick);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(945, 347);
            this.btAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 28);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // labelHeaderKobukiConfig
            // 
            this.labelHeaderKobukiConfig.AutoSize = true;
            this.labelHeaderKobukiConfig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderKobukiConfig.Location = new System.Drawing.Point(702, 37);
            this.labelHeaderKobukiConfig.Name = "labelHeaderKobukiConfig";
            this.labelHeaderKobukiConfig.Size = new System.Drawing.Size(197, 23);
            this.labelHeaderKobukiConfig.TabIndex = 4;
            this.labelHeaderKobukiConfig.Text = "KOBUKI UDP Config";
            // 
            // labelKobukiIp
            // 
            this.labelKobukiIp.AutoSize = true;
            this.labelKobukiIp.Location = new System.Drawing.Point(729, 66);
            this.labelKobukiIp.Margin = new System.Windows.Forms.Padding(3);
            this.labelKobukiIp.Name = "labelKobukiIp";
            this.labelKobukiIp.Size = new System.Drawing.Size(88, 18);
            this.labelKobukiIp.TabIndex = 5;
            this.labelKobukiIp.Text = "IP Address";
            // 
            // labelKobukiPort
            // 
            this.labelKobukiPort.AutoSize = true;
            this.labelKobukiPort.Location = new System.Drawing.Point(729, 97);
            this.labelKobukiPort.Margin = new System.Windows.Forms.Padding(3);
            this.labelKobukiPort.Name = "labelKobukiPort";
            this.labelKobukiPort.Size = new System.Drawing.Size(40, 18);
            this.labelKobukiPort.TabIndex = 6;
            this.labelKobukiPort.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "KOBUKI Command Config";
            // 
            // labelCmdType
            // 
            this.labelCmdType.AutoSize = true;
            this.labelCmdType.Location = new System.Drawing.Point(729, 160);
            this.labelCmdType.Margin = new System.Windows.Forms.Padding(3);
            this.labelCmdType.Name = "labelCmdType";
            this.labelCmdType.Size = new System.Drawing.Size(40, 18);
            this.labelCmdType.TabIndex = 8;
            this.labelCmdType.Text = "Type";
            // 
            // labelCmdSpeed
            // 
            this.labelCmdSpeed.AutoSize = true;
            this.labelCmdSpeed.Location = new System.Drawing.Point(729, 191);
            this.labelCmdSpeed.Margin = new System.Windows.Forms.Padding(3);
            this.labelCmdSpeed.Name = "labelCmdSpeed";
            this.labelCmdSpeed.Size = new System.Drawing.Size(104, 18);
            this.labelCmdSpeed.TabIndex = 9;
            this.labelCmdSpeed.Text = "Speed (km/h)";
            // 
            // labelCmdRadius
            // 
            this.labelCmdRadius.AutoSize = true;
            this.labelCmdRadius.Location = new System.Drawing.Point(729, 222);
            this.labelCmdRadius.Margin = new System.Windows.Forms.Padding(3);
            this.labelCmdRadius.Name = "labelCmdRadius";
            this.labelCmdRadius.Size = new System.Drawing.Size(96, 18);
            this.labelCmdRadius.TabIndex = 10;
            this.labelCmdRadius.Text = "Radius (mm)";
            // 
            // labelCmdDistance
            // 
            this.labelCmdDistance.AutoSize = true;
            this.labelCmdDistance.Location = new System.Drawing.Point(729, 284);
            this.labelCmdDistance.Margin = new System.Windows.Forms.Padding(3);
            this.labelCmdDistance.Name = "labelCmdDistance";
            this.labelCmdDistance.Size = new System.Drawing.Size(112, 18);
            this.labelCmdDistance.TabIndex = 11;
            this.labelCmdDistance.Text = "Distance (mm)";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(729, 315);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(3);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(128, 18);
            this.labelDuration.TabIndex = 12;
            this.labelDuration.Text = "Duration (msec)";
            // 
            // tbKobukiIp
            // 
            this.tbKobukiIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKobukiIp.Location = new System.Drawing.Point(866, 63);
            this.tbKobukiIp.Name = "tbKobukiIp";
            this.tbKobukiIp.Size = new System.Drawing.Size(154, 25);
            this.tbKobukiIp.TabIndex = 13;
            // 
            // tbKobukiPort
            // 
            this.tbKobukiPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKobukiPort.Location = new System.Drawing.Point(866, 94);
            this.tbKobukiPort.Name = "tbKobukiPort";
            this.tbKobukiPort.Size = new System.Drawing.Size(154, 25);
            this.tbKobukiPort.TabIndex = 14;
            // 
            // tbCmdSpeed
            // 
            this.tbCmdSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCmdSpeed.Location = new System.Drawing.Point(866, 188);
            this.tbCmdSpeed.Name = "tbCmdSpeed";
            this.tbCmdSpeed.Size = new System.Drawing.Size(154, 25);
            this.tbCmdSpeed.TabIndex = 15;
            // 
            // tbCmdRadius
            // 
            this.tbCmdRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCmdRadius.Location = new System.Drawing.Point(866, 219);
            this.tbCmdRadius.Name = "tbCmdRadius";
            this.tbCmdRadius.Size = new System.Drawing.Size(154, 25);
            this.tbCmdRadius.TabIndex = 17;
            // 
            // tbCmdDistance
            // 
            this.tbCmdDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCmdDistance.Location = new System.Drawing.Point(866, 281);
            this.tbCmdDistance.Name = "tbCmdDistance";
            this.tbCmdDistance.Size = new System.Drawing.Size(154, 25);
            this.tbCmdDistance.TabIndex = 18;
            // 
            // tbCmdDuration
            // 
            this.tbCmdDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCmdDuration.Location = new System.Drawing.Point(866, 312);
            this.tbCmdDuration.Name = "tbCmdDuration";
            this.tbCmdDuration.Size = new System.Drawing.Size(154, 25);
            this.tbCmdDuration.TabIndex = 19;
            // 
            // cbCmdType
            // 
            this.cbCmdType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCmdType.FormattingEnabled = true;
            this.cbCmdType.Location = new System.Drawing.Point(866, 157);
            this.cbCmdType.Name = "cbCmdType";
            this.cbCmdType.Size = new System.Drawing.Size(154, 26);
            this.cbCmdType.TabIndex = 20;
            this.cbCmdType.SelectedIndexChanged += new System.EventHandler(this.cbCmdType_SelectedIndexChanged);
            // 
            // tbCmdDegree
            // 
            this.tbCmdDegree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCmdDegree.Location = new System.Drawing.Point(866, 250);
            this.tbCmdDegree.Name = "tbCmdDegree";
            this.tbCmdDegree.Size = new System.Drawing.Size(154, 25);
            this.tbCmdDegree.TabIndex = 22;
            // 
            // labelCmdDegree
            // 
            this.labelCmdDegree.AutoSize = true;
            this.labelCmdDegree.Location = new System.Drawing.Point(729, 253);
            this.labelCmdDegree.Margin = new System.Windows.Forms.Padding(3);
            this.labelCmdDegree.Name = "labelCmdDegree";
            this.labelCmdDegree.Size = new System.Drawing.Size(110, 23);
            this.labelCmdDegree.TabIndex = 21;
            this.labelCmdDegree.Text = "Degree (°)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 403);
            this.Controls.Add(this.tbCmdDegree);
            this.Controls.Add(this.labelCmdDegree);
            this.Controls.Add(this.cbCmdType);
            this.Controls.Add(this.tbCmdDuration);
            this.Controls.Add(this.tbCmdDistance);
            this.Controls.Add(this.tbCmdRadius);
            this.Controls.Add(this.tbCmdSpeed);
            this.Controls.Add(this.tbKobukiPort);
            this.Controls.Add(this.tbKobukiIp);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelCmdDistance);
            this.Controls.Add(this.labelCmdRadius);
            this.Controls.Add(this.labelCmdSpeed);
            this.Controls.Add(this.labelCmdType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKobukiPort);
            this.Controls.Add(this.labelKobukiIp);
            this.Controls.Add(this.labelHeaderKobukiConfig);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listViewScript);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1050, 900);
            this.MinimumSize = new System.Drawing.Size(1050, 450);
            this.Name = "Form1";
            this.Text = "KOBUKI Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuLoad;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuStop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.ListView listViewScript;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ToolStripStatusLabel labelCurrentStatus;
        private System.Windows.Forms.Label labelHeaderKobukiConfig;
        private System.Windows.Forms.Label labelKobukiIp;
        private System.Windows.Forms.Label labelKobukiPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCmdType;
        private System.Windows.Forms.Label labelCmdSpeed;
        private System.Windows.Forms.Label labelCmdRadius;
        private System.Windows.Forms.Label labelCmdDistance;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox tbKobukiIp;
        private System.Windows.Forms.TextBox tbKobukiPort;
        private System.Windows.Forms.TextBox tbCmdSpeed;
        private System.Windows.Forms.TextBox tbCmdRadius;
        private System.Windows.Forms.TextBox tbCmdDistance;
        private System.Windows.Forms.TextBox tbCmdDuration;
        private System.Windows.Forms.ComboBox cbCmdType;
        private System.Windows.Forms.TextBox tbCmdDegree;
        private System.Windows.Forms.Label labelCmdDegree;
    }
}

