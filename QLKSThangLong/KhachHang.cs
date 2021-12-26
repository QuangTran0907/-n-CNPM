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
    public partial class KhachHang : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        
        public KhachHang()
        {
            InitializeComponent();
        }

     

        private void KhachHang_Load(object sender, EventArgs e)
        {
            List<KHACHHANG> listKH = db.KHACHHANGs.ToList();
            FillDataDGV(listKH);
        }
        private void FillDataDGV(List<KHACHHANG> listKH)
        {
            dgvQLKH.Rows.Clear();
            foreach (var item in listKH)
            {
                int newRow = dgvQLKH.Rows.Add();
                dgvQLKH.Rows[newRow].Cells[0].Value = item.MaKH;
                dgvQLKH.Rows[newRow].Cells[1].Value = item.TenKH;
                dgvQLKH.Rows[newRow].Cells[2].Value = item.CMND_CCCD;
                dgvQLKH.Rows[newRow].Cells[3].Value = item.SDT;

            }
        }

        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLKH.CurrentCell.Selected = true;

                    txtMaKH.Text = dgvQLKH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenKH.Text = dgvQLKH.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtCMND.Text = dgvQLKH.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtSDTKH.Text = dgvQLKH.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void loadForm()
        {

            txtMaKH.Clear();
            txtTenKH.Clear();
            txtCMND.Clear();
            txtSDTKH.Clear();
        }
        private void loadDGV()
        {
            List<KHACHHANG> listKH = db.KHACHHANGs.ToList();
            FillDataDGV(listKH);
        }
        private bool checkMaKH(string check)
        {
           
            for (int i = 0; i < dgvQLKH.Rows.Count; i++)
            {
                if (dgvQLKH.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLKH.Rows[i].Cells[0].Value.ToString() == check)
                        return true;
                }
            }
            return false;
        }
        private bool CheckDataInput()
        {
            if (txtTenKH.Text == "" || txtCMND.Text == "" || txtSDTKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }

        }
        private string Auto_ID()
        {
            string makh=""  ;
            for (int i = 0; i < dgvQLKH.Rows.Count; i++)
            {
                if (dgvQLKH.Rows.Count < 10)
                    makh = $"KH0{i}";
                    
                else
                    makh = $"KH{i}";
            }
            return makh;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                if (checkMaKH(txtMaKH.Text) == false)
                {
                    KHACHHANG x = new KHACHHANG();
                    x.MaKH = Auto_ID();
                    x.TenKH = txtTenKH.Text;
                    x.CMND_CCCD = txtCMND.Text;
                    x.SDT = txtSDTKH.Text;
                    db.KHACHHANGs.AddOrUpdate(x);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();

                    MessageBox.Show("Thêm khách hàng thành công ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Khách hàng đã tồn tại ", "Thông báo");
                }
            }
        }

        private void btnCapNhatKH_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                KHACHHANG x = db.KHACHHANGs.Where(p => p.MaKH == txtMaKH.Text).FirstOrDefault();
                if (x != null)
                {
                    x.MaKH = txtMaKH.Text;
                    x.TenKH = txtTenKH.Text;
                    x.CMND_CCCD = txtCMND.Text;
                    x.SDT = txtSDTKH.Text;
                    db.KHACHHANGs.AddOrUpdate(x);
                    db.SaveChanges();
                    loadForm();
                    loadDGV();
                    MessageBox.Show("Cập nhât đối tượng thành công ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không có đối tượng nào trong danh sách ", "Thông báo");

                }
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                KHACHHANG x = db.KHACHHANGs.Where(p => p.MaKH == txtMaKH.Text).FirstOrDefault();
                if (x != null)
                {
                    x.MaKH = txtMaKH.Text;
                    x.TenKH = txtTenKH.Text;
                    x.CMND_CCCD = txtCMND.Text;
                    x.SDT = txtSDTKH.Text;
                    db.KHACHHANGs.Remove(x);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();
                    MessageBox.Show("Xóa đối tượng thành công ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không có đối tượng nào trong danh sách ", "Thông báo");

                }
            }
        }

        private void btnResetKH_Click(object sender, EventArgs e)
        {
            loadDGV();
            loadForm();
        }

        private void btnTroVeKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            var result = from c in db.KHACHHANGs
                         where c.TenKH.Contains(txtTimKH.Text)
                         select c;

            FillDataDGV(result.ToList());
        }
    }
}
