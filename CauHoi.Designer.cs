namespace ThucTapNhom_QuanLyDeThi
{
    partial class CauHoi
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDwnButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnThemCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.txtNDCauHoi = new System.Windows.Forms.TextBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(351, 206);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 23);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Quay Lại";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDwnButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Lựa Chọn";
            // 
            // toolStripDropDwnButton1
            // 
            this.toolStripDropDwnButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDwnButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCauHoi,
            this.btnSuaCauHoi,
            this.btnXoaCauHoi});
            this.toolStripDropDwnButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDwnButton1.Name = "toolStripDropDwnButton1";
            this.toolStripDropDwnButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDwnButton1.Text = "toolStripDropDownButton1";
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(151, 22);
            this.btnThemCauHoi.Text = "Thêm Câu Hỏi";
            this.btnThemCauHoi.Click += new System.EventHandler(this.thêmTàiKhoản_Click);
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(151, 22);
            this.btnSuaCauHoi.Text = "Sửa Câu Hỏi";
            this.btnSuaCauHoi.Click += new System.EventHandler(this.sửaTàiKhoản_Click);
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Name = "btnXoaCauHoi";
            this.btnXoaCauHoi.Size = new System.Drawing.Size(151, 22);
            this.btnXoaCauHoi.Text = "Xóa Câu Hỏi";
            this.btnXoaCauHoi.Click += new System.EventHandler(this.btnXoaCauHoi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Mã Đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nội Dung Câu Hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Câu Hỏi";
            // 
            // txtMaDe
            // 
            this.txtMaDe.Location = new System.Drawing.Point(125, 131);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(186, 20);
            this.txtMaDe.TabIndex = 34;
            // 
            // txtNDCauHoi
            // 
            this.txtNDCauHoi.Location = new System.Drawing.Point(440, 77);
            this.txtNDCauHoi.Multiline = true;
            this.txtNDCauHoi.Name = "txtNDCauHoi";
            this.txtNDCauHoi.Size = new System.Drawing.Size(182, 20);
            this.txtNDCauHoi.TabIndex = 32;
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(125, 77);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(186, 20);
            this.txtMaCauHoi.TabIndex = 31;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(168, 206);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 23);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu Thay Đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Location = new System.Drawing.Point(81, 258);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.Size = new System.Drawing.Size(541, 150);
            this.dgvCauHoi.TabIndex = 41;
            this.dgvCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauHoi_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Quản lý câu hỏi thi";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(10, 28);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(90, 23);
            this.btThoat.TabIndex = 43;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // CauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCauHoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaDe);
            this.Controls.Add(this.txtNDCauHoi);
            this.Controls.Add(this.txtMaCauHoi);
            this.Controls.Add(this.btnLuu);
            this.Name = "CauHoi";
            this.Text = "CauHoi";
            this.Load += new System.EventHandler(this.CauHoi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDwnButton1;
        private System.Windows.Forms.ToolStripMenuItem btnThemCauHoi;
        private System.Windows.Forms.ToolStripMenuItem btnSuaCauHoi;
        private System.Windows.Forms.ToolStripMenuItem btnXoaCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDe;
        private System.Windows.Forms.TextBox txtNDCauHoi;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
    }
}