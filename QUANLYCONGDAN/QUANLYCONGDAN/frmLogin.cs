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
    public partial class frmLogin : Form
    {
        int dem;
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "")
            {
                MessageBox.Show("Nhập vào tên đăng nhâp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Focus();
                return;

            }
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Nhập vào mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatkhau.Focus();
                return;

            }
            if((txtTaikhoan.Text=="admin")&&(txtMatkhau.Text=="admin"))
            {
                MessageBox.Show("Đăng nhập thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = new frmChucNang();
                this.Hide();
                frm.Show();
                    
            }
            else
            {
                dem = dem + 1;
                if(dem<3)
                {
                    if (txtTaikhoan.Text != "admin")
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.Vui lòng đăng nhập lại!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaikhoan.Text = ""; 
                        txtTaikhoan.Focus();
                        return;
                    }
                    if (txtMatkhau.Text != "123")
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.Vui lòng đăng nhập lại!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatkhau.Text = "";
                        txtMatkhau.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần. Chương trình sẽ bị đóng!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát không?", "THÔNG BÁO!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "")
            {
                MessageBox.Show("Nhập vào tên đăng nhập!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Focus();
                return;
            }
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Nhập vào mật khẩu!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatkhau.Focus();
                return;
            }
            if ((txtMatkhau.Text == "admin") && (txtTaikhoan.Text == "admin"))
            {
                MessageBox.Show("Đăng nhập thành công!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form frm = new frmChucNang();
                this.Hide();
                frm.Show();
            }
            else
            {
                dem = dem + 1;
                if (dem < 3)
                {
                    if (txtTaikhoan.Text != "tienanh")
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.Vui lòng đăng nhập lại!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTaikhoan.Text = ""; txtTaikhoan.Focus(); return;
                    }
                    if (txtMatkhau.Text != "123")
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.Vui lòng đăng nhập lại!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMatkhau.Text = ""; txtMatkhau.Focus(); return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần. Chương trình sẽ bị đóng!", "THÔNG BÁO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
