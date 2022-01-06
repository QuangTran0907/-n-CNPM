using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using QLKSThangLong.Model;


namespace QLKSThangLong
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            galleryControl2.Gallery.ItemRightClick += new GalleryItemClickEventHandler(Gallery_ItemRightClick);
            galleryControl2.Gallery.ItemDoubleClick += new GalleryItemClickEventHandler(Gallery_ItemDoubleClick);



        }



        DbContextQLKS dbcontext = new DbContextQLKS();
        string ma = "";
        List<PHONG> PH = new List<PHONG>();
        Image im1 = Image.FromFile("D:\\01.png");
        Image im2 = Image.FromFile("D:\\02.jpg");
        GalleryItemEventArgs s;
        public GalleryItem gc_item = new GalleryItem();

        public List<TAIKHOAN> listCon { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckQuyen();
            load_Gallery();

        }
        private void load_Gallery()
        {
            List<PHONG> pHONGs = dbcontext.PHONGs.ToList();

            galleryControl2.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            galleryControl2.Gallery.ImageSize = new Size(80, 80);
            galleryControl2.Gallery.ShowItemText = true;
            galleryControl2.Gallery.ShowGroupCaption = true;

            var ds = from c in pHONGs
                     orderby c.SoPhong
                     select c;
            PH = ds.ToList();

            DataTable x = new DataTable();
            x = ListToDataTable(PH);

            GalleryItemGroup group = new GalleryItemGroup();
            galleryControl2.Gallery.Groups.Add(group);
            group.Items.Clear();
            group.Caption = "Tất cả các phòng";
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Center;

            foreach (DataRow item in x.Rows)
            {
                var gc_item = new GalleryItem();
                gc_item.AppearanceCaption.Normal.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gc_item.AppearanceCaption.Hovered.Font = new Font("Tahoma", 12, FontStyle.Bold);
                gc_item.AppearanceCaption.Pressed.Font = new Font("Tahoma", 12, FontStyle.Bold);
                if (Convert.ToBoolean(Convert.ToInt16(item["TrangThai"])))
                    gc_item.ImageOptions.Image = im1;
                else
                    gc_item.ImageOptions.Image = im2;

                gc_item.Caption = item["SoPhong"].ToString();
                gc_item.Value = item["SoPhong"].ToString();
                group.Items.Add(gc_item);

            }
            galleryControl2.Gallery.Groups.Add(group);


        }

        private void CheckQuyen()
        {
            foreach (var item in listCon)
            {
                if (item.Quyen == 1)
                {
                    rbdanhmuc.Visible = true;
                    rbhethong.Visible = true;
                    rbtacvu.Visible = true;
                    rbxuatbc.Visible = true;
                    txtquyen.Text = "Admin";

                }
                else if (item.Quyen == 2)
                {
                    rbdanhmuc.Visible = true;
                    rbxuatbc.Visible = true;
                    rbhethong.Visible = true;
                    txtquyen.Text = "Quản lý";

                }
                else if (item.Quyen == 3)
                {
                    galleryControl2.Visible = true;
                    rbtacvu.Visible = true;
                    txtquyen.Text = "Lễ tân";
                }
                else
                {
                    rbdanhmuc.Visible = true;
                    barloaidv.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    barphong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    txtquyen.Text = "Thủ kho";
                }
            }
        }
        private void Gallery_ItemDoubleClick(object sender, GalleryItemClickEventArgs e)
        {
            string id = e.Item.Value.ToString();
            PHONG x = dbcontext.PHONGs.Where(p => p.SoPhong == id).FirstOrDefault();
            if (x.TrangThai == true)
            {
                x.TrangThai = false;
                gc_item.ImageOptions.Image = im2;
                gc_item.Caption = e.Item.Caption;
                gc_item.Value = e.Item.Value;
                e.Item.Assign(gc_item);
                dbcontext.PHONGs.AddOrUpdate(x);
                dbcontext.SaveChanges();

            }
            else
            {
                x.TrangThai = true;
                gc_item.ImageOptions.Image = im1;
                gc_item.Caption = e.Item.Caption;
                gc_item.Value = e.Item.Value;
                e.Item.Assign(gc_item);
                dbcontext.PHONGs.AddOrUpdate(x);
                dbcontext.SaveChanges();

            }
        }

        private void Gallery_ItemRightClick(object sender, GalleryItemClickEventArgs e)
        {
            string id = e.Item.Value.ToString();
            ma = id;
            PHONG x = dbcontext.PHONGs.Where(p => p.SoPhong == id).FirstOrDefault();
            if (x.TrangThai == true)
            {
                barDichvu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barThanhtoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barThuephong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                barThuephong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barDichvu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barThanhtoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (x.TrangThai == true)
                gc_item.ImageOptions.Image = im1;
            else
                gc_item.ImageOptions.Image = im2;

            gc_item.Caption = e.Item.Caption;
            gc_item.Value = e.Item.Value;
            e.Item.Assign(gc_item);
            s = e;
            ppMenu1.ShowPopup(Control.MousePosition);
        }
        private void barThuephong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuThuePhong ThuePhong = new PhieuThuePhong();
            ThuePhong.connect = ma;
            ThuePhong.Show();
        }

        private void barThanhtoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

        }
        public static DataTable ListToDataTable(List<PHONG> phongg)
        {
            DataTable dataTable = new DataTable(typeof(PHONG).Name);
            PropertyInfo[] props = typeof(PHONG).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in props)
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (PHONG item in phongg)
            {
                var values = new object[props.Length];
                for (int i = 0; i < props.Length; i++)
                {
                    values[i] = props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
        private void barButtonItem29_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
            DangNhap dn = new DangNhap();
            dn.ShowDialog();

        }

        private void barloaidv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            LoaiDichVu x = new LoaiDichVu();
            x.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Phong open = new Phong();
            open.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhieuThuePhong open = new PhieuThuePhong();
            open.ShowDialog();

        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangKyDV open = new DangKyDV();
            open.Show();
        }

        private void barThongtinphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<PHONG> listPhong = dbcontext.PHONGs.ToList();

            foreach (var item in listPhong)
            {
                if (item.SoPhong == s.Item.Caption)
                    MessageBox.Show(" Số phòng: " + item.SoPhong + "\n Loại phòng: " + item.LoaiPhong + "\n Số người tối đa: " + item.SoNguoiToiDa + "\n Giá: " + string.Format("{0:#,##0.00}", item.GiaPhong) + "\n " + item.ThongTinPhong);
            }

        }

        private void barThemvattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SuDungVatTu con = new SuDungVatTu();
            con.connect = ma;
            con.ShowDialog();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DoiMatKhau open = new DoiMatKhau();
            open.lisPass = listCon;
            open.ShowDialog();
        }

        private void barDichvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DangKyDV open = new DangKyDV();
            open.connect = ma;
            open.ShowDialog();
        }
    }
}

