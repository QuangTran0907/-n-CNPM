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
    public partial class KhachHang : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

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
    }
}
