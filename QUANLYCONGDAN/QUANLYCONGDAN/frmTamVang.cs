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
    public partial class frmTamVang : Form
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
            command.CommandText = "SELECT * FROM dbo.TamVang";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGTV.DataSource = table;
        }
        public frmTamVang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn quay lại không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                frmChucNang frmchinh = new frmChucNang();
                frmchinh.Show();
                this.Hide();
            }
        }

        private void frmTamVang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void txtLyDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMaTV.Text = "";
            txtMaNK.Text = "";
            txtNoiDen.Text="";
            txtLyDo.Text = "";
            cbChon.Text = "";

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.TamVang(NgayVe,NgayDi,NoiDen,LyDo,MaNK ) VALUES  ( '"+DTPKNgayVe.Value+"', '"+DTPKNgayDi.Value+"', N'"+txtNoiDen.Text+"',N'"+txtLyDo.Text+"',"+nk+")";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void DGTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaTV.ReadOnly = true;
            i = DGTV.CurrentRow.Index;
            txtMaTV.Text = DGTV.Rows[i].Cells[0].Value.ToString();
            DTPKNgayVe.Text = DGTV.Rows[i].Cells[1].Value.ToString();
            DTPKNgayDi.Text = DGTV.Rows[i].Cells[2].Value.ToString();
            txtNoiDen.Text = DGTV.Rows[i].Cells[3].Value.ToString();
            txtLyDo.Text = DGTV.Rows[i].Cells[4].Value.ToString();
            txtMaNK.Text = DGTV.Rows[i].Cells[5].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int tv = Convert.ToInt32(txtMaTV.Text);
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "UPDATE dbo.TamVang SET NgayVe='"+DTPKNgayVe.Value+"',NgayDi='"+DTPKNgayDi.Value+"',NoiDen=N'"+txtNoiDen.Text+"',LyDo=N'"+txtNoiDen.Text+"',MaNK="+nk+" WHERE MaTV="+tv+"";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int tv = Convert.ToInt32(txtMaTV.Text);
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM dbo.Tamvang WHERE MaTV='" + tv + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            cmmSearch = connection.CreateCommand();
            if (cbChon.Text == "Mã Tạm Vắng")
            {
                int n;
                if (int.TryParse(this.txtTimKiem.Text, out n))
                {
                    int tv = Convert.ToInt32(txtTimKiem.Text);
                    cmmSearch.CommandText = "SELECT * FROM dbo.TamVang WHERE MaTV =" + tv + "";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGTV.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }

            }
            if (cbChon.Text == "Nơi Đến")
            {
                cmmSearch.CommandText = " SELECT * FROM dbo.TamVang WHERE dbo.fuConvertToUnsign1(NoiDen) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTimKiem.Text + "') + '%'";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGTV.DataSource = table;

            }
            if (DGTV.RowCount <= 1)
            {
                MessageBox.Show("Không có kết quả");
            }
        }
    }
}
