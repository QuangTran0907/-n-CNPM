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
    public partial class SuDungVatTu : Form
    {
        public SuDungVatTu()
        {
            InitializeComponent();
        }
        DbContextQLKS db = new DbContextQLKS();
        public string connect { get; set; }
        private void SuDungVatTu_Load(object sender, EventArgs e)
        {
            List<SUDUNGVT> SDvatTu = db.SUDUNGVTs.ToList();
            List<VATTU> vATTUs = db.VATTUs.ToList();
            FillDataDGV(SDvatTu);
            loadForm();
            getMa();
        }
        private void getMa()
        {
            if (connect != null)
            {
                CbbPhong.Text = connect;
                CbbPhong.Enabled = false;
            }    
                 
        }

        private void FillDataDGV(List<SUDUNGVT> vATTUs)
        {
            dgvVatTu.Rows.Clear();
            foreach (var item in vATTUs)
            {
                int newRow = dgvVatTu.Rows.Add();
                dgvVatTu.Rows[newRow].Cells[0].Value = item.MaVT;
                dgvVatTu.Rows[newRow].Cells[1].Value = item.VATTU.TenVT;
                dgvVatTu.Rows[newRow].Cells[2].Value = item.VATTU.LoaiVT;
                dgvVatTu.Rows[newRow].Cells[3].Value = item.VATTU.SoLuong;
                dgvVatTu.Rows[newRow].Cells[4].Value = item.NgaySuDung;

            }
        }

        private void loadForm()
        {
            
        }
    }
}
