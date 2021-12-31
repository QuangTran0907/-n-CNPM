using DevExpress.XtraBars.Ribbon;
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
       
        

        public PhieuThuePhong()
        {
            InitializeComponent();
        }
        DbContextQLKS db = new DbContextQLKS();



        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {
           
            List<KHACHHANG> listKH = db.KHACHHANGs.ToList();
            List<PHONG> listPhong = db.PHONGs.ToList();
            FillCBBPhong(listPhong);
            FillDataDGV(listKH);
            getMaKH();
        }
        
        private void getMaKH()
        {
            int y = dgvKhachhang.Rows.Count-1;
            List <KHACHHANG> x = db.KHACHHANGs.ToList();
            txtMaKH.Text = dgvKhachhang.Rows[y].Cells[0].FormattedValue.ToString();
            txtMaKH.Enabled = false;
        }
        private void FillCBBPhong(List<PHONG> pHONGs)
        {
            List<PHONG> phongoff = new List<PHONG>();
            var result = from c in db.PHONGs
                         where c.TrangThai == false
                         select c;

            phongoff = result.ToList();
            cbbSoPhong.DataSource = phongoff;
                    cbbSoPhong.DisplayMember = "SoPhong";
                    cbbSoPhong.ValueMember = "SoPhong";
                    cbbSoPhong.Text = "Chọn phòng";
             
            
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

        private void btnTaoKhachMoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhachHang x = new KhachHang();
            x.Show();
        }
    }
}
