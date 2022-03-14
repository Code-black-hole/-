
namespace 中铁流水线管理端
{
    partial class WTSBJM
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
            this.dgvZLWTB = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZLWTB)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZLWTB
            // 
            this.dgvZLWTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZLWTB.Location = new System.Drawing.Point(22, 28);
            this.dgvZLWTB.Name = "dgvZLWTB";
            this.dgvZLWTB.RowTemplate.Height = 23;
            this.dgvZLWTB.Size = new System.Drawing.Size(588, 351);
            this.dgvZLWTB.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 125);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WTSBJM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvZLWTB);
            this.Name = "WTSBJM";
            this.Text = "问题上报界面";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZLWTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZLWTB;
        private System.Windows.Forms.Button button1;
    }
}