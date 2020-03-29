namespace QUANLYCONGDAN
{
    partial class frmSoHoKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTPKNgayCap = new System.Windows.Forms.DateTimePicker();
            this.lbchon = new System.Windows.Forms.Label();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btMoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenChuHo = new System.Windows.Forms.TextBox();
            this.txtNoiThuongTru = new System.Windows.Forms.TextBox();
            this.txtSoHoKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGSHK = new System.Windows.Forms.DataGridView();
            this.SoSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiThuongTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPKNgayCap1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGSHK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DTPKNgayCap1);
            this.panel1.Controls.Add(this.DTPKNgayCap);
            this.panel1.Controls.Add(this.lbchon);
            this.panel1.Controls.Add(this.cbChon);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btTimKiem);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btMoi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTenChuHo);
            this.panel1.Controls.Add(this.txtNoiThuongTru);
            this.panel1.Controls.Add(this.txtSoHoKhau);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 246);
            this.panel1.TabIndex = 0;
            // 
            // DTPKNgayCap
            // 
            this.DTPKNgayCap.Location = new System.Drawing.Point(573, 86);
            this.DTPKNgayCap.Name = "DTPKNgayCap";
            this.DTPKNgayCap.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayCap.TabIndex = 80;
            // 
            // lbchon
            // 
            this.lbchon.AutoSize = true;
            this.lbchon.ForeColor = System.Drawing.Color.Maroon;
            this.lbchon.Location = new System.Drawing.Point(190, 220);
            this.lbchon.Name = "lbchon";
            this.lbchon.Size = new System.Drawing.Size(32, 13);
            this.lbchon.TabIndex = 79;
            this.lbchon.Text = "Chọn";
            // 
            // cbChon
            // 
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Items.AddRange(new object[] {
            "Số Sổ Hộ Khẩu",
            "Tên Chủ Hộ",
            "Nơi Thường Trú",
            "Ngày Cấp"});
            this.cbChon.Location = new System.Drawing.Point(254, 212);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(121, 21);
            this.cbChon.TabIndex = 78;
            this.cbChon.SelectedIndexChanged += new System.EventHandler(this.cbTV_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(425, 212);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(130, 20);
            this.txtTimKiem.TabIndex = 77;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.Azure;
            this.btTimKiem.ForeColor = System.Drawing.Color.Maroon;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(574, 206);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(88, 41);
            this.btTimKiem.TabIndex = 76;
            this.btTimKiem.Text = "Tìm Kiếm";
            this.btTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Azure;
            this.btThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(425, 131);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 41);
            this.btThoat.TabIndex = 74;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Azure;
            this.btXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btXoa.Location = new System.Drawing.Point(315, 131);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(73, 41);
            this.btXoa.TabIndex = 73;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Azure;
            this.btSua.ForeColor = System.Drawing.Color.Maroon;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(203, 131);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 41);
            this.btSua.TabIndex = 72;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Azure;
            this.btThem.ForeColor = System.Drawing.Color.Maroon;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(107, 131);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 41);
            this.btThem.TabIndex = 71;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btMoi
            // 
            this.btMoi.BackColor = System.Drawing.Color.Azure;
            this.btMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMoi.Location = new System.Drawing.Point(13, 131);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(75, 41);
            this.btMoi.TabIndex = 70;
            this.btMoi.Text = "Mới";
            this.btMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(345, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Sổ Hộ Khẩu";
            // 
            // txtTenChuHo
            // 
            this.txtTenChuHo.Location = new System.Drawing.Point(561, 41);
            this.txtTenChuHo.Name = "txtTenChuHo";
            this.txtTenChuHo.Size = new System.Drawing.Size(174, 20);
            this.txtTenChuHo.TabIndex = 68;
            // 
            // txtNoiThuongTru
            // 
            this.txtNoiThuongTru.Location = new System.Drawing.Point(122, 83);
            this.txtNoiThuongTru.Name = "txtNoiThuongTru";
            this.txtNoiThuongTru.Size = new System.Drawing.Size(316, 20);
            this.txtNoiThuongTru.TabIndex = 67;
            // 
            // txtSoHoKhau
            // 
            this.txtSoHoKhau.Location = new System.Drawing.Point(122, 41);
            this.txtSoHoKhau.Name = "txtSoHoKhau";
            this.txtSoHoKhau.Size = new System.Drawing.Size(100, 20);
            this.txtSoHoKhau.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(493, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Ngày cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(493, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tên chủ hộ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nơi thường trú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Số Hộ khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGSHK);
            this.panel2.Location = new System.Drawing.Point(12, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 164);
            this.panel2.TabIndex = 1;
            // 
            // DGSHK
            // 
            this.DGSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSHK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoSHK,
            this.NoiThuongTru,
            this.TenChuHo,
            this.NgayCap});
            this.DGSHK.Location = new System.Drawing.Point(43, 6);
            this.DGSHK.Name = "DGSHK";
            this.DGSHK.Size = new System.Drawing.Size(716, 158);
            this.DGSHK.TabIndex = 33;
            this.DGSHK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGSHK_CellContentClick);
            // 
            // SoSHK
            // 
            this.SoSHK.DataPropertyName = "SoSHK";
            this.SoSHK.HeaderText = "Số Sổ Hộ Khẩu";
            this.SoSHK.Name = "SoSHK";
            // 
            // NoiThuongTru
            // 
            this.NoiThuongTru.DataPropertyName = "NoiThuongTru";
            this.NoiThuongTru.HeaderText = "Nơi Thường Trú";
            this.NoiThuongTru.Name = "NoiThuongTru";
            // 
            // TenChuHo
            // 
            this.TenChuHo.DataPropertyName = "TenChuHo";
            this.TenChuHo.HeaderText = "Tên Chủ Hộ";
            this.TenChuHo.Name = "TenChuHo";
            // 
            // NgayCap
            // 
            this.NgayCap.DataPropertyName = "NgayCap";
            this.NgayCap.HeaderText = "Ngày Cấp";
            this.NgayCap.Name = "NgayCap";
            // 
            // DTPKNgayCap1
            // 
            this.DTPKNgayCap1.Location = new System.Drawing.Point(574, 131);
            this.DTPKNgayCap1.Name = "DTPKNgayCap1";
            this.DTPKNgayCap1.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayCap1.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(528, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Đến";
            // 
            // frmSoHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSoHoKhau";
            this.Text = "frmSoHoKhau";
            this.Load += new System.EventHandler(this.frmSoHoKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGSHK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbchon;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenChuHo;
        private System.Windows.Forms.TextBox txtNoiThuongTru;
        private System.Windows.Forms.TextBox txtSoHoKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGSHK;
        private System.Windows.Forms.DateTimePicker DTPKNgayCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiThuongTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DTPKNgayCap1;
    }
}