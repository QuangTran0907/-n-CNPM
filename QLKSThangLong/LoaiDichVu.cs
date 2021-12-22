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
    public partial class LoaiDichVu : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public LoaiDichVu()
        {
            InitializeComponent();
        }

        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            List<DICHVU> listDV = db.DICHVU.ToList();
            FillDataDGV(listDV);
        }

        private void FillDataDGV(List<DICHVU> listDV)
        {
            dgvQLDV.Rows.Clear();
            foreach (var item in listDV)
            {
                int newRow = dgvQLDV.Rows.Add();
                dgvQLDV.Rows[newRow].Cells[0].Value = item.MaDV;
                dgvQLDV.Rows[newRow].Cells[1].Value = item.TenDV;
                dgvQLDV.Rows[newRow].Cells[2].Value = item.GiaDV;
            }
        }

        private void dgvQLDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvQLDV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvQLDV.CurrentCell.Selected = true;

                    txtMaDV.Text = dgvQLDV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenDV.Text = dgvQLDV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtGiaDV.Text = dgvQLDV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
