
namespace QLKSThangLong
{
    partial class SuDungVatTu
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
            this.dgvVatTu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaVT = new System.Windows.Forms.TextBox();
            this.CbbPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoLuongVT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaysudung = new System.Windows.Forms.DateTimePicker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVatTu
            // 
            this.dgvVatTu.AllowUserToAddRows = false;
            this.dgvVatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvVatTu.Location = new System.Drawing.Point(451, 70);
            this.dgvVatTu.Name = "dgvVatTu";
            this.dgvVatTu.ReadOnly = true;
            this.dgvVatTu.RowHeadersVisible = false;
            this.dgvVatTu.RowHeadersWidth = 51;
            this.dgvVatTu.RowTemplate.Height = 24;
            this.dgvVatTu.Size = new System.Drawing.Size(616, 330);
            this.dgvVatTu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã vật tư";
            // 
            // txtmaVT
            // 
            this.txtmaVT.Location = new System.Drawing.Point(157, 86);
            this.txtmaVT.Name = "txtmaVT";
            this.txtmaVT.Size = new System.Drawing.Size(121, 22);
            this.txtmaVT.TabIndex = 2;
            // 
            // CbbPhong
            // 
            this.CbbPhong.FormattingEnabled = true;
            this.CbbPhong.Location = new System.Drawing.Point(157, 124);
            this.CbbPhong.Name = "CbbPhong";
            this.CbbPhong.Size = new System.Drawing.Size(121, 24);
            this.CbbPhong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Phòng";
            // 
            // txtSoLuongVT
            // 
            this.txtSoLuongVT.Location = new System.Drawing.Point(157, 167);
            this.txtSoLuongVT.Name = "txtSoLuongVT";
            this.txtSoLuongVT.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuongVT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày sử dụng";
            // 
            // dtpNgaysudung
            // 
            this.dtpNgaysudung.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysudung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysudung.Location = new System.Drawing.Point(157, 207);
            this.dtpNgaysudung.Name = "dtpNgaysudung";
            this.dtpNgaysudung.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaysudung.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã vật tư";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Tên vật tư";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Loại vật tư";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Ngày sử dụng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã vật tư";
            // 
            // SuDungVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 596);
            this.Controls.Add(this.dtpNgaysudung);
            this.Controls.Add(this.CbbPhong);
            this.Controls.Add(this.txtSoLuongVT);
            this.Controls.Add(this.txtmaVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVatTu);
            this.Name = "SuDungVatTu";
            this.Text = "SuDungVatTu";
            this.Load += new System.EventHandler(this.SuDungVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVatTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaVT;
        private System.Windows.Forms.ComboBox CbbPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoLuongVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaysudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
    }
}