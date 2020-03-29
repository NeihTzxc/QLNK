using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCONGDAN
{
    public partial class frmSoHoKhau : Form
    {
        
        SqlConnection connection;
        SqlCommand command;
        SqlCommand cmmSearch;
        string str = @"Data Source=DESKTOP-SC8BOSU;Initial Catalog=QLNK;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.SoHoKhau";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGSHK.DataSource = table;
        }
        public frmSoHoKhau()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn quay lại không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmChucNang frmchinh = new frmChucNang();
                frmchinh.Show();
                this.Hide();
            }
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            /*Số Sổ Hộ Khẩu
Tên Chủ Hộ
Nơi Thường Trú
Ngày Cấp*/

            cmmSearch = connection.CreateCommand();
            if (cbChon.Text == "Số Sổ Hộ Khẩu")
            {
                int n;
                if (int.TryParse(this.txtTimKiem.Text, out n))
                {
                    
                    cmmSearch.CommandText = "SELECT * FROM dbo.SoHoKhau WHERE SoSHK ='"+txtTimKiem.Text+"'";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGSHK.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }

            }
            if (cbChon.Text == "Tên Chủ Hộ")
            {
                cmmSearch.CommandText = " SELECT * FROM dbo.SoHoKhau WHERE dbo.fuConvertToUnsign1(TenChuHo) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTimKiem.Text + "') + '%'";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGSHK.DataSource = table;

            }
            if (cbChon.Text == "Nơi Thường Trú")
            {
                cmmSearch.CommandText = " SELECT * FROM dbo.SoHoKhau WHERE dbo.fuConvertToUnsign1(NoiThuongTru) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTimKiem.Text + "') + '%'";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGSHK.DataSource = table;

            }
            if (cbChon.Text == "Ngày Cấp")
            {
                cmmSearch.CommandText = "SELECT * FROM dbo.SoHoKhau WHERE NgayDen BETWEEN '" + DTPKNgayCap.Value + "' AND '" + DTPKNgayCap1.Value + "' ";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGSHK.DataSource = table;
            }


        }

        private void frmSoHoKhau_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtNoiThuongTru.Text = "";
            txtSoHoKhau.Text = "";
            txtTenChuHo.Text = "";
            cbChon.Text = "";
           
        }

        private void cbTV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DGSHK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            
            i = DGSHK.CurrentRow.Index;
           txtSoHoKhau.Text = DGSHK.Rows[i].Cells[0].Value.ToString();
            txtNoiThuongTru.Text = DGSHK.Rows[i].Cells[1].Value.ToString();
           txtTenChuHo.Text = DGSHK.Rows[i].Cells[2].Value.ToString();
            DTPKNgayCap.Text = DGSHK.Rows[i].Cells[3].Value.ToString();
            
        }
        void loadDTPKNgayCap()
        {
            DateTime today = DateTime.Now;
            DTPKNgayCap.Value = new DateTime(today.Year, today.Month, today.Day);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.SoHoKhau(SoSHK, NoiThuongTru, TenChuHo, NgayCap) VALUES('"+txtSoHoKhau.Text+"', N'"+txtNoiThuongTru.Text+"', N'"+txtTenChuHo.Text+"', '"+DTPKNgayCap.Value+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM dbo.SoHoKhau WHERE SoSHK = '"+txtSoHoKhau.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
             command.CommandText = "UPDATE dbo.SoHoKhau SET  NoiThuongTru=N'"+txtNoiThuongTru.Text+"', TenChuHo=N'"+txtTenChuHo.Text+"', NgayCap='"+DTPKNgayCap.Value+ "' WHERE SoSHK='"+txtSoHoKhau.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
