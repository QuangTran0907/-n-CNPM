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
    public partial class LoaiDichVu : Form
    {
        DbContextQLKS db = new DbContextQLKS();
        public LoaiDichVu()
        {
            InitializeComponent();
        }

        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            List<DICHVU> listDV = db.DICHVUs.ToList();
            FillDataDGV(listDV);
            loadForm();
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
        private bool checkMa(string check)
        {

            for (int i = 0; i < dgvQLDV.Rows.Count; i++)
            {
                if (dgvQLDV.Rows[i].Cells[0].Value != null)
                {
                    if (dgvQLDV.Rows[i].Cells[0].Value.ToString() == check)
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
        private bool CheckDataInput()
        {
            if (txtMaDV.Text == "" || txtTenDV.Text == "" || txtGiaDV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;

            }
            else if (IsNumber(txtGiaDV.Text) != true)
            {
                MessageBox.Show("Dữ liệu không phải là số!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void loadForm()
        {

            txtMaDV.Clear();
            txtTenDV.Clear();
            txtGiaDV.Clear();

        }
        private void loadDGV()
        {
            List<DICHVU> listDV = db.DICHVUs.ToList();
            FillDataDGV(listDV);
        }
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                if (checkMa(txtMaDV.Text) == false)
                {
                    DICHVU x = new DICHVU();
                    x.MaDV = txtMaDV.Text;
                    x.TenDV = txtTenDV.Text;
                    x.GiaDV = Convert.ToDecimal(txtGiaDV.Text);
                    db.DICHVUs.AddOrUpdate(x);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();

                    MessageBox.Show("Thêm khách hàng thành công ", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Khách hàng đã tồn tại ", "Thông báo");
                }
            }
        }

        private void btnCapNhatDV_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                DICHVU x = db.DICHVUs.Where(p => p.MaDV == txtMaDV.Text).FirstOrDefault();
                if (x != null)
                {
                    x.MaDV = txtMaDV.Text;
                    x.TenDV = txtTenDV.Text;
                    x.GiaDV = Convert.ToDecimal(txtGiaDV.Text);
                    db.DICHVUs.AddOrUpdate(x);
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

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                DICHVU x = db.DICHVUs.Where(p => p.MaDV == txtMaDV.Text).FirstOrDefault();
                if (x != null)
                {
                    x.MaDV = txtMaDV.Text;
                    x.TenDV = txtTenDV.Text;
                    x.GiaDV = Convert.ToDecimal(txtGiaDV.Text);
                    db.DICHVUs.Remove(x);
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

        private void btnResetDV_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnTroVeDV_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
    }
}
