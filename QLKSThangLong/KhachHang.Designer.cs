
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            this.dgvQLKH = new System.Windows.Forms.DataGridView();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnLapPhieuThue = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetKH = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatKH = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQLKH
            // 
            this.dgvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKH,
            this.dgvTenKH,
            this.dgvCMND,
            this.dgvSDT});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLKH.Location = new System.Drawing.Point(350, 72);
            this.dgvQLKH.Name = "dgvQLKH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLKH.RowHeadersVisible = false;
            this.dgvQLKH.RowHeadersWidth = 51;
            this.dgvQLKH.RowTemplate.Height = 24;
            this.dgvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLKH.Size = new System.Drawing.Size(582, 395);
            this.dgvQLKH.TabIndex = 0;
            this.dgvQLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKH_CellClick);
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.HeaderText = "Mã khách hàng";
            this.dgvMaKH.MinimumWidth = 6;
            this.dgvMaKH.Name = "dgvMaKH";
            // 
            // dgvTenKH
            // 
            this.dgvTenKH.HeaderText = "Tên khách hàng";
            this.dgvTenKH.MinimumWidth = 6;
            this.dgvTenKH.Name = "dgvTenKH";
            // 
            // dgvCMND
            // 
            this.dgvCMND.HeaderText = "Số CMND/CCCD";
            this.dgvCMND.MinimumWidth = 6;
            this.dgvCMND.Name = "dgvCMND";
            // 
            // dgvSDT
            // 
            this.dgvSDT.HeaderText = "Số điện thoại";
            this.dgvSDT.MinimumWidth = 6;
            this.dgvSDT.Name = "dgvSDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(266, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 38);
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
            this.txtTimKH.TextChanged += new System.EventHandler(this.txtTimKH_TextChanged);
            // 
            // btnTroVeKH
            // 
            this.btnTroVeKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVeKH.ImageOptions.Image")));
            this.btnTroVeKH.Location = new System.Drawing.Point(1048, 591);
            this.btnTroVeKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTroVeKH.Name = "btnTroVeKH";
            this.btnTroVeKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTroVeKH.Size = new System.Drawing.Size(118, 36);
            this.btnTroVeKH.TabIndex = 19;
            this.btnTroVeKH.Text = "Trở về";
            this.btnTroVeKH.Click += new System.EventHandler(this.btnTroVeKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKH.ImageOptions.Image")));
            this.btnThemKH.Location = new System.Drawing.Point(14, 431);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemKH.Size = new System.Drawing.Size(118, 59);
            this.btnThemKH.TabIndex = 18;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnLapPhieuThue
            // 
            this.btnLapPhieuThue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieuThue.ImageOptions.Image")));
            this.btnLapPhieuThue.Location = new System.Drawing.Point(14, 513);
            this.btnLapPhieuThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLapPhieuThue.Name = "btnLapPhieuThue";
            this.btnLapPhieuThue.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnLapPhieuThue.Size = new System.Drawing.Size(182, 59);
            this.btnLapPhieuThue.TabIndex = 17;
            this.btnLapPhieuThue.Text = "Lập phiếu thuê";
            this.btnLapPhieuThue.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnResetKH
            // 
            this.btnResetKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetKH.ImageOptions.Image")));
            this.btnResetKH.Location = new System.Drawing.Point(204, 518);
            this.btnResetKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetKH.Name = "btnResetKH";
            this.btnResetKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnResetKH.Size = new System.Drawing.Size(118, 48);
            this.btnResetKH.TabIndex = 16;
            this.btnResetKH.Text = "Reset";
            this.btnResetKH.Click += new System.EventHandler(this.btnResetKH_Click);
            // 
            // btnCapNhatKH
            // 
            this.btnCapNhatKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatKH.ImageOptions.Image")));
            this.btnCapNhatKH.Location = new System.Drawing.Point(204, 430);
            this.btnCapNhatKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhatKH.Name = "btnCapNhatKH";
            this.btnCapNhatKH.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCapNhatKH.Size = new System.Drawing.Size(145, 60);
            this.btnCapNhatKH.TabIndex = 15;
            this.btnCapNhatKH.Text = " Cập nhật";
            this.btnCapNhatKH.Click += new System.EventHandler(this.btnCapNhatKH_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 636);
            this.Controls.Add(this.btnTroVeKH);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnLapPhieuThue);
            this.Controls.Add(this.btnResetKH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLKH);
            this.Controls.Add(this.btnCapNhatKH);
            this.Name = "KhachHang";
            this.Text = "Quản lý khách hàng";
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
        private DevExpress.XtraEditors.SimpleButton btnLapPhieuThue;
        private DevExpress.XtraEditors.SimpleButton btnThemKH;
        private DevExpress.XtraEditors.SimpleButton btnTroVeKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
    }
}