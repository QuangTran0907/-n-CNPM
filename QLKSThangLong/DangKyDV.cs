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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DangKyDV_Load(object sender, EventArgs e)
        {
            List<PHIEUDANGKIDV> listDKDV = db.PHIEUDANGKIDVs.ToList();
            List<DICHVU> listDV = db.DICHVUs.ToList();
            FillDataDGV(listDKDV);
            FillDataCBO(listDV);
            loadForm();
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

        private bool CheckDataInput()
        {
            if (txtSoLuongDV.Text == "" || txtSoPhongDV.Text == "")
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
                    makh = $"KH0{i}";

                else
                    makh = $"KH{i}";
            }
            return makh;
        }
        private void btnThemDKDV_Click(object sender, EventArgs e)
        {

            if (CheckDataInput() == true)
            {
                if (checkMaDV(txtMaPDV.Text) == false)
                {
                    PHIEUDANGKIDV x = new PHIEUDANGKIDV();
                    x.MaPhieuDV = Auto_ID();
                    x.SoLuong = Convert.ToByte(txtSoLuongDV.Text);
                    x.SoPhong = txtSoPhongDV.Text;
                    x.DICHVU.TenDV = cbbTenDV.Text;
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
            txtSoPhongDV.Clear();
           
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
                x.SoPhong = txtSoPhongDV.Text;
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
            this.Close();
        }
    }
}
