using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKSThangLong.Model;

namespace QLKSThangLong
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DbContextQLKS dbcontent = new DbContextQLKS();
        bool checkUser()
        {
            List<TAIKHOAN> tAIKHOANs = dbcontent.TAIKHOANs.ToList();
            List<TAIKHOAN> login = new List<TAIKHOAN>();

            foreach (var item in tAIKHOANs)
            {
                var v = from c in tAIKHOANs
                        where c.TenTK == txtTaiKhoanDN.Text && c.MatKhau == txtMatKhauDN.Text
                        select c;
                login = v.ToList();


            }
            if (login.Count == 0)
            {
                MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu");
                return false;
            }
            else
            {
               
                Form1 con = new Form1();
                con.listCon = login.ToList();
                con.Show();
                this.Hide();
            }
            return true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkHienMK_CheckedChanged(object sender, EventArgs e)
        {

            if (checkHienMK.Checked)
                txtMatKhauDN.PasswordChar = (char)0;
            else
                txtMatKhauDN.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            checkUser();
        }
    }
}
