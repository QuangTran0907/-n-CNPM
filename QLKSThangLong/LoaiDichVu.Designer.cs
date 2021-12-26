
namespace QLKSThangLong
{
    partial class LoaiDichVu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiDichVu));
            this.dgvQLDV = new System.Windows.Forms.DataGridView();
            this.dgvMaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGiaDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtGiaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhatDV = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTroVeDV = new DevExpress.XtraEditors.SimpleButton();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.btnXoaDV = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLDV
            // 
            this.dgvQLDV.AllowUserToAddRows = false;
            this.dgvQLDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvQLDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaDV,
            this.dgvTenDV,
            this.dgvGiaDV});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLDV.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvQLDV.Location = new System.Drawing.Point(364, 67);
            this.dgvQLDV.Name = "dgvQLDV";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvQLDV.RowHeadersVisible = false;
            this.dgvQLDV.RowHeadersWidth = 51;
            this.dgvQLDV.RowTemplate.Height = 24;
            this.dgvQLDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLDV.Size = new System.Drawing.Size(410, 239);
            this.dgvQLDV.TabIndex = 0;
            this.dgvQLDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLDV_CellClick);
            // 
            // dgvMaDV
            // 
            this.dgvMaDV.HeaderText = "Mã dịch vụ";
            this.dgvMaDV.MinimumWidth = 6;
            this.dgvMaDV.Name = "dgvMaDV";
            // 
            // dgvTenDV
            // 
            this.dgvTenDV.HeaderText = "Tên dịch vụ";
            this.dgvTenDV.MinimumWidth = 6;
            this.dgvTenDV.Name = "dgvTenDV";
            // 
            // dgvGiaDV
            // 
            this.dgvGiaDV.HeaderText = "Giá";
            this.dgvGiaDV.MinimumWidth = 6;
            this.dgvGiaDV.Name = "dgvGiaDV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(151, 21);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(100, 22);
            this.txtMaDV.TabIndex = 2;
            // 
            // txtGiaDV
            // 
            this.txtGiaDV.Location = new System.Drawing.Point(151, 85);
            this.txtGiaDV.Name = "txtGiaDV";
            this.txtGiaDV.Size = new System.Drawing.Size(100, 22);
            this.txtGiaDV.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(151, 54);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(162, 22);
            this.txtTenDV.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Dịch vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.txtGiaDV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaDV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 122);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnThemDV
            // 
            this.btnThemDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDV.ImageOptions.Image")));
            this.btnThemDV.Location = new System.Drawing.Point(65, 198);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemDV.Size = new System.Drawing.Size(94, 47);
            this.btnThemDV.TabIndex = 22;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnResetDV
            // 
            this.btnResetDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetDV.ImageOptions.Image")));
            this.btnResetDV.Location = new System.Drawing.Point(180, 268);
            this.btnResetDV.Name = "btnResetDV";
            this.btnResetDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnResetDV.Size = new System.Drawing.Size(94, 38);
            this.btnResetDV.TabIndex = 20;
            this.btnResetDV.Text = "Reset";
            this.btnResetDV.Click += new System.EventHandler(this.btnResetDV_Click);
            // 
            // btnCapNhatDV
            // 
            this.btnCapNhatDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatDV.ImageOptions.Image")));
            this.btnCapNhatDV.Location = new System.Drawing.Point(180, 197);
            this.btnCapNhatDV.Name = "btnCapNhatDV";
            this.btnCapNhatDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCapNhatDV.Size = new System.Drawing.Size(116, 48);
            this.btnCapNhatDV.TabIndex = 19;
            this.btnCapNhatDV.Text = " Cập nhật";
            this.btnCapNhatDV.Click += new System.EventHandler(this.btnCapNhatDV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // btnTroVeDV
            // 
            this.btnTroVeDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVeDV.ImageOptions.Image")));
            this.btnTroVeDV.Location = new System.Drawing.Point(679, 312);
            this.btnTroVeDV.Name = "btnTroVeDV";
            this.btnTroVeDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTroVeDV.Size = new System.Drawing.Size(94, 29);
            this.btnTroVeDV.TabIndex = 24;
            this.btnTroVeDV.Text = "Trở về";
            this.btnTroVeDV.Click += new System.EventHandler(this.btnTroVeDV_Click);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDV.ImageOptions.Image")));
            this.btnXoaDV.Location = new System.Drawing.Point(65, 264);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoaDV.Size = new System.Drawing.Size(94, 47);
            this.btnXoaDV.TabIndex = 21;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // LoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 355);
            this.Controls.Add(this.btnTroVeDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.btnResetDV);
            this.Controls.Add(this.btnCapNhatDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvQLDV);
            this.Name = "LoaiDichVu";
            this.Text = "Loại Dịch vụ";
            this.Load += new System.EventHandler(this.LoaiDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtGiaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThemDV;
        private DevExpress.XtraEditors.SimpleButton btnResetDV;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatDV;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnTroVeDV;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGiaDV;
        private DevExpress.XtraEditors.SimpleButton btnXoaDV;
    }
}