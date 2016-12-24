namespace AppQuanLyNhaHang
{
    partial class FrmMain
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
            this.btnThanToan = new System.Windows.Forms.Button();
            this.BtnQuanLy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThanToan
            // 
            this.btnThanToan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThanToan.Location = new System.Drawing.Point(183, 86);
            this.btnThanToan.Margin = new System.Windows.Forms.Padding(6);
            this.btnThanToan.Name = "btnThanToan";
            this.btnThanToan.Size = new System.Drawing.Size(254, 71);
            this.btnThanToan.TabIndex = 0;
            this.btnThanToan.Text = "Thanh Toán";
            this.btnThanToan.UseVisualStyleBackColor = true;
            // 
            // BtnQuanLy
            // 
            this.BtnQuanLy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnQuanLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnQuanLy.Location = new System.Drawing.Point(183, 204);
            this.BtnQuanLy.Margin = new System.Windows.Forms.Padding(6);
            this.BtnQuanLy.Name = "BtnQuanLy";
            this.BtnQuanLy.Size = new System.Drawing.Size(254, 71);
            this.BtnQuanLy.TabIndex = 0;
            this.BtnQuanLy.Text = "Quản Lý";
            this.BtnQuanLy.UseVisualStyleBackColor = true;
            this.BtnQuanLy.Click += new System.EventHandler(this.BtnQuanLy_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(614, 363);
            this.Controls.Add(this.BtnQuanLy);
            this.Controls.Add(this.btnThanToan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(621, 401);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phan Mem Quan Ly Nha Hang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThanToan;
        private System.Windows.Forms.Button BtnQuanLy;
    }
}