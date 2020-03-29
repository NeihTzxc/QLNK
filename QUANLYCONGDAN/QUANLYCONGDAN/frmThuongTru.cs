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
    public partial class frmThuongTru : Form

    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-SC8BOSU;Initial Catalog=QLNK;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM dbo.ThuongTru";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGTT.DataSource = table;
        }
        public frmThuongTru()
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

        private void frmThuongTru_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMaNK.Text = "";
            txtMaTT.Text = "";
            txtNoiOTruoc.Text = "";
            txtQHCH.Text = "";
            txtSoSHK.Text = "";
            cbTu.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DGTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.ThuongTru( MaNK ,SoSHK,QuanHeCH,Tu,NgayChuyenDen,NoiThuongTruTruoc) VALUES  ( "+nk+" , '"+txtSoSHK.Text+"' , N'"+txtQHCH.Text+"' ,  N'"+cbTu.Text+"' ,'"+DTPKNgayChuyenDen.Value+"' ,N'"+txtNoiOTruoc.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void DGTT_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaTT.ReadOnly = true;
            i = DGTT.CurrentRow.Index;
            txtMaTT.Text = DGTT.Rows[i].Cells[0].Value.ToString();
            txtMaNK.Text = DGTT.Rows[i].Cells[1].Value.ToString();
            txtSoSHK.Text = DGTT.Rows[i].Cells[2].Value.ToString();
            txtQHCH.Text = DGTT.Rows[i].Cells[3].Value.ToString();
            cbTu.Text = DGTT.Rows[i].Cells[4].Value.ToString();
            DTPKNgayChuyenDen.Text = DGTT.Rows[i].Cells[5].Value.ToString();
            txtNoiOTruoc.Text = DGTT.Rows[i].Cells[6].Value.ToString();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int nk = Convert.ToInt32(txtMaNK.Text);
            command = connection.CreateCommand();
            command.CommandText = " UPDATE dbo.ThuongTru SET MaNK="+nk+",SoSHK='"+txtSoSHK.Text+"',QuanHeCH=N'"+txtSoSHK.Text+"',Tu=N'"+cbTu.Text+"',NgayChuyenDen='"+DTPKNgayChuyenDen.Value+"',NoiThuongTruTruoc=N'"+txtNoiOTruoc.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int tt = Convert.ToInt32(txtMaTT.Text);
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM dbo.ThuongTru WHERE MaTV='" + tt + "'";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
