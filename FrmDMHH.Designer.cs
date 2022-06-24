
namespace LopPTUD2022_Sang
{
    partial class FrmDMHH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.label12345 = new System.Windows.Forms.Label();
            this.label123456 = new System.Windows.Forms.Label();
            this.label1234567 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.txtSanXuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnfirst = new System.Windows.Forms.Button();
            this.btnpre = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quan ly danh muc hang hoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grdData
            // 
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.MaHH,
            this.TenHH,
            this.dvt,
            this.dgvnd,
            this.sanxuat});
            this.grdData.Location = new System.Drawing.Point(24, 54);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(559, 331);
            this.grdData.TabIndex = 1;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Nhóm hàng";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.Width = 87;
            // 
            // MaHH
            // 
            this.MaHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "Mã hàng";
            this.MaHH.Name = "MaHH";
            this.MaHH.Width = 74;
            // 
            // TenHH
            // 
            this.TenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng";
            this.TenHH.Name = "TenHH";
            this.TenHH.Width = 78;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvt.DataPropertyName = "dvt";
            this.dvt.HeaderText = "đơn vị tính";
            this.dvt.Name = "dvt";
            this.dvt.Width = 84;
            // 
            // dgvnd
            // 
            this.dgvnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dgvnd.DataPropertyName = "dgvnd";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvnd.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnd.HeaderText = "đơn giá VND";
            this.dgvnd.Name = "dgvnd";
            this.dgvnd.Width = 94;
            // 
            // sanxuat
            // 
            this.sanxuat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sanxuat.DataPropertyName = "sanxuat";
            this.sanxuat.HeaderText = "nước sản xuất";
            this.sanxuat.Name = "sanxuat";
            this.sanxuat.Width = 99;
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.Location = new System.Drawing.Point(704, 77);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(214, 23);
            this.txtMaNhom.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(704, 305);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(214, 23);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtDVT
            // 
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDVT.Location = new System.Drawing.Point(704, 248);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(214, 23);
            this.txtDVT.TabIndex = 6;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHH.Location = new System.Drawing.Point(704, 191);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(214, 23);
            this.txtTenHH.TabIndex = 7;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHH.Location = new System.Drawing.Point(704, 134);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(214, 23);
            this.txtMaHH.TabIndex = 8;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(623, 80);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(75, 20);
            this.label123.TabIndex = 9;
            this.label123.Text = "Mã nhóm";
            // 
            // label12345
            // 
            this.label12345.AutoSize = true;
            this.label12345.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12345.Location = new System.Drawing.Point(623, 137);
            this.label12345.Name = "label12345";
            this.label12345.Size = new System.Drawing.Size(71, 20);
            this.label12345.TabIndex = 10;
            this.label12345.Text = "Mã hàng";
            // 
            // label123456
            // 
            this.label123456.AutoSize = true;
            this.label123456.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123456.Location = new System.Drawing.Point(623, 194);
            this.label123456.Name = "label123456";
            this.label123456.Size = new System.Drawing.Size(76, 20);
            this.label123456.TabIndex = 11;
            this.label123456.Text = "Tên hàng";
            // 
            // label1234567
            // 
            this.label1234567.AutoSize = true;
            this.label1234567.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1234567.Location = new System.Drawing.Point(623, 251);
            this.label1234567.Name = "label1234567";
            this.label1234567.Size = new System.Drawing.Size(41, 20);
            this.label1234567.TabIndex = 12;
            this.label1234567.Text = "DVT";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.Location = new System.Drawing.Point(623, 308);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(64, 20);
            this.label124.TabIndex = 13;
            this.label124.Text = "Đơn giá";
            // 
            // txtSanXuat
            // 
            this.txtSanXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSanXuat.Location = new System.Drawing.Point(704, 362);
            this.txtSanXuat.Name = "txtSanXuat";
            this.txtSanXuat.Size = new System.Drawing.Size(214, 23);
            this.txtSanXuat.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(623, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nước SX";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(24, 412);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 23);
            this.btnfirst.TabIndex = 16;
            this.btnfirst.Text = "Dau";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnpre
            // 
            this.btnpre.Location = new System.Drawing.Point(185, 412);
            this.btnpre.Name = "btnpre";
            this.btnpre.Size = new System.Drawing.Size(75, 23);
            this.btnpre.TabIndex = 17;
            this.btnpre.Text = "Truoc";
            this.btnpre.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(346, 412);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 18;
            this.btnnext.Text = "Sau";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(507, 412);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 19;
            this.btnlast.Text = "Cuoi";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // FrmDMHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(953, 466);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnpre);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSanXuat);
            this.Controls.Add(this.label124);
            this.Controls.Add(this.label1234567);
            this.Controls.Add(this.label123456);
            this.Controls.Add(this.label12345);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtDVT);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.label1);
            this.Name = "FrmDMHH";
            this.Text = "FrmDMHH";
            this.Load += new System.EventHandler(this.FrmDMHH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanxuat;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Label label12345;
        private System.Windows.Forms.Label label123456;
        private System.Windows.Forms.Label label1234567;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox txtSanXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnpre;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
    }
}