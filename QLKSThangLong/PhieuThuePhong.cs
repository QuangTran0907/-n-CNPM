using DevExpress.XtraBars.Ribbon;
using QLKSThangLong.Model;
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

namespace QLKSThangLong
{

    public partial class PhieuThuePhong : Form
    {
       
        

        public PhieuThuePhong()
        {
            InitializeComponent();
        }
        DbContextQLKS db = new DbContextQLKS();
        List<PHONG> phongoff = new List<PHONG>();
        public string connect { get; set; }



        private void PhieuThuePhong_Load(object sender, EventArgs e)
        {
            
            List<KHACHHANG> listKH = db.KHACHHANGs.ToList();
            FillCBBNV();
            FillDataDGV(listKH);
            getMaKH();
            getSoPhong();
            txtMaPhieu.Text = Auto_ID();


        }
        public void getSoPhong()
        {
            if(connect != null)
            {
                List<PHONG> getLoaiPhong = db.PHONGs.ToList();
                cbbSoPhong.Text = connect;
                cbbSoPhong.Enabled = false;
                foreach (var item in getLoaiPhong)
                {
                    if (item.SoPhong == connect)
                    {
                        cbbLoaiPhong.Text = item.LoaiPhong;
                        cbbLoaiPhong.Enabled = false;
                    }
                }

            }
          



        }
        private void FillCBBNV()
        {

            List<NHANVIEN> TiepTan = new List<NHANVIEN>();
            var result = from c in db.NHANVIENs
                         where c.BoPhanLamViec == "Lễ tân"
                         select c;

            TiepTan = result.ToList();
            cbbMaNV.DataSource = TiepTan;
            cbbMaNV.DisplayMember = "MaNV";
            cbbMaNV.ValueMember = "MaNV";
            cbbMaNV.Text = "Chọn nhân viên";
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
           
            cbbSoPhong.DataSource = pHONGs;
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
            
            KhachHang x = new KhachHang();
            x.ShowDialog();
            this.Hide();
        }
        private string Auto_ID()
        {
            List<PHIEUTHUEPHONG> listphieu = db.PHIEUTHUEPHONGs.ToList();
            string makh = "";
            for (int i = 0; i < listphieu.Count; i++)
            {
                if (listphieu.Count < 10)
                    makh = $"PTP0{i+1}";

                else
                    makh = $"PTP{i+1}";
            }
            return makh;
        }
       
        private void btnXuat_Click(object sender, EventArgs e)
        {
            
           
            CHITIETPHIEUTHUE chitiet = new CHITIETPHIEUTHUE();
            PHIEUTHUEPHONG phieuthue = new PHIEUTHUEPHONG();
            phieuthue.MaNV = cbbMaNV.Text;
            phieuthue.MaKH = txtMaKH.Text;
            phieuthue.MaPhieuThue = txtMaPhieu.Text;
            phieuthue.NgayThuePhong = DateTime.Today;
            chitiet.SoPhong = cbbSoPhong.Text;
            chitiet.NgayTraDuKien = dtpNgayTraDuKien.Value;
            chitiet.MaPhieuThue = txtMaPhieu.Text;
            db.PHIEUTHUEPHONGs.AddOrUpdate(phieuthue);
            db.CHITIETPHIEUTHUEs.AddOrUpdate(chitiet);
            db.SaveChanges();


        }

        private void btnTroVeKH_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 open = new Form1();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connect == null)
            {
                var result = from c in db.PHONGs
                             where c.TrangThai == false && c.LoaiPhong == cbbLoaiPhong.Text
                             select c;
                phongoff = result.ToList();
                if (phongoff.Count != 0)
                {
                    FillCBBPhong(phongoff);
                    cbbSoPhong.Enabled = true;
                }
                else
                {
                    FillCBBPhong(null);
                    cbbSoPhong.Text = "phòng loại này đã hết";
                    cbbSoPhong.Enabled = false;

                }
            }


        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var result = from c in db.KHACHHANGs
                         where c.TenKH.Contains(txtTimKiem.Text)
                         select c;

            FillDataDGV(result.ToList());
        }

        private void cbbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
