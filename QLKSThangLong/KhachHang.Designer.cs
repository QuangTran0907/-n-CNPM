
namespace QLKSThangLong
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.dgvQLKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKH = new System.Windows.Forms.TextBox();
            this.btnTroVeKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatKH = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKH.Location = new System.Drawing.Point(350, 72);
            this.dgvQLKH.Name = "dgvQLKH";
            this.dgvQLKH.RowHeadersWidth = 51;
            this.dgvQLKH.RowTemplate.Height = 24;
            this.dgvQLKH.Size = new System.Drawing.Size(582, 395);
            this.dgvQLKH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(134, 77);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(181, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CMND/ CCCD";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(134, 119);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(181, 22);
            this.txtCMND.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(134, 163);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(181, 22);
            this.txtSDTKH.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSDTKH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Location = new System.Drawing.Point(14, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin KH";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(134, 31);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(80, 22);
            this.txtMaKH.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mã khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimKH);
            this.groupBox2.Location = new System.Drawing.Point(14, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 53);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm KH";
            // 
            // txtTimKH
            // 
            this.txtTimKH.Location = new System.Drawing.Point(6, 21);
            this.txtTimKH.Name = "txtTimKH";
            this.txtTimKH.Size = new System.Drawing.Size(309, 22);
            this.txtTimKH.TabIndex = 8;
            // 
            // btnTroVeKH
            // 
            this.btnTroVeKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnTroVeKH.Location = new System.Drawing.Point(838, 473);
            this.btnTroVeKH.Name = "btnTroVeKH";
            this.btnTroVeKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTroVeKH.Size = new System.Drawing.Size(94, 29);
            this.btnTroVeKH.TabIndex = 19;
            this.btnTroVeKH.Text = "Trở về";
            // 
            // btnThemKH
            // 
            this.btnThemKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(42, 359);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemKH.Size = new System.Drawing.Size(94, 47);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "Thêm";
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnXoaKH.Location = new System.Drawing.Point(42, 425);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoaKH.Size = new System.Drawing.Size(94, 47);
            this.btnXoaKH.TabIndex = 17;
            this.btnXoaKH.Text = "Xóa";
            // 
            // btnResetKH
            // 
            this.btnResetKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnResetKH.Location = new System.Drawing.Point(157, 429);
            this.btnResetKH.Name = "btnResetKH";
            this.btnResetKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnResetKH.Size = new System.Drawing.Size(94, 38);
            this.btnResetKH.TabIndex = 16;
            this.btnResetKH.Text = "Reset";
            this.btnResetKH.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCapNhatKH.Location = new System.Drawing.Point(157, 358);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCapNhatKH.Size = new System.Drawing.Size(116, 48);
            this.btnCapNhatKH.TabIndex = 15;
            this.btnCapNhatKH.Text = " Cập nhật";
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 515);
            this.Controls.Add(this.btnTroVeKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.btnResetKH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLKH);
            this.Controls.Add(this.btnCapNhatKH);
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKH;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatKH;
        private DevExpress.XtraEditors.SimpleButton btnResetKH;
        private DevExpress.XtraEditors.SimpleButton btnXoaKH;
        private DevExpress.XtraEditors.SimpleButton btnThemKH;
        private DevExpress.XtraEditors.SimpleButton btnTroVeKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
    }
}