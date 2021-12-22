
namespace QLKSThangLong
{
    partial class DangKyDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyDV));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDKDV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPDV = new System.Windows.Forms.TextBox();
            this.txtSoLuongDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoPhongDV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTenDV = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemDKDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDKDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnResetDKDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnInDKDV = new DevExpress.XtraEditors.SimpleButton();
            this.btnTroVeDKDV = new DevExpress.XtraEditors.SimpleButton();
            this.dgvMaPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG KÝ DỊCH VỤ";
            // 
            // dgvDKDV
            // 
            this.dgvDKDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDKDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDKDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDKDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaPDV,
            this.dgvSoPhong,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDKDV.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDKDV.Location = new System.Drawing.Point(305, 95);
            this.dgvDKDV.Name = "dgvDKDV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDKDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDKDV.RowHeadersVisible = false;
            this.dgvDKDV.RowHeadersWidth = 51;
            this.dgvDKDV.RowTemplate.Height = 24;
            this.dgvDKDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDKDV.Size = new System.Drawing.Size(638, 348);
            this.dgvDKDV.TabIndex = 3;
            this.dgvDKDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDKDV_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã PDV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaPDV
            // 
            this.txtMaPDV.Location = new System.Drawing.Point(106, 21);
            this.txtMaPDV.Name = "txtMaPDV";
            this.txtMaPDV.Size = new System.Drawing.Size(64, 22);
            this.txtMaPDV.TabIndex = 5;
            // 
            // txtSoLuongDV
            // 
            this.txtSoLuongDV.Location = new System.Drawing.Point(107, 168);
            this.txtSoLuongDV.Name = "txtSoLuongDV";
            this.txtSoLuongDV.Size = new System.Drawing.Size(64, 22);
            this.txtSoLuongDV.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // txtSoPhongDV
            // 
            this.txtSoPhongDV.Enabled = false;
            this.txtSoPhongDV.Location = new System.Drawing.Point(106, 68);
            this.txtSoPhongDV.Name = "txtSoPhongDV";
            this.txtSoPhongDV.Size = new System.Drawing.Size(65, 22);
            this.txtSoPhongDV.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên Dịch vụ";
            // 
            // cbbTenDV
            // 
            this.cbbTenDV.FormattingEnabled = true;
            this.cbbTenDV.Location = new System.Drawing.Point(107, 120);
            this.cbbTenDV.Name = "cbbTenDV";
            this.cbbTenDV.Size = new System.Drawing.Size(161, 24);
            this.cbbTenDV.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbbTenDV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPDV);
            this.groupBox1.Controls.Add(this.txtSoPhongDV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuongDV);
            this.groupBox1.Location = new System.Drawing.Point(25, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnThemDKDV
            // 
            this.btnThemDKDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDKDV.ImageOptions.Image")));
            this.btnThemDKDV.Location = new System.Drawing.Point(42, 328);
            this.btnThemDKDV.Name = "btnThemDKDV";
            this.btnThemDKDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnThemDKDV.Size = new System.Drawing.Size(94, 47);
            this.btnThemDKDV.TabIndex = 26;
            this.btnThemDKDV.Text = "Thêm";
            // 
            // btnXoaDKDV
            // 
            this.btnXoaDKDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDKDV.ImageOptions.Image")));
            this.btnXoaDKDV.Location = new System.Drawing.Point(42, 396);
            this.btnXoaDKDV.Name = "btnXoaDKDV";
            this.btnXoaDKDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnXoaDKDV.Size = new System.Drawing.Size(94, 47);
            this.btnXoaDKDV.TabIndex = 25;
            this.btnXoaDKDV.Text = "Xóa";
            // 
            // btnResetDKDV
            // 
            this.btnResetDKDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetDKDV.ImageOptions.Image")));
            this.btnResetDKDV.Location = new System.Drawing.Point(167, 333);
            this.btnResetDKDV.Name = "btnResetDKDV";
            this.btnResetDKDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnResetDKDV.Size = new System.Drawing.Size(94, 38);
            this.btnResetDKDV.TabIndex = 24;
            this.btnResetDKDV.Text = "Reset";
            // 
            // btnInDKDV
            // 
            this.btnInDKDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDKDV.ImageOptions.Image")));
            this.btnInDKDV.Location = new System.Drawing.Point(167, 401);
            this.btnInDKDV.Name = "btnInDKDV";
            this.btnInDKDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnInDKDV.Size = new System.Drawing.Size(94, 38);
            this.btnInDKDV.TabIndex = 27;
            this.btnInDKDV.Text = "In";
            // 
            // btnTroVeDKDV
            // 
            this.btnTroVeDKDV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTroVeDKDV.ImageOptions.Image")));
            this.btnTroVeDKDV.Location = new System.Drawing.Point(849, 449);
            this.btnTroVeDKDV.Name = "btnTroVeDKDV";
            this.btnTroVeDKDV.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTroVeDKDV.Size = new System.Drawing.Size(94, 29);
            this.btnTroVeDKDV.TabIndex = 28;
            this.btnTroVeDKDV.Text = "Trở về";
            // 
            // dgvMaPDV
            // 
            this.dgvMaPDV.HeaderText = "Mã PDV";
            this.dgvMaPDV.MinimumWidth = 6;
            this.dgvMaPDV.Name = "dgvMaPDV";
            // 
            // dgvSoPhong
            // 
            this.dgvSoPhong.HeaderText = "Số phòng";
            this.dgvSoPhong.MinimumWidth = 6;
            this.dgvSoPhong.Name = "dgvSoPhong";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên dịch vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Số lượng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày sử dụng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // DangKyDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 490);
            this.Controls.Add(this.btnTroVeDKDV);
            this.Controls.Add(this.btnInDKDV);
            this.Controls.Add(this.btnThemDKDV);
            this.Controls.Add(this.btnXoaDKDV);
            this.Controls.Add(this.btnResetDKDV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDKDV);
            this.Controls.Add(this.label1);
            this.Name = "DangKyDV";
            this.Text = "DangKyDV";
            this.Load += new System.EventHandler(this.DangKyDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDKDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDKDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPDV;
        private System.Windows.Forms.TextBox txtSoLuongDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoPhongDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTenDV;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThemDKDV;
        private DevExpress.XtraEditors.SimpleButton btnXoaDKDV;
        private DevExpress.XtraEditors.SimpleButton btnResetDKDV;
        private DevExpress.XtraEditors.SimpleButton btnInDKDV;
        private DevExpress.XtraEditors.SimpleButton btnTroVeDKDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}