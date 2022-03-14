
namespace 中铁流水线管理端
{
    partial class GRSCHJHSXZJM
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
            this.cbxXZSCX = new System.Windows.Forms.ComboBox();
            this.cbxXZGX = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxXZSCX
            // 
            this.cbxXZSCX.FormattingEnabled = true;
            this.cbxXZSCX.Location = new System.Drawing.Point(12, 64);
            this.cbxXZSCX.Name = "cbxXZSCX";
            this.cbxXZSCX.Size = new System.Drawing.Size(181, 20);
            this.cbxXZSCX.TabIndex = 0;
            this.cbxXZSCX.SelectedIndexChanged += new System.EventHandler(this.cbxXZSCX_SelectionChangeCommitted);
            // 
            // cbxXZGX
            // 
            this.cbxXZGX.FormattingEnabled = true;
            this.cbxXZGX.Location = new System.Drawing.Point(212, 64);
            this.cbxXZGX.Name = "cbxXZGX";
            this.cbxXZGX.Size = new System.Drawing.Size(180, 20);
            this.cbxXZGX.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GRSCHJHSXZJM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxXZGX);
            this.Controls.Add(this.cbxXZSCX);
            this.Name = "GRSCHJHSXZJM";
            this.Text = "工人生产线及工序选择界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxXZSCX;
        private System.Windows.Forms.ComboBox cbxXZGX;
        private System.Windows.Forms.Button button1;
    }
}