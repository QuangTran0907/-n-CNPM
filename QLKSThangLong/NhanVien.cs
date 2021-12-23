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
    public partial class NhanVien : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = db.NHANVIENs.ToList();
            FillDataDGV(listNV);
            loadForm();
        }
        private void FillDataDGV(List<NHANVIEN> listNV)
        {
            dgvQLNV.Rows.Clear();
            foreach (var item in listNV)
            {
                int newRow = dgvQLNV.Rows.Add();
                dgvQLNV.Rows[newRow].Cells[0].Value = item.MaNV;
                dgvQLNV.Rows[newRow].Cells[1].Value = item.TenNV;
                dgvQLNV.Rows[newRow].Cells[2].Value = item.GioiTinh;
                dgvQLNV.Rows[newRow].Cells[3].Value = item.BoPhanLamViec;
                dgvQLNV.Rows[newRow].Cells[4].Value = item.SDT;
                dgvQLNV.Rows[newRow].Cells[5].Value = item.DiaChi;
            }
        }

        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLNV.CurrentCell.Selected = true;

                    txtMaNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cbbBoPhanLamViec.Text = dgvQLNV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtSDTNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtDiaChiNV.Text = dgvQLNV.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                    if (dgvQLNV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nam")
                    {
                        rbNam.Checked = true;
                    }
                    else if (dgvQLNV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "Nữ")
                        rbNu.Checked = true;
                    else
                        rbKhac.Checked = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void loadDGV()
        {
            List<NHANVIEN> newNhanVien = db.NHANVIENs.ToList();
            FillDataDGV(newNhanVien);

        }
        private void loadForm()
        {

            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChiNV.Clear();
            txtSDTNV.Clear();
            txtTimKiemNV.Clear();
            rbNam.Checked = true;
            cbbBoPhanLamViec.Text = "Mời chọn bộ phận";
        }
        private bool checkMaNV(string MA)
        {
            for (int i = 0; i < dgvQLNV.Rows.Count; i++)
            {
                if (dgvQLNV.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLNV.Rows[i].Cells[0].Value.ToString() == MA)
                        return true;
                }
            }
            return false;
        }
        private bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private bool checkInPut()
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSDTNV.Text == "" || txtDiaChiNV.Text == "" || cbbBoPhanLamViec.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(txtSDTNV.Text) != true)
            {
                MessageBox.Show("Số điện thoại phải là số!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;

        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (checkInPut() == true)
            {
                if (checkMaNV(txtMaNV.Text) == false)
                {
                    NHANVIEN x = new NHANVIEN();
                    x.MaNV = txtMaNV.Text;
                    x.TenNV = txtTenNV.Text;
                    x.SDT = txtSDTNV.Text;
                    x.BoPhanLamViec = cbbBoPhanLamViec.Text;
                    x.DiaChi = txtDiaChiNV.Text;
                    if (rbNam.Checked == true)
                        x.GioiTinh = "Nam";
                    else if (rbNu.Checked == true)
                        x.GioiTinh = "Nữ";
                    else
                        x.GioiTinh = "Khác";
                    x.TrangThai = true;

                    db.NHANVIENs.AddOrUpdate(x);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();
                    MessageBox.Show("Thêm đối tượng Thành công ", "Thông báo");
                }
                else

                    MessageBox.Show("Đã có đối tượng nào trong danh sách ", "Thông báo");

            }
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {

            NHANVIEN x = db.NHANVIENs.Where(p => p.MaNV == txtMaNV.Text).FirstOrDefault();
            if (x != null)
            {
                x.MaNV = txtMaNV.Text;
                x.TenNV = txtTenNV.Text;
                x.SDT = txtSDTNV.Text;
                x.BoPhanLamViec = cbbBoPhanLamViec.Text;
                x.DiaChi = txtDiaChiNV.Text;
                if (rbNam.Checked == true)
                    x.GioiTinh = "Nam";
                else if (rbNu.Checked == true)
                    x.GioiTinh = "Nữ";
                else
                    x.GioiTinh = "Khác";
                x.TrangThai = true;

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

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            NHANVIEN x = db.NHANVIENs.Where(p => p.MaNV == txtMaNV.Text).FirstOrDefault();
            if (x != null)
            {
                x.MaNV = txtMaNV.Text;
                x.TenNV = txtTenNV.Text;
                x.SDT = txtSDTNV.Text;
                x.BoPhanLamViec = cbbBoPhanLamViec.Text;
                x.DiaChi = txtDiaChiNV.Text;
                if (rbNam.Checked == true)
                    x.GioiTinh = "Nam";
                else if (rbNu.Checked == true)
                    x.GioiTinh = "Nữ";
                else
                    x.GioiTinh = "Khác";
                x.TrangThai = true;
                db.NHANVIENs.Remove(x);
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

        private void btnResetNV_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnTroVeNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            var result = from c in db.NHANVIENs
                         where c.TenNV.Contains(txtTimKiemNV.Text)
                         select c;

            FillDataDGV(result.ToList());
        }
    }
}
