
namespace QLKSThangLong
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbBoPhanLamViec = new System.Windows.Forms.ComboBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbKhac = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNV = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetNV = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.btnTroVeNV = new DevExpress.XtraEditors.SimpleButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Location = new System.Drawing.Point(332, 61);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowHeadersWidth = 51;
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.Size = new System.Drawing.Size(600, 501);
            this.dgvQLNV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbBoPhanLamViec);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbKhac);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDiaChiNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSDTNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin NV";
            // 
            // cbbBoPhanLamViec
            // 
            this.cbbBoPhanLamViec.FormattingEnabled = true;
            this.cbbBoPhanLamViec.Location = new System.Drawing.Point(70, 186);
            this.cbbBoPhanLamViec.Name = "cbbBoPhanLamViec";
            this.cbbBoPhanLamViec.Size = new System.Drawing.Size(178, 24);
            this.cbbBoPhanLamViec.TabIndex = 13;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(157, 116);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 12;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbKhac
            // 
            this.rbKhac.AutoSize = true;
            this.rbKhac.Location = new System.Drawing.Point(228, 116);
            this.rbKhac.Name = "rbKhac";
            this.rbKhac.Size = new System.Drawing.Size(61, 21);
            this.rbKhac.TabIndex = 11;
            this.rbKhac.TabStop = true;
            this.rbKhac.Text = "Khác";
            this.rbKhac.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(93, 114);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 10;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bộ phận làm việc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính";
            // 
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(70, 265);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(219, 22);
            this.txtDiaChiNV.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(70, 225);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(178, 22);
            this.txtSDTNV.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sđt";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(70, 74);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(219, 22);
            this.txtTenNV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(70, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(70, 22);
            this.txtMaNV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV";
            // 
            // btnThemNV
            // 
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(44, 456);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemNV.Size = new System.Drawing.Size(94, 47);
            this.btnThemNV.TabIndex = 19;
            this.btnThemNV.Text = "Thêm";
            // 
            // btnCapNhatNV
            // 
            this.btnCapNhatNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCapNhatNV.Location = new System.Drawing.Point(174, 456);
            this.btnCapNhatNV.Name = "btnCapNhatNV";
            this.btnCapNhatNV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCapNhatNV.Size = new System.Drawing.Size(116, 48);
            this.btnCapNhatNV.TabIndex = 20;
            this.btnCapNhatNV.Text = " Cập nhật";
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnXoaNV.Location = new System.Drawing.Point(44, 514);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoaNV.Size = new System.Drawing.Size(94, 47);
            this.btnXoaNV.TabIndex = 22;
            this.btnXoaNV.Text = "Xóa";
            // 
            // btnResetNV
            // 
            this.btnResetNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnResetNV.Location = new System.Drawing.Point(174, 519);
            this.btnResetNV.Name = "btnResetNV";
            this.btnResetNV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnResetNV.Size = new System.Drawing.Size(94, 38);
            this.btnResetNV.TabIndex = 21;
            this.btnResetNV.Text = "Reset";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKiemNV);
            this.groupBox2.Location = new System.Drawing.Point(22, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 59);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm NV";
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(22, 21);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(267, 22);
            this.txtTimKiemNV.TabIndex = 8;
            // 
            // btnTroVeNV
            // 
            this.btnTroVeNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnTroVeNV.Location = new System.Drawing.Point(838, 568);
            this.btnTroVeNV.Name = "btnTroVeNV";
            this.btnTroVeNV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTroVeNV.Size = new System.Drawing.Size(94, 29);
            this.btnTroVeNV.TabIndex = 24;
            this.btnTroVeNV.Text = "Trở về";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(286, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 39);
            this.label7.TabIndex = 25;
            this.label7.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 609);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTroVeNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnResetNV);
            this.Controls.Add(this.btnCapNhatNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvQLNV);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbBoPhanLamViec;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbKhac;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatNV;
        private DevExpress.XtraEditors.SimpleButton btnXoaNV;
        private DevExpress.XtraEditors.SimpleButton btnResetNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private DevExpress.XtraEditors.SimpleButton btnTroVeNV;
        private System.Windows.Forms.Label label7;
    }
}