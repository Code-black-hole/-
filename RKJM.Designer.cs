
namespace 中铁流水线管理端
{
    partial class RKJM
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFormId = new System.Windows.Forms.TextBox();
            this.dgvRK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "入库";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "单号";
            // 
            // txtFormId
            // 
            this.txtFormId.Location = new System.Drawing.Point(82, 31);
            this.txtFormId.Name = "txtFormId";
            this.txtFormId.Size = new System.Drawing.Size(100, 21);
            this.txtFormId.TabIndex = 3;
            // 
            // dgvRK
            // 
            this.dgvRK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRK.Location = new System.Drawing.Point(28, 78);
            this.dgvRK.Name = "dgvRK";
            this.dgvRK.RowTemplate.Height = 23;
            this.dgvRK.Size = new System.Drawing.Size(746, 251);
            this.dgvRK.TabIndex = 4;
            // 
            // RKJM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.dgvRK);
            this.Controls.Add(this.txtFormId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "RKJM";
            this.Text = "入库界面";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFormId;
        private System.Windows.Forms.DataGridView dgvRK;
    }
}