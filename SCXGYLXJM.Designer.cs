
namespace 中铁流水线管理端
{
    partial class SCXGYLXJM
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
            this.dgvSCXGYLXJM = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCXGYLXJM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSCXGYLXJM
            // 
            this.dgvSCXGYLXJM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSCXGYLXJM.Location = new System.Drawing.Point(213, 36);
            this.dgvSCXGYLXJM.Name = "dgvSCXGYLXJM";
            this.dgvSCXGYLXJM.RowTemplate.Height = 23;
            this.dgvSCXGYLXJM.Size = new System.Drawing.Size(548, 293);
            this.dgvSCXGYLXJM.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Excel导出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBJ
            // 
            this.btnBJ.Location = new System.Drawing.Point(34, 96);
            this.btnBJ.Name = "btnBJ";
            this.btnBJ.Size = new System.Drawing.Size(106, 64);
            this.btnBJ.TabIndex = 3;
            this.btnBJ.Text = "编辑工艺路线";
            this.btnBJ.UseVisualStyleBackColor = true;
            this.btnBJ.Click += new System.EventHandler(this.button3_Click);
            // 
            // SCXGYLXJM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBJ);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSCXGYLXJM);
            this.Name = "SCXGYLXJM";
            this.Text = "生产线工艺路线界面";
            this.Load += new System.EventHandler(this.SCXGYLXJM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSCXGYLXJM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSCXGYLXJM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBJ;
    }
}