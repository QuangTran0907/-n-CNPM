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
    public partial class DangKyDV : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public DangKyDV()
        {
            InitializeComponent();
        }
        public string connect { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DangKyDV_Load(object sender, EventArgs e)
        {
            List<PHONG> listPhong = db.PHONGs.ToList();
            List<PHIEUDANGKIDV> listDKDV = db.PHIEUDANGKIDVs.ToList();
            List<DICHVU> listDV = db.DICHVUs.ToList();
            FillDataDGV(listDKDV);
            FillDataCBO(listDV);
            loadForm();
            cbbSoPhong.Text = connect;
            cbbSoPhong.Enabled = false;
            var result = from c in listPhong
                         where c.TrangThai == true
                         select c;

            FillCBBPhong(result.ToList());
        }
        private void FillCBBPhong(List<PHONG> pHONGs)
        {

            cbbSoPhong.DataSource = pHONGs;
            cbbSoPhong.DisplayMember = "SoPhong";
            cbbSoPhong.ValueMember = "SoPhong";
            cbbSoPhong.Text = "Chọn phòng";


        }

        private void FillDataCBO(List<DICHVU> listDV)
        {
            cbbTenDV.DataSource = listDV;
            cbbTenDV.DisplayMember = "TenDV";
            cbbTenDV.ValueMember = "MaDV";
            cbbTenDV.Text = "Chọn dịch vụ";
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
                dgvDKDV.Rows[newRow].Cells[4].Value = item.NgaySuDung.Value.ToString("dd/MM/yyyy");
                dgvDKDV.Rows[newRow].Cells[5].Value = string.Format("{0:#,##0.00}", item.Tongtien); 

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
                    cbbSoPhong.Text = dgvDKDV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CheckDataInput()
        {
            if (txtSoLuongDV.Text == "" || cbbSoPhong.Text == "")
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
            string makh = "";
            for (int i = 0; i < dgvDKDV.Rows.Count; i++)
            {
                if (dgvDKDV.Rows.Count < 10)
                    makh = $"PDV0{i+1}";

                else
                    makh = $"PDV{i+1}";
            }
            return makh;
        }
        private void btnThemDKDV_Click(object sender, EventArgs e)
        {
            List<DICHVU> listDV = db.DICHVUs.ToList();
            if (CheckDataInput() == true)
            {
                if (checkMaDV(txtMaPDV.Text) == false)
                {
                    PHIEUDANGKIDV x = new PHIEUDANGKIDV();
                   
                    x.MaPhieuDV = Auto_ID();
                    x.SoLuong = Convert.ToByte(txtSoLuongDV.Text);
                    x.SoPhong = cbbSoPhong.Text;
                    x.NgaySuDung = DateTime.Today;
                    foreach (var item in listDV)
                    {
                        if (cbbTenDV.Text == item.TenDV)
                        {
                            x.MaDV = item.MaDV;
                            x.Tongtien = item.GiaDV * x.SoLuong.Value;
                        }
                    }
                  
                    db.PHIEUDANGKIDVs.AddOrUpdate(x);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();

                    MessageBox.Show("Đăng ký dịch vụ thành công ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đăng ký dịch vụ đã tồn tại ", "Thông báo");
                }
            }
            cbbSoPhong.Enabled = true;
            
        }
        private bool checkMaDV(string check)
        {

            for (int i = 0; i < dgvDKDV.Rows.Count; i++)
            {
                if (dgvDKDV.Rows[i].Cells[0].Value != null)
                {
                    if (dgvDKDV.Rows[i].Cells[0].Value.ToString() == check)
                        return true;
                }
            }
            return false;
        }
        private void loadForm()
        {

            txtMaPDV.Clear();
            txtSoLuongDV.Clear();
           
        }
        private void loadDGV()
        {
            List<PHIEUDANGKIDV> listDKDV = db.PHIEUDANGKIDVs.ToList();
            List<DICHVU> listDV = db.DICHVUs.ToList();
            FillDataDGV(listDKDV);
            FillDataCBO(listDV);
        }

        private void btnXoaDKDV_Click(object sender, EventArgs e)
        {
            PHIEUDANGKIDV x = db.PHIEUDANGKIDVs.Where(p => p.MaPhieuDV == txtMaPDV.Text).FirstOrDefault();
            if (x != null)
            {
                x.MaPhieuDV = txtMaPDV.Text;
                x.SoLuong = Convert.ToByte(txtSoLuongDV.Text);
                x.SoPhong = cbbSoPhong.Text;
                x.DICHVU.TenDV = cbbTenDV.Text;
                db.PHIEUDANGKIDVs.Remove(x);
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

        private void btnResetDKDV_Click(object sender, EventArgs e)
        {
            loadForm();
            
        }

        private void btnTroVeDKDV_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
