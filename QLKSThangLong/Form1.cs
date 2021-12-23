using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            galleryControl2.Gallery.ItemClick += new GalleryItemClickEventHandler(Gallery_ItemClick);

        }   
        DbContextQLKS dbcontext = new DbContextQLKS();
        List<PHONG> PH = new List<PHONG>();
        Image im1 = Image.FromFile("D:\\01.png");
        Image im2 = Image.FromFile("D:\\02.jpg");
        public List<TAIKHOAN> listCon { get; set; }
        private void Form1_Load(object sender, EventArgs e)
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
        
        private void Gallery_ItemClick(object sender, GalleryItemEventArgs e)
        {  
                var gc_item = new GalleryItem();
            string id = e.Item.Value.ToString();
            PHONG x = dbcontext.PHONGs.Where(p => p.SoPhong == id).FirstOrDefault();
            if (x.TrangThai == true)
                x.TrangThai = false;
            else
                x.TrangThai = true;

            dbcontext.PHONGs.AddOrUpdate(x);
            dbcontext.SaveChanges();
            if (x.TrangThai == true)
                gc_item.ImageOptions.Image = im1;
            else
                gc_item.ImageOptions.Image = im2;

            gc_item.Caption = e.Item.Caption;
            gc_item.Value = e.Item.Value;
            e.Item.Assign(gc_item);
            ppMenu1.ShowPopup(Control.MousePosition);
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
      
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        GalleryItem item = null;
        private void ppMenu1_Popup(object sender, EventArgs e)
        {
            Point point = galleryControl2.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = galleryControl2.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                item = hitInfo.GalleryItem;
        }

        private void ppMenu1_CloseUp(object sender, EventArgs e)
        {
            item = null;
        }
    }
}
