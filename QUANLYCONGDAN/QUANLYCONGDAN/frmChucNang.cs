using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYCONGDAN
{
    public partial class frmChucNang : Form
    {
        public frmChucNang()
        {
            InitializeComponent();
        }

        private void qlNhanKhau_Click(object sender, EventArgs e)
        {
            frmNhanKhau frmNhanKhau = new frmNhanKhau();
            frmNhanKhau.Show();
            this.Hide();
        }
        private void qlTamTru_Click(object sender, EventArgs e)
        {
            frmTamTru frmTamTru = new frmTamTru();
            frmTamTru.Show();
            this.Hide();
        }
        private void qlTamVang_Click(object sender, EventArgs e)
        {
            frmTamVang frmTamVang = new frmTamVang();
            frmTamVang.Show();
            this.Hide();
        }

        private void qlTamVang_Click_1(object sender, EventArgs e)
        {
            frmTamVang frmTamVang = new frmTamVang();
            frmTamVang.Show();
            this.Hide();
        }

        private void qlTienAnTienSu_Click(object sender, EventArgs e)
        {
            frmTienAnTienSu frmTienAnTienSu = new frmTienAnTienSu();
            frmTienAnTienSu.Show();
            this.Hide();

        }

        private void qlSoHoKhau_Click(object sender, EventArgs e)
        {
            frmSoHoKhau frmSoHoKhau = new frmSoHoKhau();
            frmSoHoKhau.Show();
            this.Hide();
        }

        private void qlThuongTru_Click(object sender, EventArgs e)
        {
            frmThuongTru frmThuongTru = new frmThuongTru();
            frmThuongTru.Show();
            this.Hide();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frmThongKe = new frmThongKe();
            frmThongKe.Show();
            this.Hide();
        }

        private void qlTamTru_Click_1(object sender, EventArgs e)
        {
            frmTamTru frmTamTru = new frmTamTru();
            frmTamTru.Show();
            this.Hide();
        }
    }
}
