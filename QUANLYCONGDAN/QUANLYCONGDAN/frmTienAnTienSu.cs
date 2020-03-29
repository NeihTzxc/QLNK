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
    public partial class frmTienAnTienSu : Form
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
            command.CommandText = "SELECT * FROM dbo.TienAnTienSu";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGTA.DataSource = table;
        }
        public frmTienAnTienSu()
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

        private void frmTienAnTienSu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void DGTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaTA.ReadOnly = true;
            i = DGTA.CurrentRow.Index;
            txtMaTA.Text = DGTA.Rows[i].Cells[0].Value.ToString();
            txtNoiDung.Text = DGTA.Rows[i].Cells[1].Value.ToString();
            txtLyDo.Text = DGTA.Rows[i].Cells[2].Value.ToString();
            DTPKNgayVP.Text = DGTA.Rows[i].Cells[3].Value.ToString();
            txtMaNK.Text = DGTA.Rows[i].Cells[4].Value.ToString();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.TienAnTienSu(NoiDung,LyDo,NgayVP,MaNK ) VALUES ( N'"+txtNoiDung.Text+"', N'"+txtLyDo.Text+"','"+DTPKNgayVP.Value+"',"+nk+")";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int ta = Convert.ToInt32(txtMaTA.Text);
            
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "UPDATE dbo.TienAnTienSu SET NoiDung=N'"+txtNoiDung.Text+"',LyDo=N'"+txtLyDo.Text+"',NgayVP='"+DTPKNgayVP.Value+"',MaNK="+nk+" where MaTA="+ta+"";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int ta = Convert.ToInt32(txtMaTA.Text);
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM dbo.Tamvang WHERE MaTA='" + ta + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            cmmSearch = connection.CreateCommand();
            if (cbChon.Text == "Mã Tiền Án Tiền Sự")
            {
                int n;
                if (int.TryParse(this.txtTimKiem.Text, out n))
                {
                    int ta = Convert.ToInt32(txtTimKiem.Text);
                    cmmSearch.CommandText = "SELECT * FROM dbo.TienAnTienSu WHERE MaTA ="+ta+"";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGTA.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }

            }
            if (cbChon.Text == "Nội Dung")
            {
                cmmSearch.CommandText = " SELECT * FROM dbo.TienAnTienSu WHERE dbo.fuConvertToUnsign1(NoiDung) LIKE N'%' + dbo.fuConvertToUnsign1(N'" + txtTimKiem.Text + "') + '%'";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGTA.DataSource = table;

            }
            if (cbChon.Text == "Ngày Vi Phạm")
            {

                cmmSearch.CommandText = "SELECT * FROM dbo.TienAnTienSu WHERE NgayVP BETWEEN '" + DTPKNgayVP.Value + "' AND '" + DTPKNgayVP1.Value + "' ";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGTA.DataSource = table;


            }
            if (DGTA.RowCount <= 1)
            {
                MessageBox.Show("Không có kết quả");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtLyDo.Text = "";
            txtMaNK.Text = "";
            txtMaTA.Text = "";
            txtNoiDung.Text = "";
            loaddata();
        }
    }
}
