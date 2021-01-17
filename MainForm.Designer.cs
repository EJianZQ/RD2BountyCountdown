
namespace RD2BountyCountdown
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox_Timing = new System.Windows.Forms.GroupBox();
            this.panel_Second = new System.Windows.Forms.Panel();
            this.label_Second = new System.Windows.Forms.Label();
            this.panel_Minute = new System.Windows.Forms.Panel();
            this.label_Minute = new System.Windows.Forms.Label();
            this.label_Colon = new System.Windows.Forms.Label();
            this.groupBox_Setting = new System.Windows.Forms.GroupBox();
            this.button_StopCountDown = new System.Windows.Forms.Button();
            this.button_StartCountDown = new System.Windows.Forms.Button();
            this.comboBox_ChooseTime = new System.Windows.Forms.ComboBox();
            this.groupBox_Statistics = new System.Windows.Forms.GroupBox();
            this.label_RealGoldGet = new System.Windows.Forms.Label();
            this.pictureBox_Gold = new System.Windows.Forms.PictureBox();
            this.groupBox_Timing.SuspendLayout();
            this.panel_Second.SuspendLayout();
            this.panel_Minute.SuspendLayout();
            this.groupBox_Setting.SuspendLayout();
            this.groupBox_Statistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gold)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Timing
            // 
            this.groupBox_Timing.Controls.Add(this.panel_Second);
            this.groupBox_Timing.Controls.Add(this.panel_Minute);
            this.groupBox_Timing.Controls.Add(this.label_Colon);
            this.groupBox_Timing.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Timing.Location = new System.Drawing.Point(12, 13);
            this.groupBox_Timing.Name = "groupBox_Timing";
            this.groupBox_Timing.Size = new System.Drawing.Size(366, 145);
            this.groupBox_Timing.TabIndex = 0;
            this.groupBox_Timing.TabStop = false;
            this.groupBox_Timing.Text = "计时区";
            // 
            // panel_Second
            // 
            this.panel_Second.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Second.Controls.Add(this.label_Second);
            this.panel_Second.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Second.Location = new System.Drawing.Point(205, 37);
            this.panel_Second.Name = "panel_Second";
            this.panel_Second.Size = new System.Drawing.Size(133, 81);
            this.panel_Second.TabIndex = 1;
            // 
            // label_Second
            // 
            this.label_Second.Font = new System.Drawing.Font("微软雅黑", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Second.Location = new System.Drawing.Point(6, -7);
            this.label_Second.Name = "label_Second";
            this.label_Second.Size = new System.Drawing.Size(129, 79);
            this.label_Second.TabIndex = 1;
            this.label_Second.Text = "00";
            // 
            // panel_Minute
            // 
            this.panel_Minute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Minute.Controls.Add(this.label_Minute);
            this.panel_Minute.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Minute.Location = new System.Drawing.Point(27, 37);
            this.panel_Minute.Name = "panel_Minute";
            this.panel_Minute.Size = new System.Drawing.Size(133, 81);
            this.panel_Minute.TabIndex = 0;
            // 
            // label_Minute
            // 
            this.label_Minute.Font = new System.Drawing.Font("微软雅黑", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Minute.Location = new System.Drawing.Point(6, -7);
            this.label_Minute.Name = "label_Minute";
            this.label_Minute.Size = new System.Drawing.Size(129, 79);
            this.label_Minute.TabIndex = 0;
            this.label_Minute.Text = "00";
            // 
            // label_Colon
            // 
            this.label_Colon.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Colon.Location = new System.Drawing.Point(160, 31);
            this.label_Colon.Name = "label_Colon";
            this.label_Colon.Size = new System.Drawing.Size(36, 74);
            this.label_Colon.TabIndex = 2;
            this.label_Colon.Text = ":";
            // 
            // groupBox_Setting
            // 
            this.groupBox_Setting.Controls.Add(this.button_StopCountDown);
            this.groupBox_Setting.Controls.Add(this.button_StartCountDown);
            this.groupBox_Setting.Controls.Add(this.comboBox_ChooseTime);
            this.groupBox_Setting.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Setting.Location = new System.Drawing.Point(13, 172);
            this.groupBox_Setting.Name = "groupBox_Setting";
            this.groupBox_Setting.Size = new System.Drawing.Size(365, 130);
            this.groupBox_Setting.TabIndex = 1;
            this.groupBox_Setting.TabStop = false;
            this.groupBox_Setting.Text = "设置区";
            // 
            // button_StopCountDown
            // 
            this.button_StopCountDown.Enabled = false;
            this.button_StopCountDown.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_StopCountDown.Location = new System.Drawing.Point(204, 75);
            this.button_StopCountDown.Name = "button_StopCountDown";
            this.button_StopCountDown.Size = new System.Drawing.Size(136, 40);
            this.button_StopCountDown.TabIndex = 2;
            this.button_StopCountDown.Text = "停止计时";
            this.button_StopCountDown.UseVisualStyleBackColor = true;
            this.button_StopCountDown.Click += new System.EventHandler(this.button_StopCountDown_Click);
            // 
            // button_StartCountDown
            // 
            this.button_StartCountDown.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_StartCountDown.Location = new System.Drawing.Point(26, 75);
            this.button_StartCountDown.Name = "button_StartCountDown";
            this.button_StartCountDown.Size = new System.Drawing.Size(136, 40);
            this.button_StartCountDown.TabIndex = 1;
            this.button_StartCountDown.Text = "开始计时";
            this.button_StartCountDown.UseVisualStyleBackColor = true;
            this.button_StartCountDown.Click += new System.EventHandler(this.button_StartCountDown_Click);
            // 
            // comboBox_ChooseTime
            // 
            this.comboBox_ChooseTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ChooseTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ChooseTime.FormattingEnabled = true;
            this.comboBox_ChooseTime.Items.AddRange(new object[] {
            "3分钟 - 预计获得 0.08 根金条",
            "6分钟 - 预计获得 0.16 根金条",
            "9分钟 - 预计获得 0.24 根金条",
            "12分钟 - 预计获得 0.32 根金条",
            "15分钟 - 预计获得 0.36 根金条",
            "20分钟 - 预计获得 0.40 根金条",
            "25分钟 - 预计获得 0.44 根金条",
            "30分钟 - 预计获得 0.48 根金条"});
            this.comboBox_ChooseTime.Location = new System.Drawing.Point(26, 34);
            this.comboBox_ChooseTime.Name = "comboBox_ChooseTime";
            this.comboBox_ChooseTime.Size = new System.Drawing.Size(314, 28);
            this.comboBox_ChooseTime.TabIndex = 0;
            // 
            // groupBox_Statistics
            // 
            this.groupBox_Statistics.Controls.Add(this.label_RealGoldGet);
            this.groupBox_Statistics.Controls.Add(this.pictureBox_Gold);
            this.groupBox_Statistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_Statistics.Location = new System.Drawing.Point(12, 314);
            this.groupBox_Statistics.Name = "groupBox_Statistics";
            this.groupBox_Statistics.Size = new System.Drawing.Size(366, 71);
            this.groupBox_Statistics.TabIndex = 2;
            this.groupBox_Statistics.TabStop = false;
            this.groupBox_Statistics.Text = "统计区";
            // 
            // label_RealGoldGet
            // 
            this.label_RealGoldGet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_RealGoldGet.Location = new System.Drawing.Point(59, 32);
            this.label_RealGoldGet.Name = "label_RealGoldGet";
            this.label_RealGoldGet.Size = new System.Drawing.Size(306, 29);
            this.label_RealGoldGet.TabIndex = 1;
            this.label_RealGoldGet.Text = "已开始 0 分钟 0 秒 可获得 0 根金条";
            // 
            // pictureBox_Gold
            // 
            this.pictureBox_Gold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Gold.Image")));
            this.pictureBox_Gold.Location = new System.Drawing.Point(14, 25);
            this.pictureBox_Gold.Name = "pictureBox_Gold";
            this.pictureBox_Gold.Size = new System.Drawing.Size(41, 40);
            this.pictureBox_Gold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Gold.TabIndex = 0;
            this.pictureBox_Gold.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 397);
            this.Controls.Add(this.groupBox_Statistics);
            this.Controls.Add(this.groupBox_Setting);
            this.Controls.Add(this.groupBox_Timing);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "荒野大镖客2 赏金任务倒计时器 1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox_Timing.ResumeLayout(false);
            this.panel_Second.ResumeLayout(false);
            this.panel_Minute.ResumeLayout(false);
            this.groupBox_Setting.ResumeLayout(false);
            this.groupBox_Statistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Gold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Timing;
        private System.Windows.Forms.Panel panel_Minute;
        private System.Windows.Forms.Panel panel_Second;
        private System.Windows.Forms.Label label_Colon;
        private System.Windows.Forms.GroupBox groupBox_Setting;
        private System.Windows.Forms.ComboBox comboBox_ChooseTime;
        private System.Windows.Forms.GroupBox groupBox_Statistics;
        private System.Windows.Forms.PictureBox pictureBox_Gold;
        private System.Windows.Forms.Label label_RealGoldGet;
        public System.Windows.Forms.Label label_Minute;
        public System.Windows.Forms.Label label_Second;
        public System.Windows.Forms.Button button_StartCountDown;
        public System.Windows.Forms.Button button_StopCountDown;
    }
}

