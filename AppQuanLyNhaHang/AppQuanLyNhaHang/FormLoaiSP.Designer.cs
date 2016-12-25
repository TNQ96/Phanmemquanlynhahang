namespace AppQuanLyNhaHang
{
    partial class FormLoaiSP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grvData = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thêm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenHH);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(129, 72);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(432, 20);
            this.txtTenHH.TabIndex = 1;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(129, 31);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(432, 20);
            this.txtMaHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grvData);
            this.groupBox2.Location = new System.Drawing.Point(0, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // grvData
            // 
            this.grvData.BackgroundColor = System.Drawing.Color.White;
            this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLoaiSP,
            this.TenLoaiSP});
            this.grvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvData.Location = new System.Drawing.Point(3, 16);
            this.grvData.Name = "grvData";
            this.grvData.Size = new System.Drawing.Size(699, 166);
            this.grvData.TabIndex = 0;
            this.grvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData_CellContentClick);
            // 
            // STT
            // 
            this.STT.FillWeight = 30F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 30;
            // 
            // MaLoaiSP
            // 
            this.MaLoaiSP.DataPropertyName = "MaLoaiSP";
            this.MaLoaiSP.HeaderText = "Ma Loai San Pham";
            this.MaLoaiSP.Name = "MaLoaiSP";
            // 
            // TenLoaiSP
            // 
            this.TenLoaiSP.DataPropertyName = "TenLoaiSP";
            this.TenLoaiSP.HeaderText = "Ten Loai San Pham";
            this.TenLoaiSP.Name = "TenLoaiSP";
            // 
            // Thêm
            // 
            this.Thêm.Location = new System.Drawing.Point(77, 189);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(106, 35);
            this.Thêm.TabIndex = 2;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FormLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLoaiSP";
            this.Text = "Thông tin loại sản phẩm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Button Thêm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView grvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSP;
    }
}

