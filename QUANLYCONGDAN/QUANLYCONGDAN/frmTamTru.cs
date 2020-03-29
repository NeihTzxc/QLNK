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
    public partial class frmTamTru : Form

    {
        SqlCommand cmmSearch;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-SC8BOSU;Initial Catalog=QLNK;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.TamTru";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGTT.DataSource = table;
        }
        public frmTamTru()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mkNgayDen_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmTamTru_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMaNK.Text = "";
            txtMaTT.Text = "";
            txtNoiO.Text = "";
           // cbChon.Text = "";
            loaddata();
        }

        private void DGTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaTT.ReadOnly = true;
            i = DGTT.CurrentRow.Index;
            txtMaTT.Text = DGTT.Rows[i].Cells[0].Value.ToString();
            DTPKNgayDi.Text = DGTT.Rows[i].Cells[1].Value.ToString();
            DTPKNgayDen.Text = DGTT.Rows[i].Cells[2].Value.ToString();
            txtNoiO.Text = DGTT.Rows[i].Cells[3].Value.ToString();
            txtMaNK.Text = DGTT.Rows[i].Cells[4].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.TamTru(NgayDi,NgayDen,NoiO,MaNK) VALUES ('"+DTPKNgayDi.Value+"', '"+DTPKNgayDen.Value+"', N'"+txtNoiO.Text+"', "+nk+")";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int tt = Convert.ToInt32(txtMaTT.Text);
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "UPDATE dbo.TamTru SET NgayDi='"+DTPKNgayDi.Value+"',NgayDen='"+DTPKNgayDen.Value+"',NoiO=N'"+txtNoiO.Text+"',MaNK="+nk+" WHERE MaTT="+tt+"";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int tt = Convert.ToInt32(txtMaTT.Text);
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM dbo.TamTru WHERE MaTT='"+tt+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            cmmSearch = connection.CreateCommand();


            if (cbChon.Text == "Mã Tạm Trú")
            {
                int n;
                if (int.TryParse(this.txtTimKiem.Text, out n))
                {
                    int tt = Convert.ToInt32(txtTimKiem.Text);
                    cmmSearch.CommandText = "SELECT * FROM dbo.TamTru WHERE MaTT =" + tt + "";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGTT.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }

            }
            if (cbChon.Text == "Nơi Ở")
            {
                cmmSearch.CommandText = " SELECT * FROM dbo.TamTru WHERE dbo.fuConvertToUnsign1(NoiO) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTimKiem.Text + "') + '%'";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGTT.DataSource = table;

            }
            if (cbChon.Text == "Mã Nhân Khẩu")
            {
                int n;
                if (int.TryParse(this.txtTimKiem.Text, out n))
                {
                    int nk = Convert.ToInt32(txtTimKiem.Text);
                    cmmSearch.CommandText = "SELECT * FROM dbo.TamTru WHERE MaNK =" + nk + "";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGTT.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }

            }
            if (cbChon.Text == "Ngày Tháng")
            {
               
                    cmmSearch.CommandText = "SELECT * FROM dbo.TamTru WHERE NgayDen BETWEEN '"+DTPKNgayDi.Value+"' AND '"+DTPKNgayDen.Value+"' ";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGTT.DataSource = table;
                

            }
            if (DGTT.RowCount <= 1)
            {
                MessageBox.Show("Không có kết quả");
            }
        }
    }
}
