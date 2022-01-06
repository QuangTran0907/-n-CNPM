using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKSThangLong.Model;

namespace QLKSThangLong
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }
        DbContextQLKS db = new DbContextQLKS();
        public List<TAIKHOAN> lisPass { get; set; }
        
        

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            foreach (var item in lisPass)
            {
                txtTaiKhoan.Text = item.TenTK;
            }
            txtMatKhauCu.PasswordChar = '*';
            txtMatKhauMoi.PasswordChar = '*';
            txtMatKhauMoiNhapLai.PasswordChar = '*';
            txtMatKhauCu.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in lisPass)
            {
                if (txtMatKhauCu.Text == item.MatKhau)
                {
                    if (txtMatKhauMoi.Text == txtMatKhauMoiNhapLai.Text)
                    {
                        item.MatKhau = txtMatKhauMoiNhapLai.Text;
                        db.TAIKHOANs.AddOrUpdate(item);
                        db.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                    MessageBox.Show("Mật khẩu không đúng!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void checkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienMK.Checked)
                txtMatKhauCu.PasswordChar = (char)0;
            else
                txtMatKhauCu.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
