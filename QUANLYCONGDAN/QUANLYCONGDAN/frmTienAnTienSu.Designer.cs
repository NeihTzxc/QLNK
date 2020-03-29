namespace QUANLYCONGDAN
{
    partial class frmTienAnTienSu
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
            this.DTPKNgayVP = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbChon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btMoi = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.txtMaNK = new System.Windows.Forms.TextBox();
            this.txtMaTA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGTA = new System.Windows.Forms.DataGridView();
            this.MaTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPKNgayVP1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGTA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DTPKNgayVP1);
            this.panel1.Controls.Add(this.DTPKNgayVP);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.cbChon);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btTimkiem);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btMoi);
            this.panel1.Controls.Add(this.txtNoiDung);
            this.panel1.Controls.Add(this.txtLyDo);
            this.panel1.Controls.Add(this.txtMaNK);
            this.panel1.Controls.Add(this.txtMaTA);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 266);
            this.panel1.TabIndex = 0;
            // 
            // DTPKNgayVP
            // 
            this.DTPKNgayVP.Location = new System.Drawing.Point(562, 55);
            this.DTPKNgayVP.Name = "DTPKNgayVP";
            this.DTPKNgayVP.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayVP.TabIndex = 94;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(398, 225);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(177, 20);
            this.txtTimKiem.TabIndex = 93;
            // 
            // cbChon
            // 
            this.cbChon.FormattingEnabled = true;
            this.cbChon.Items.AddRange(new object[] {
            "Mã Tiền Án Tiền Sự",
            "Nội Dung",
            "Ngày Vi Phạm"});
            this.cbChon.Location = new System.Drawing.Point(197, 224);
            this.cbChon.Name = "cbChon";
            this.cbChon.Size = new System.Drawing.Size(121, 21);
            this.cbChon.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(143, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Chọn";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Azure;
            this.btThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(594, 153);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(81, 49);
            this.btThoat.TabIndex = 90;
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
            this.btTimkiem.Location = new System.Drawing.Point(594, 210);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(95, 48);
            this.btTimkiem.TabIndex = 89;
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
            this.btXoa.Location = new System.Drawing.Point(475, 153);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(77, 49);
            this.btXoa.TabIndex = 88;
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
            this.btSua.Location = new System.Drawing.Point(333, 153);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(82, 49);
            this.btSua.TabIndex = 87;
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
            this.btThem.Location = new System.Drawing.Point(197, 153);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(82, 49);
            this.btThem.TabIndex = 86;
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
            this.btMoi.Location = new System.Drawing.Point(72, 153);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(81, 49);
            this.btMoi.TabIndex = 85;
            this.btMoi.Text = "Mới";
            this.btMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btMoi.UseVisualStyleBackColor = false;
            this.btMoi.Click += new System.EventHandler(this.btMoi_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(333, 52);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(168, 20);
            this.txtNoiDung.TabIndex = 80;
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(333, 105);
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(168, 20);
            this.txtLyDo.TabIndex = 81;
            // 
            // txtMaNK
            // 
            this.txtMaNK.Location = new System.Drawing.Point(159, 109);
            this.txtMaNK.Name = "txtMaNK";
            this.txtMaNK.Size = new System.Drawing.Size(75, 20);
            this.txtMaNK.TabIndex = 82;
            // 
            // txtMaTA
            // 
            this.txtMaTA.Location = new System.Drawing.Point(159, 52);
            this.txtMaTA.Name = "txtMaTA";
            this.txtMaTA.Size = new System.Drawing.Size(75, 20);
            this.txtMaTA.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(559, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Ngày vi phạm";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(282, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Lý do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(277, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Nội dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(62, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mã nhân khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(62, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Mã tiền án tiền sự";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(260, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 74;
            this.label1.Text = "QUẢN LÝ TIỀN ÁN TIỀN SỰ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGTA);
            this.panel2.Location = new System.Drawing.Point(12, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 154);
            this.panel2.TabIndex = 1;
            // 
            // DGTA
            // 
            this.DGTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTA,
            this.NoiDung,
            this.LyDo,
            this.NgayVP,
            this.MaNK});
            this.DGTA.Location = new System.Drawing.Point(3, 3);
            this.DGTA.Name = "DGTA";
            this.DGTA.Size = new System.Drawing.Size(770, 148);
            this.DGTA.TabIndex = 54;
            this.DGTA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTA_CellContentClick);
            // 
            // MaTA
            // 
            this.MaTA.DataPropertyName = "MaTA";
            this.MaTA.HeaderText = "Mã Tiền Án";
            this.MaTA.Name = "MaTA";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.Name = "NoiDung";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.Name = "LyDo";
            // 
            // NgayVP
            // 
            this.NgayVP.DataPropertyName = "NgayVP";
            this.NgayVP.HeaderText = "Ngày Vi Phạm";
            this.NgayVP.Name = "NgayVP";
            // 
            // MaNK
            // 
            this.MaNK.DataPropertyName = "MaNK";
            this.MaNK.HeaderText = "Mã Nhân Khẩu";
            this.MaNK.Name = "MaNK";
            // 
            // DTPKNgayVP1
            // 
            this.DTPKNgayVP1.Location = new System.Drawing.Point(562, 109);
            this.DTPKNgayVP1.Name = "DTPKNgayVP1";
            this.DTPKNgayVP1.Size = new System.Drawing.Size(200, 20);
            this.DTPKNgayVP1.TabIndex = 95;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(519, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "Đến";
            // 
            // frmTienAnTienSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmTienAnTienSu";
            this.Text = "frmTienAnTienSu";
            this.Load += new System.EventHandler(this.frmTienAnTienSu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbChon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btMoi;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.TextBox txtMaNK;
        private System.Windows.Forms.TextBox txtMaTA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNK;
        private System.Windows.Forms.DateTimePicker DTPKNgayVP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPKNgayVP1;
    }
}