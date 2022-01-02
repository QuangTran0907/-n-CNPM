
namespace QLKSThangLong
{
    partial class PhieuThuePhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuThuePhong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvKhachhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaoKhachMoi = new System.Windows.Forms.Button();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbSoPhong = new System.Windows.Forms.ComboBox();
            this.btnTroVeKH = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayTraDuKien = new System.Windows.Forms.DateTimePicker();
            this.cbbMaNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtNgayThue = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(336, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 36);
            this.label8.TabIndex = 24;
            this.label8.Text = "PHIẾU THUÊ PHÒNG";
            // 
            // dgvKhachhang
            // 
            this.dgvKhachhang.AllowUserToAddRows = false;
            this.dgvKhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvKhachhang.Location = new System.Drawing.Point(35, 229);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.ReadOnly = true;
            this.dgvKhachhang.RowHeadersVisible = false;
            this.dgvKhachhang.RowHeadersWidth = 51;
            this.dgvKhachhang.RowTemplate.Height = 24;
            this.dgvKhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachhang.Size = new System.Drawing.Size(511, 209);
            this.dgvKhachhang.TabIndex = 26;
            this.dgvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "CMND/CCCD";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SDT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnTaoKhachMoi
            // 
            this.btnTaoKhachMoi.Location = new System.Drawing.Point(351, 106);
            this.btnTaoKhachMoi.Name = "btnTaoKhachMoi";
            this.btnTaoKhachMoi.Size = new System.Drawing.Size(167, 31);
            this.btnTaoKhachMoi.TabIndex = 27;
            this.btnTaoKhachMoi.Text = "Tạo khách hàng mới";
            this.btnTaoKhachMoi.UseVisualStyleBackColor = true;
            this.btnTaoKhachMoi.Click += new System.EventHandler(this.btnTaoKhachMoi_Click);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(155, 101);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(120, 22);
            this.txtMaPhieu.TabIndex = 28;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(154, 169);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(121, 22);
            this.txtMaKH.TabIndex = 28;
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(351, 151);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(167, 31);
            this.btnXuat.TabIndex = 27;
            this.btnXuat.Text = "Lưu và xuất phiếu";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(563, 229);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(239, 22);
            this.txtTimKiem.TabIndex = 29;
            // 
            // cbbSoPhong
            // 
            this.cbbSoPhong.FormattingEnabled = true;
            this.cbbSoPhong.Location = new System.Drawing.Point(154, 138);
            this.cbbSoPhong.Name = "cbbSoPhong";
            this.cbbSoPhong.Size = new System.Drawing.Size(121, 24);
            this.cbbSoPhong.TabIndex = 30;
            // 
            // btnTroVeKH
            // 
            this.btnTroVeKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVeKH.ImageOptions.Image")));
            this.btnTroVeKH.Location = new System.Drawing.Point(916, 567);
            this.btnTroVeKH.Name = "btnTroVeKH";
            this.btnTroVeKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTroVeKH.Size = new System.Drawing.Size(94, 29);
            this.btnTroVeKH.TabIndex = 31;
            this.btnTroVeKH.Text = "Trở về";
            this.btnTroVeKH.Click += new System.EventHandler(this.btnTroVeKH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày trả dự kiến";
            // 
            // dtpNgayTraDuKien
            // 
            this.dtpNgayTraDuKien.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTraDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraDuKien.Location = new System.Drawing.Point(155, 515);
            this.dtpNgayTraDuKien.Name = "dtpNgayTraDuKien";
            this.dtpNgayTraDuKien.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayTraDuKien.TabIndex = 25;
            // 
            // cbbMaNV
            // 
            this.cbbMaNV.FormattingEnabled = true;
            this.cbbMaNV.Location = new System.Drawing.Point(154, 71);
            this.cbbMaNV.Name = "cbbMaNV";
            this.cbbMaNV.Size = new System.Drawing.Size(121, 24);
            this.cbbMaNV.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã phiếu thuê";
            // 
            // dtNgayThue
            // 
            this.dtNgayThue.CustomFormat = "dd/MM/yyyy";
            this.dtNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayThue.Location = new System.Drawing.Point(154, 543);
            this.dtNgayThue.Name = "dtNgayThue";
            this.dtNgayThue.Size = new System.Drawing.Size(200, 22);
            this.dtNgayThue.TabIndex = 25;
            // 
            // PhieuThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 608);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbMaNV);
            this.Controls.Add(this.btnTroVeKH);
            this.Controls.Add(this.cbbSoPhong);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaPhieu);
            this.Controls.Add(this.btnTaoKhachMoi);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.dtNgayThue);
            this.Controls.Add(this.dtpNgayTraDuKien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuThuePhong";
            this.Text = "PhieuThuePhong";
            this.Load += new System.EventHandler(this.PhieuThuePhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvKhachhang;
        private System.Windows.Forms.Button btnTaoKhachMoi;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbSoPhong;
        private DevExpress.XtraEditors.SimpleButton btnTroVeKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayTraDuKien;
        private System.Windows.Forms.ComboBox cbbMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtNgayThue;
    }
}