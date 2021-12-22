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
    public partial class DangKyDV : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public DangKyDV()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DangKyDV_Load(object sender, EventArgs e)
        {
            List<PHIEUDANGKIDV> listDKDV = db.PHIEUDANGKIDV.ToList();
            List<DICHVU> listDV = db.DICHVU.ToList();
            FillDataDGV(listDKDV);
        }
        private void FillDataDGV(List<PHIEUDANGKIDV> listDKDV)
        {
            dgvDKDV.Rows.Clear();
            
            foreach (var item in listDKDV)
            {
                int newRow = dgvDKDV.Rows.Add();
                dgvDKDV.Rows[newRow].Cells[0].Value = item.MaPhieuDV;
                dgvDKDV.Rows[newRow].Cells[1].Value = item.SoPhong;
                dgvDKDV.Rows[newRow].Cells[2].Value = item.DICHVU.TenDV;
                dgvDKDV.Rows[newRow].Cells[3].Value = item.SoLuong;
                dgvDKDV.Rows[newRow].Cells[4].Value = item.NgaySuDung;
                dgvDKDV.Rows[newRow].Cells[5].Value = item.Tongtien;

            }
        }

        private void dgvDKDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDKDV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDKDV.CurrentCell.Selected = true;

                    txtMaPDV.Text = dgvDKDV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtSoLuongDV.Text = dgvDKDV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    cbbTenDV.Text = dgvDKDV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtSoPhongDV.Text = dgvDKDV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
