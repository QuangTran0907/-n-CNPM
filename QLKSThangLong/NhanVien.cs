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
    public partial class NhanVien : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = db.NHANVIEN.ToList();
            FillDataDGV(listNV);
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
    }
}
