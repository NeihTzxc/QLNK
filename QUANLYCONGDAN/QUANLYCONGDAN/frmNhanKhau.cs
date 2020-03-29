using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QUANLYCONGDAN
{
    public partial class frmNhanKhau : Form
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
            command.CommandText = "SELECT * FROM dbo.NhanKhau";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DGNK.DataSource = table;
        }
        public frmNhanKhau()
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
        void loadDTPKNgaySinh()
        {
            DateTime today = DateTime.Now;
            txtNgaySinh.Value = new DateTime(today.Year, today.Month, today.Day);
        }

        private void btMoi_Click(object sender, EventArgs e)
        {
            txtMaNK.Text = "";
            txtHoTen.Text = "";
            txtTenGK.Text = "";
           // txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtTonGiao.Text = "";
            txtDanToc.Text = "";
            txtTrinhDo.Text = "";
            cbGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtNoiSinh.Text = "";
            txtNgheNghiep.Text = "";
            txtQuocTich.Text = "";
            loaddata();
            //cbchon.Text = "";
           /* txtMaNK.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btNhap.Enabled = true;*/


        }
        //SqlConnection cnn = new SqlConnection(@"Data Source = DESKTOP - SC8BOSU; Initial Catalog = QLNK; Integrated Security = True");
        

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            cmmSearch= connection.CreateCommand();
           

            if (cbchon.Text=="Mã Nhân Khẩu")
            {
                int n;
                if(int.TryParse(this.txtTimKiem.Text,out n))
                {
                    int nk = Convert.ToInt32(txtTimKiem.Text);
                    cmmSearch.CommandText = "SELECT * FROM dbo.NhanKhau WHERE MaNK =" + nk + "";
                    cmmSearch.ExecuteNonQuery();
                    adapter.SelectCommand = cmmSearch;
                    table.Clear();
                    adapter.Fill(table);
                    DGNK.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng");
                }
                
            }
            if(cbchon.Text=="Họ Và Tên")
            {
                cmmSearch.CommandText = " SELECT * FROM dbo.NhanKhau WHERE dbo.fuConvertToUnsign1(HoTen) LIKE N'%' + dbo.fuConvertToUnsign1(N'"+txtTimKiem.Text+"') + '%'";
                cmmSearch.ExecuteNonQuery();
                adapter.SelectCommand = cmmSearch;
                table.Clear();
                adapter.Fill(table);
                DGNK.DataSource = table;
                
            }
            if (DGNK.RowCount <= 1)
            {
                MessageBox.Show("Không có kết quả");
            }



        }

        private void frmNhanKhau_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void DGNK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            txtMaNK.ReadOnly = true;
            i = DGNK.CurrentRow.Index;
            txtMaNK.Text = DGNK.Rows[i].Cells[0].Value.ToString();
            txtHoTen.Text = DGNK.Rows[i].Cells[1].Value.ToString();
            txtTenGK.Text = DGNK.Rows[i].Cells[2].Value.ToString();
            txtNgaySinh.Text = DGNK.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = DGNK.Rows[i].Cells[4].Value.ToString();
            txtCMND.Text = DGNK.Rows[i].Cells[5].Value.ToString();
            txtTonGiao.Text = DGNK.Rows[i].Cells[6].Value.ToString();
            txtDanToc.Text = DGNK.Rows[i].Cells[7].Value.ToString();
            txtTrinhDo.Text = DGNK.Rows[i].Cells[8].Value.ToString();
            cbGioiTinh.Text = DGNK.Rows[i].Cells[9].Value.ToString();
            txtQueQuan.Text = DGNK.Rows[i].Cells[10].Value.ToString();
            txtNoiSinh.Text = DGNK.Rows[i].Cells[11].Value.ToString();
            txtNgheNghiep.Text = DGNK.Rows[i].Cells[12].Value.ToString();
            txtQuocTich.Text = DGNK.Rows[i].Cells[13].Value.ToString();
            Text = DGNK.Rows[i].Cells[0].Value.ToString();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "INSERT INTO dbo.NhanKhau ( HoTen , TenGK ,NgaySinh ,SDT ,CMND ,TonGiao ,DanToc ,TrinhDo ,GioiTinh ,QueQuan ,NoiSinh ,NgheNghiep ,QuocTich) VALUES (N'"+txtHoTen.Text+"', N'"+txtTenGK.Text+"', '"+txtNgaySinh.Value+"', '"+txtSDT.Text+"', '"+txtCMND.Text+"', N'"+txtTonGiao.Text+"', N'"+txtDanToc.Text+"', N'"+txtTrinhDo.Text+"', N'"+cbGioiTinh.Text+"', N'"+txtQueQuan.Text+"', N'"+txtNoiSinh.Text+"', N'"+txtNgheNghiep.Text+"', N'"+txtQuocTich.Text+"')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            command = connection.CreateCommand();
           int nk = Convert.ToInt32(txtMaNK.Text);
            command.CommandText= "DELETE FROM dbo.NhanKhau WHERE MaNK="+nk+";";
            command.ExecuteNonQuery();
            loaddata();

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            int nk = Convert.ToInt32(txtMaNK.Text);
            //command.CommandText = "UPDATE dbo.NhanKhau SET HoTen=N'"+txtHoTen.Text+"',TenGK=N'"+txtTenGK.Text+"',NgaySinh='"+txtNgaySinh.Text+"',SDT='"+txtSDT.Text+"',CMND='"+txtCMND.Text+"',TonGiao=N'"+txtTonGiao.Text+"',DanToc=N'"+txtDanToc.Text+"',TrinhDo=N'"+txtTrinhDo.Text+"',GioiTinh=N'"+cbGioiTinh.Text+"',QueQuan=N'"+txtQueQuan.Text+"',NoiSinh=N'"+txtNoiSinh.Text+"',NgheNghiep=N'"+txtNgheNghiep.Text+"',DanToc=N'"+txtDanToc.Text+"' WHERE MaNK="+nk+"";
            command.CommandText = "Update dbo.NhanKhau Set HoTen=N'"+txtHoTen.Text+"', TenGK=N'"+txtTenGK.Text+"', NgaySinh='"+txtNgaySinh.Value+"', SDT='"+txtSDT.Text+ "', CMND='"+txtCMND.Text+ "',TonGiao=N'"+txtTonGiao.Text+"',DanToc=N'"+txtDanToc.Text+ "', TrinhDo=N'"+txtTrinhDo.Text +"', GioiTinh=N'"+cbGioiTinh.Text+ "', QueQuan=N'"+txtQueQuan.Text+"', NoiSinh=N'"+txtNoiSinh.Text+ "', NgheNghiep=N'"+txtNgheNghiep.Text+ "', QuocTich=N'"+txtQuocTich.Text+"' where MaNK=" + nk+"";
            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
