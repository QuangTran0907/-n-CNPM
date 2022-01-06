using QLKSThangLong.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSThangLong
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }

        DbContextQLKS db = new DbContextQLKS();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Phong_Load(object sender, EventArgs e)
        {
            List<PHONG> pHONGs = db.PHONGs.ToList();
            FillDataDGV(pHONGs);
            loadForm();
        }

        private void loadForm()
        {
            txtSoPhong.Clear();
            txtSoNguoiToiDa.Clear();
            txtGiaPhong.Clear();
            txtThongTinPhong.Clear();
            txtTienDichVu.Clear();
            txtTimKiemNV.Clear();
            cbbLoaiPhong.Text = "Mời chọn loại phòng";
        }

        private void FillDataDGV(List<PHONG> pHONGs)
        {

            dgvQLPHONG.Rows.Clear();
            foreach (var item in pHONGs)
            {
                int newRow = dgvQLPHONG.Rows.Add();
                dgvQLPHONG.Rows[newRow].Cells[0].Value = item.SoPhong;
                dgvQLPHONG.Rows[newRow].Cells[1].Value = item.LoaiPhong;
                dgvQLPHONG.Rows[newRow].Cells[2].Value = item.ThongTinPhong;
                dgvQLPHONG.Rows[newRow].Cells[3].Value = item.SoNguoiToiDa;
                dgvQLPHONG.Rows[newRow].Cells[4].Value = string.Format("{0:#,##0.00}", item.GiaPhong);
                dgvQLPHONG.Rows[newRow].Cells[5].Value = string.Format("{0:#,##0.00}", item.TienDV);
                dgvQLPHONG.Rows[newRow].Cells[6].Value = item.TrangThai;

            }
        }
        private void loadDGV()
        {
            List<PHONG> load = db.PHONGs.ToList();
            FillDataDGV(load);

        }
        private bool checkMaPhong(string MA)
        {
            for (int i = 0; i < dgvQLPHONG.Rows.Count; i++)
            {
                if (dgvQLPHONG.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLPHONG.Rows[i].Cells[0].Value.ToString() == MA)
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
            if (txtSoPhong.Text == "" || txtGiaPhong.Text == "" || txtTienDichVu.Text == "" || txtSoNguoiToiDa.Text == "" || txtThongTinPhong.Text == "" || cbbLoaiPhong.SelectedIndex.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNumber(txtSoNguoiToiDa.Text) != true)
            {
                MessageBox.Show("Dữ liệu phải là số!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (checkInPut() == true)
            {
                if (checkMaPhong(txtSoPhong.Text) == false)
                {
                    PHONG x = new PHONG();
                    x.SoPhong = txtSoPhong.Text;
                    x.ThongTinPhong = txtThongTinPhong.Text;
                    x.GiaPhong = Convert.ToDecimal(txtGiaPhong.Text);
                    x.LoaiPhong = cbbLoaiPhong.Text;
                    x.TienDV = Convert.ToDecimal(txtTienDichVu.Text);
                    x.SoNguoiToiDa = Convert.ToByte(txtSoNguoiToiDa.Text);
                    x.TrangThai = false;

                    db.PHONGs.AddOrUpdate(x);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();
                    MessageBox.Show("Thêm đối tượng Thành công ", "Thông báo");
                }
                else

                    MessageBox.Show("Đã có đối tượng nào trong danh sách ", "Thông báo");
            }
        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            {
                PHONG x = db.PHONGs.Where(p => p.SoPhong == txtSoPhong.Text).FirstOrDefault();
                if (x != null)
                {
                    x.SoPhong = txtSoPhong.Text;
                    x.ThongTinPhong = txtThongTinPhong.Text;
                    x.GiaPhong = Convert.ToDecimal(txtGiaPhong.Text);
                    x.LoaiPhong = cbbLoaiPhong.Text;
                    x.TienDV = Convert.ToDecimal(txtTienDichVu.Text);
                    x.SoNguoiToiDa = Convert.ToByte(txtSoNguoiToiDa.Text);
                    x.TrangThai = false;

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

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            PHONG x = db.PHONGs.Where(p => p.SoPhong == txtSoPhong.Text).FirstOrDefault();
            if (x != null)
            {
                x.SoPhong = txtSoPhong.Text;
                x.ThongTinPhong = txtThongTinPhong.Text;
                x.GiaPhong = Convert.ToDecimal(txtGiaPhong.Text);
                x.LoaiPhong = cbbLoaiPhong.Text;
                x.TienDV = Convert.ToDecimal(txtTienDichVu.Text);
                x.SoNguoiToiDa = Convert.ToByte(txtSoNguoiToiDa.Text);
                x.TrangThai = false;
                db.PHONGs.Remove(x);
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

        private void btnResetPhong_Click(object sender, EventArgs e)
        {
            loadForm();
            loadDGV();
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            var result = from c in db.PHONGs
                         where c.SoPhong.Contains(txtTimKiemNV.Text)
                         select c;

            FillDataDGV(result.ToList());
        }

        private void dgvQLPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLPHONG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLPHONG.CurrentCell.Selected = true;

                    txtSoPhong.Text = dgvQLPHONG.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    cbbLoaiPhong.Text = dgvQLPHONG.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtThongTinPhong.Text = dgvQLPHONG.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtSoNguoiToiDa.Text = dgvQLPHONG.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtGiaPhong.Text = dgvQLPHONG.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    txtTienDichVu.Text = dgvQLPHONG.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTroVeNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGiaPhong_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}