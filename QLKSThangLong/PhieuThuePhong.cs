using QLKSThangLong.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKSThangLong
{

    public partial class PhieuThuePhong : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public PhieuThuePhong()
        {
            InitializeComponent();
        }




        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {

            List<KHACHHANG> listKH = db.KHACHHANGs.ToList();
            FillDataDGV(listKH);
        }

        private void FillDataDGV(List<KHACHHANG> listKH)
        {
            dgvKhachhang.Rows.Clear();
            foreach (var item in listKH)
            {
                int newRow = dgvKhachhang.Rows.Add();
                dgvKhachhang.Rows[newRow].Cells[0].Value = item.MaKH;
                dgvKhachhang.Rows[newRow].Cells[1].Value = item.TenKH;
                dgvKhachhang.Rows[newRow].Cells[2].Value = item.CMND_CCCD;
                dgvKhachhang.Rows[newRow].Cells[3].Value = item.SDT;

            }
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvKhachhang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvKhachhang.CurrentCell.Selected = true;

                    txtMaKH.Text = dgvKhachhang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                   
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
            
        }
        private void loadDGV()
        {
            List<KHACHHANG> listKH = db.KHACHHANGs.ToList();
            FillDataDGV(listKH);
        }
        
    }
}
