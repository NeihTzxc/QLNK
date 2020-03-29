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
    public partial class frmThongKe : Form
    {
       


        public frmThongKe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn quay lại không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmChucNang frmchinh = new frmChucNang();
                frmchinh.Show();
                this.Hide();
            }
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            /*
             SqlConnection connection;
             SqlCommand command ;
             string str = @"Data Source=DESKTOP-SC8BOSU;Initial Catalog=QLNK;Integrated Security=True";*/
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SC8BOSU;Initial Catalog=QLNK;Integrated Security=True");
            
            SqlCommand commNK = conn.CreateCommand();
            commNK.CommandText = "SELECT COUNT(*) FROM dbo.NhanKhau";

            SqlCommand commTamTru = conn.CreateCommand();
            commTamTru.CommandText = "SELECT COUNT(*) FROM dbo.TamTru";

            SqlCommand commTV = conn.CreateCommand();
            commTV.CommandText = "SELECT COUNT(*) FROM dbo.TamVang";

            SqlCommand commThuongTru = conn.CreateCommand();
            commThuongTru.CommandText = "SELECT COUNT(*) FROM dbo.ThuongTru";

            SqlCommand commTA = conn.CreateCommand();
            commTA.CommandText = "SELECT COUNT(*) FROM dbo.TienAnTienSu";

            conn.Open();

            int countNK = (int)commNK.ExecuteScalar();
            txtSoLuongNK.Text = countNK.ToString();

            int countTamTru = (int)commTamTru.ExecuteScalar();
            txtSoLuongTamTru.Text = countTamTru.ToString();

            int countTV = (int)commTV.ExecuteScalar();
            txtSoLuongTV.Text = countTV.ToString();

            int countThuongTru = (int)commThuongTru.ExecuteScalar();
            txtSoLuongThuongTru.Text = countThuongTru.ToString();

            int countTA = (int)commTA.ExecuteScalar();
            txtSoLuongTA.Text = countTA.ToString();




        }
    }
}
