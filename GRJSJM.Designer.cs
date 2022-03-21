
namespace 中铁流水线管理端
{
    partial class GRJSJM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labTotaltime = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labProcessId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labSpeedOfProgress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labProductionLineId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOver = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labState = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTotaltime
            // 
            this.labTotaltime.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotaltime.Location = new System.Drawing.Point(611, 33);
            this.labTotaltime.Name = "labTotaltime";
            this.labTotaltime.Size = new System.Drawing.Size(115, 23);
            this.labTotaltime.TabIndex = 27;
            this.labTotaltime.Text = "00:00:00";
            // 
            // labTime
            // 
            this.labTime.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.Location = new System.Drawing.Point(418, 186);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(115, 23);
            this.labTime.TabIndex = 26;
            this.labTime.Text = "00:00:00";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(523, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "总工时：";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(297, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "单次工时：";
            // 
            // labProcessId
            // 
            this.labProcessId.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProcessId.Location = new System.Drawing.Point(170, 120);
            this.labProcessId.Name = "labProcessId";
            this.labProcessId.Size = new System.Drawing.Size(167, 23);
            this.labProcessId.TabIndex = 23;
            this.labProcessId.Text = "null";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(96, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "进度：";
            // 
            // labSpeedOfProgress
            // 
            this.labSpeedOfProgress.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSpeedOfProgress.Location = new System.Drawing.Point(170, 158);
            this.labSpeedOfProgress.Name = "labSpeedOfProgress";
            this.labSpeedOfProgress.Size = new System.Drawing.Size(100, 23);
            this.labSpeedOfProgress.TabIndex = 21;
            this.labSpeedOfProgress.Text = "0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(58, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "工序名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(100, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "姓名：";
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labName.Location = new System.Drawing.Point(168, 48);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(111, 23);
            this.labName.TabIndex = 18;
            this.labName.Text = "null";
            // 
            // labProductionLineId
            // 
            this.labProductionLineId.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProductionLineId.Location = new System.Drawing.Point(168, 83);
            this.labProductionLineId.Name = "labProductionLineId";
            this.labProductionLineId.Size = new System.Drawing.Size(141, 23);
            this.labProductionLineId.TabIndex = 17;
            this.labProductionLineId.Text = "null";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "生产线名称：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOver
            // 
            this.btnOver.Location = new System.Drawing.Point(500, 273);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(92, 38);
            this.btnOver.TabIndex = 30;
            this.btnOver.Text = "结束";
            this.btnOver.UseVisualStyleBackColor = true;
            this.btnOver.Click += new System.EventHandler(this.btnOver_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(379, 273);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(56, 38);
            this.btnStop.TabIndex = 29;
            this.btnStop.Text = "暂停";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(193, 273);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 38);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(297, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "当前状态：";
            // 
            // labState
            // 
            this.labState.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labState.Location = new System.Drawing.Point(418, 230);
            this.labState.Name = "labState";
            this.labState.Size = new System.Drawing.Size(100, 23);
            this.labState.TabIndex = 32;
            this.labState.Text = "null";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 94);
            this.button1.TabIndex = 33;
            this.button1.Text = "问题上报";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GRJSJM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOver);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labTotaltime);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labProcessId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSpeedOfProgress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labProductionLineId);
            this.Controls.Add(this.label1);
            this.Name = "GRJSJM";
            this.Text = "计时界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GRJSJM_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTotaltime;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labProcessId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labSpeedOfProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labProductionLineId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOver;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labState;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}