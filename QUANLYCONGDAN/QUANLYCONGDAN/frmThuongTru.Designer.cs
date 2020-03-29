namespace QUANLYCONGDAN
{
    partial class frmThuongTru
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
            this.DTPKNgayChuyenDen = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTu = new System.Windows.Forms.ComboBox();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.txtNoiOTruoc = new System.Windows.Forms.TextBox();
            this.txtSoSHK = new System.Windows.Forms.TextBox();
            this.txtQHCH = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btMoi = new System.Windows.Forms.Button();
            this.lbNgayChuyenDen = new System.Windows.Forms.Label();
            this.lbMaNK = new System.Windows.Forms.Label();
            this.lbTu = new System.Windows.Forms.Label();
            this.lbSoSHK = new System.Windows.Forms.Label();
            this.lbQuanHeCH = new System.Windows.Forms.Label();
            this.lbMaTT = new System.Windows.Forms.Label();
            this.lbThuongTru = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGTT = new System.Windows.Forms.DataGridView();
            this.MaNKTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanHeCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChuyenDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiThuongTruTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTPKNgayChuyenDen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTu);
            this.panel1.Controls.Add(this.txtMaNK);
            this.panel1.Controls.Add(this.txtNoiOTruoc);
            this.panel1.Controls.Add(this.txtSoSHK);
            this.panel1.Controls.Add(this.txtQHCH);
            this.panel1.Controls.Add(this.txtMaTT);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btthem);
            this.panel1.Controls.Add(this.btMoi);
            this.panel1.Controls.Add(this.lbNgayChuyenDen);
            this.panel1.Controls.Add(this.lbMaNK);
            this.panel1.Controls.Add(this.lbTu);
            this.panel1.Controls.Add(this.lbSoSHK);
            this.panel1.Controls.Add(this.lbQuanHeCH);
            this.panel1.Controls.Add(this.lbMaTT);
            this.panel1.Controls.Add(this.lbThuongTru);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 253);
            this.panel1.TabIndex = 0;
            // 
            // DTPKNgayChuyenDen
            // 
            this.DTPKNgayChuyenDen.Location = new System.Drawing.Point(537, 129);
            this.DTPKNgayChuyenDen.Name = "DTPKNgayChuyenDen";
            this.DTPKNgayChuyenDen.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayChuyenDen.TabIndex = 41;
            this.DTPKNgayChuyenDen.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(42, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nơi ở trước";
            // 
            // cbTu
            // 
            this.cbTu.FormattingEnabled = true;
            this.cbTu.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbTu.Location = new System.Drawing.Point(384, 103);
            this.cbTu.Name = "cbTu";
            this.cbTu.Size = new System.Drawing.Size(100, 21);
            this.cbTu.TabIndex = 39;
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(637, 58);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(100, 20);
            this.txtMaNK.TabIndex = 38;
            // 
            // txtNoiOTruoc
            // 
            this.txtNoiOTruoc.Location = new System.Drawing.Point(129, 145);
            this.txtNoiOTruoc.Name = "txtNoiOTruoc";
            this.txtNoiOTruoc.Size = new System.Drawing.Size(249, 20);
            this.txtNoiOTruoc.TabIndex = 37;
            // 
            // txtSoSHK
            // 
            this.txtSoSHK.Location = new System.Drawing.Point(384, 62);
            this.txtSoSHK.Name = "txtSoSHK";
            this.txtSoSHK.Size = new System.Drawing.Size(100, 20);
            this.txtSoSHK.TabIndex = 36;
            // 
            // txtQHCH
            // 
            this.txtQHCH.Location = new System.Drawing.Point(129, 101);
            this.txtQHCH.Name = "txtQHCH";
            this.txtQHCH.Size = new System.Drawing.Size(100, 20);
            this.txtQHCH.TabIndex = 35;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(129, 66);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(100, 20);
            this.txtMaTT.TabIndex = 34;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btThoat.Location = new System.Drawing.Point(623, 194);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 39);
            this.btThoat.TabIndex = 33;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btXoa.Location = new System.Drawing.Point(498, 194);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 37);
            this.btXoa.TabIndex = 32;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSua.ForeColor = System.Drawing.Color.Maroon;
            this.btSua.Location = new System.Drawing.Point(360, 196);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(69, 37);
            this.btSua.TabIndex = 31;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btthem.ForeColor = System.Drawing.Color.Maroon;
            this.btthem.Location = new System.Drawing.Point(212, 196);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 37);
            this.btthem.TabIndex = 30;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btMoi
            // 
            this.btMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btMoi.ForeColor = System.Drawing.Color.Maroon;
            this.btMoi.Location = new System.Drawing.Point(80, 196);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(75, 37);
            this.btMoi.TabIndex = 29;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = true;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // lbNgayChuyenDen
            // 
            this.lbNgayChuyenDen.AutoSize = true;
            this.lbNgayChuyenDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNgayChuyenDen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbNgayChuyenDen.Location = new System.Drawing.Point(534, 101);
            this.lbNgayChuyenDen.Name = "lbNgayChuyenDen";
            this.lbNgayChuyenDen.Size = new System.Drawing.Size(107, 13);
            this.lbNgayChuyenDen.TabIndex = 28;
            this.lbNgayChuyenDen.Text = "Ngày chuyển đến";
            // 
            // lbMaNK
            // 
            this.lbMaNK.AutoSize = true;
            this.lbMaNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaNK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbMaNK.Location = new System.Drawing.Point(534, 62);
            this.lbMaNK.Name = "lbMaNK";
            this.lbMaNK.Size = new System.Drawing.Size(88, 13);
            this.lbMaNK.TabIndex = 27;
            this.lbMaNK.Text = "Mã nhân khẩu";
            // 
            // lbTu
            // 
            this.lbTu.AutoSize = true;
            this.lbTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbTu.Location = new System.Drawing.Point(298, 106);
            this.lbTu.Name = "lbTu";
            this.lbTu.Size = new System.Drawing.Size(22, 13);
            this.lbTu.TabIndex = 26;
            this.lbTu.Text = "Tử";
            // 
            // lbSoSHK
            // 
            this.lbSoSHK.AutoSize = true;
            this.lbSoSHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSoSHK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbSoSHK.Location = new System.Drawing.Point(289, 69);
            this.lbSoSHK.Name = "lbSoSHK";
            this.lbSoSHK.Size = new System.Drawing.Size(89, 13);
            this.lbSoSHK.TabIndex = 25;
            this.lbSoSHK.Text = "Số sổ hộ khẩu";
            // 
            // lbQuanHeCH
            // 
            this.lbQuanHeCH.AutoSize = true;
            this.lbQuanHeCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQuanHeCH.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbQuanHeCH.Location = new System.Drawing.Point(37, 106);
            this.lbQuanHeCH.Name = "lbQuanHeCH";
            this.lbQuanHeCH.Size = new System.Drawing.Size(76, 13);
            this.lbQuanHeCH.TabIndex = 24;
            this.lbQuanHeCH.Text = "Quan hệ CH";
            // 
            // lbMaTT
            // 
            this.lbMaTT.AutoSize = true;
            this.lbMaTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMaTT.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbMaTT.Location = new System.Drawing.Point(37, 69);
            this.lbMaTT.Name = "lbMaTT";
            this.lbMaTT.Size = new System.Drawing.Size(40, 13);
            this.lbMaTT.TabIndex = 23;
            this.lbMaTT.Text = "MaTT";
            // 
            // lbThuongTru
            // 
            this.lbThuongTru.AutoSize = true;
            this.lbThuongTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbThuongTru.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbThuongTru.Location = new System.Drawing.Point(219, 19);
            this.lbThuongTru.Name = "lbThuongTru";
            this.lbThuongTru.Size = new System.Drawing.Size(296, 18);
            this.lbThuongTru.TabIndex = 22;
            this.lbThuongTru.Text = "QUẢN LÝ NHÂN KHẨU THƯỜNG TRÚ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGTT);
            this.panel2.Location = new System.Drawing.Point(12, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 169);
            this.panel2.TabIndex = 1;
            // 
            // DGTT
            // 
            this.DGTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNKTT,
            this.MaNK,
            this.SoSHK,
            this.QuanHeCH,
            this.Tu,
            this.NgayChuyenDen,
            this.NoiThuongTruTruoc});
            this.DGTT.Location = new System.Drawing.Point(3, 15);
            this.DGTT.Name = "DGTT";
            this.DGTT.Size = new System.Drawing.Size(768, 138);
            this.DGTT.TabIndex = 0;
            this.DGTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTT_CellContentClick_1);
            // 
            // MaNKTT
            // 
            this.MaNKTT.DataPropertyName = "MaNKTT";
            this.MaNKTT.HeaderText = "Mã Nhân Khẩu Thường Trú";
            this.MaNKTT.Name = "MaNKTT";
            // 
            // MaNK
            // 
            this.MaNK.DataPropertyName = "MaNK";
            this.MaNK.HeaderText = "Mã Nhân Khẩu";
            this.MaNK.Name = "MaNK";
            // 
            // SoSHK
            // 
            this.SoSHK.DataPropertyName = "SoSHK";
            this.SoSHK.HeaderText = "Số Sổ Hộ Khẩu";
            this.SoSHK.Name = "SoSHK";
            // 
            // QuanHeCH
            // 
            this.QuanHeCH.DataPropertyName = "QuanHeCH";
            this.QuanHeCH.HeaderText = "Quan Hệ Với Chủ Hộ";
            this.QuanHeCH.Name = "QuanHeCH";
            // 
            // Tu
            // 
            this.Tu.DataPropertyName = "Tu";
            this.Tu.HeaderText = "Tử";
            this.Tu.Name = "Tu";
            // 
            // NgayChuyenDen
            // 
            this.NgayChuyenDen.DataPropertyName = "NgayChuyenDen";
            this.NgayChuyenDen.HeaderText = "Ngày Chuyển Đến";
            this.NgayChuyenDen.Name = "NgayChuyenDen";
            // 
            // NoiThuongTruTruoc
            // 
            this.NoiThuongTruTruoc.DataPropertyName = "NoiThuongTruTruoc";
            this.NoiThuongTruTruoc.HeaderText = "Nơi Thường Trú Trước";
            this.NoiThuongTruTruoc.Name = "NoiThuongTruTruoc";
            // 
            // frmThuongTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmThuongTru";
            this.Text = "frmThuongTru";
            this.Load += new System.EventHandler(this.frmThuongTru_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTu;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.TextBox txtNoiOTruoc;
        private System.Windows.Forms.TextBox txtSoSHK;
        private System.Windows.Forms.TextBox txtQHCH;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.Label lbNgayChuyenDen;
        private System.Windows.Forms.Label lbMaNK;
        private System.Windows.Forms.Label lbTu;
        private System.Windows.Forms.Label lbSoSHK;
        private System.Windows.Forms.Label lbQuanHeCH;
        private System.Windows.Forms.Label lbMaTT;
        private System.Windows.Forms.Label lbThuongTru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker DTPKNgayChuyenDen;
        private System.Windows.Forms.DataGridView DGTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNKTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuanHeCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChuyenDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiThuongTruTruoc;
    }
}