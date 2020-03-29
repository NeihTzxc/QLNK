namespace QUANLYCONGDAN
{
    partial class frmTamTru
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
            this.DTPKNgayDen = new System.Windows.Forms.DateTimePicker();
            this.DTPKNgayDi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btMoi = new System.Windows.Forms.Button();
            this.txtNoiO = new System.Windows.Forms.MaskedTextBox();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGTT = new System.Windows.Forms.DataGridView();
            this.MaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DTPKNgayDen);
            this.panel1.Controls.Add(this.DTPKNgayDi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbChon);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btTimkiem);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btMoi);
            this.panel1.Controls.Add(this.txtNoiO);
            this.panel1.Controls.Add(this.txtMaNK);
            this.panel1.Controls.Add(this.txtMaTT);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 245);
            this.panel1.TabIndex = 0;
            // 
            // DTPKNgayDen
            // 
            this.DTPKNgayDen.Location = new System.Drawing.Point(554, 64);
            this.DTPKNgayDen.Name = "DTPKNgayDen";
            this.DTPKNgayDen.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayDen.TabIndex = 81;
            this.DTPKNgayDen.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // DTPKNgayDi
            // 
            this.DTPKNgayDi.Location = new System.Drawing.Point(269, 64);
            this.DTPKNgayDi.Name = "DTPKNgayDi";
            this.DTPKNgayDi.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayDi.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(492, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Ngày đến";
            // 
            // cbChon
            // 
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Items.AddRange(new object[] {
            "Mã Tạm Trú",
            "Nơi Ở",
            "Mã Nhân Khẩu",
            "Ngày Tháng"});
            this.cbChon.Location = new System.Drawing.Point(232, 195);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(121, 21);
            this.cbChon.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(178, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Chọn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(389, 191);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(157, 20);
            this.txtTimKiem.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = "QUẢN LÝ TẠM TRÚ\r\n";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Azure;
            this.btThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(631, 136);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 31);
            this.btThoat.TabIndex = 72;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTimkiem
            // 
            this.btTimkiem.BackColor = System.Drawing.Color.Azure;
            this.btTimkiem.ForeColor = System.Drawing.Color.Maroon;
            this.btTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimkiem.Location = new System.Drawing.Point(565, 189);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(96, 31);
            this.btTimkiem.TabIndex = 67;
            this.btTimkiem.Text = "Tìm Kiếm";
            this.btTimkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTimkiem.UseVisualStyleBackColor = false;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Azure;
            this.btXoa.ForeColor = System.Drawing.Color.Maroon;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(505, 136);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(84, 31);
            this.btXoa.TabIndex = 68;
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
            this.btSua.Location = new System.Drawing.Point(373, 136);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(86, 31);
            this.btSua.TabIndex = 69;
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
            this.btThem.Location = new System.Drawing.Point(251, 136);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(83, 31);
            this.btThem.TabIndex = 70;
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
            this.btMoi.Location = new System.Drawing.Point(124, 136);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(86, 31);
            this.btMoi.TabIndex = 71;
            this.btMoi.Text = "Mới";
            this.btMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // txtNoiO
            // 
            this.txtNoiO.Location = new System.Drawing.Point(373, 96);
            this.txtNoiO.Name = "txtNoiO";
            this.txtNoiO.Size = new System.Drawing.Size(279, 20);
            this.txtNoiO.TabIndex = 66;
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(124, 100);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(72, 20);
            this.txtMaNK.TabIndex = 64;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(124, 63);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(72, 20);
            this.txtMaTT.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(39, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Mã nhân khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(302, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Nơi ở";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(216, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Ngày đi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Mã tạm trú\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGTT);
            this.panel2.Location = new System.Drawing.Point(12, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 156);
            this.panel2.TabIndex = 1;
            // 
            // DGTT
            // 
            this.DGTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTT,
            this.NgayDi,
            this.NgayDen,
            this.NoiO});
            this.DGTT.Location = new System.Drawing.Point(21, 16);
            this.DGTT.Name = "DGTT";
            this.DGTT.Size = new System.Drawing.Size(733, 125);
            this.DGTT.TabIndex = 56;
            this.DGTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTT_CellContentClick);
            // 
            // MaTT
            // 
            this.MaTT.DataPropertyName = "MaTT";
            this.MaTT.HeaderText = "Mã Tạm Trú";
            this.MaTT.Name = "MaTT";
            // 
            // NgayDi
            // 
            this.NgayDi.DataPropertyName = "NgayDi";
            this.NgayDi.HeaderText = "Ngày Đi";
            this.NgayDi.Name = "NgayDi";
            // 
            // NgayDen
            // 
            this.NgayDen.DataPropertyName = "NgayDen";
            this.NgayDen.HeaderText = "Ngày Đến";
            this.NgayDen.Name = "NgayDen";
            // 
            // NoiO
            // 
            this.NoiO.DataPropertyName = "NoiO";
            this.NoiO.HeaderText = "Nơi Ở";
            this.NoiO.Name = "NoiO";
            // 
            // frmTamTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTamTru";
            this.Text = "frmTamTru";
            this.Load += new System.EventHandler(this.frmTamTru_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.MaskedTextBox txtNoiO;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiO;
        private System.Windows.Forms.DateTimePicker DTPKNgayDen;
        private System.Windows.Forms.DateTimePicker DTPKNgayDi;
    }
}