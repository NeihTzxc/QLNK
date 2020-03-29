namespace QUANLYCONGDAN
{
    partial class frmChucNang
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qlNhanKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.qlTamTru = new System.Windows.Forms.ToolStripMenuItem();
            this.qlTamVang = new System.Windows.Forms.ToolStripMenuItem();
            this.qlTienAnTienSu = new System.Windows.Forms.ToolStripMenuItem();
            this.qlSoHoKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.qlThuongTru = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlNhanKhau,
            this.qlTamTru,
            this.qlTamVang,
            this.qlTienAnTienSu,
            this.qlSoHoKhau,
            this.qlThuongTru,
            this.ThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qlNhanKhau
            // 
            this.qlNhanKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qlNhanKhau.Name = "qlNhanKhau";
            this.qlNhanKhau.Size = new System.Drawing.Size(137, 21);
            this.qlNhanKhau.Text = "Quản lý nhân khẩu";
            this.qlNhanKhau.Click += new System.EventHandler(this.qlNhanKhau_Click);
            // 
            // qlTamTru
            // 
            this.qlTamTru.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qlTamTru.Name = "qlTamTru";
            this.qlTamTru.Size = new System.Drawing.Size(118, 21);
            this.qlTamTru.Text = "Quản lý tạm trú";
            this.qlTamTru.Click += new System.EventHandler(this.qlTamTru_Click_1);
            // 
            // qlTamVang
            // 
            this.qlTamVang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qlTamVang.Name = "qlTamVang";
            this.qlTamVang.Size = new System.Drawing.Size(130, 21);
            this.qlTamVang.Text = "Quản lý tạm vắng";
            this.qlTamVang.Click += new System.EventHandler(this.qlTamVang_Click_1);
            // 
            // qlTienAnTienSu
            // 
            this.qlTienAnTienSu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qlTienAnTienSu.Name = "qlTienAnTienSu";
            this.qlTienAnTienSu.Size = new System.Drawing.Size(162, 21);
            this.qlTienAnTienSu.Text = "Quản lý tiền án tiền sự";
            this.qlTienAnTienSu.Click += new System.EventHandler(this.qlTienAnTienSu_Click);
            // 
            // qlSoHoKhau
            // 
            this.qlSoHoKhau.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qlSoHoKhau.Name = "qlSoHoKhau";
            this.qlSoHoKhau.Size = new System.Drawing.Size(140, 21);
            this.qlSoHoKhau.Text = "Quản lý sổ hộ khẩu";
            this.qlSoHoKhau.Click += new System.EventHandler(this.qlSoHoKhau_Click);
            // 
            // qlThuongTru
            // 
            this.qlThuongTru.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qlThuongTru.Name = "qlThuongTru";
            this.qlThuongTru.Size = new System.Drawing.Size(140, 21);
            this.qlThuongTru.Text = "Quản lý thường trú";
            this.qlThuongTru.Click += new System.EventHandler(this.qlThuongTru_Click);
            // 
            // ThongKe
            // 
            this.ThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(78, 21);
            this.ThongKe.Text = "Thống kê";
            this.ThongKe.Click += new System.EventHandler(this.ThongKe_Click);
            // 
            // frmChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmChucNang";
            this.Text = "frmChucNang";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qlNhanKhau;
        private System.Windows.Forms.ToolStripMenuItem qlTamTru;
        private System.Windows.Forms.ToolStripMenuItem qlTamVang;
        private System.Windows.Forms.ToolStripMenuItem qlTienAnTienSu;
        private System.Windows.Forms.ToolStripMenuItem qlSoHoKhau;
        private System.Windows.Forms.ToolStripMenuItem qlThuongTru;
        private System.Windows.Forms.ToolStripMenuItem ThongKe;
    }
}