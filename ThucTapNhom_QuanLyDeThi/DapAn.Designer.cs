namespace ThucTapNhom_QuanLyDeThi
{
    partial class DapAn
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
            this.dgvDapAn = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnThemDapAn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaDapAn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaDapAn = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.txtNDDapAn = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDapAn)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDapAn
            // 
            this.dgvDapAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDapAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDapAn.Location = new System.Drawing.Point(70, 279);
            this.dgvDapAn.Name = "dgvDapAn";
            this.dgvDapAn.Size = new System.Drawing.Size(553, 150);
            this.dgvDapAn.TabIndex = 41;
            this.dgvDapAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDapAn_CellContentClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(373, 236);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(122, 23);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Quay lại";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel1.Text = "Lựa Chọn";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemDapAn,
            this.btnSuaDapAn,
            this.btnXoaDapAn});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // btnThemDapAn
            // 
            this.btnThemDapAn.Name = "btnThemDapAn";
            this.btnThemDapAn.Size = new System.Drawing.Size(147, 22);
            this.btnThemDapAn.Text = "Thêm Đáp Án";
            this.btnThemDapAn.Click += new System.EventHandler(this.btnThemDapAn_Click);
            // 
            // btnSuaDapAn
            // 
            this.btnSuaDapAn.Name = "btnSuaDapAn";
            this.btnSuaDapAn.Size = new System.Drawing.Size(147, 22);
            this.btnSuaDapAn.Text = "Sửa Đáp Án";
            this.btnSuaDapAn.Click += new System.EventHandler(this.btnSuaDapAn_Click);
            // 
            // btnXoaDapAn
            // 
            this.btnXoaDapAn.Name = "btnXoaDapAn";
            this.btnXoaDapAn.Size = new System.Drawing.Size(147, 22);
            this.btnXoaDapAn.Text = "Xóa Đáp Án";
            this.btnXoaDapAn.Click += new System.EventHandler(this.btnXoaDapAn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ghi Chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nội Dung Đáp Án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã Câu Hỏi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mã Đáp Án";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(462, 144);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(182, 20);
            this.txtGhiChu.TabIndex = 34;
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(147, 144);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(186, 20);
            this.txtMaCauHoi.TabIndex = 33;
            // 
            // txtNDDapAn
            // 
            this.txtNDDapAn.Location = new System.Drawing.Point(462, 87);
            this.txtNDDapAn.Name = "txtNDDapAn";
            this.txtNDDapAn.Size = new System.Drawing.Size(182, 20);
            this.txtNDDapAn.TabIndex = 32;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(147, 87);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(186, 20);
            this.txtMaDA.TabIndex = 31;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(190, 236);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 23);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu Thay Đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã Đề";
            // 
            // txtMaDe
            // 
            this.txtMaDe.Location = new System.Drawing.Point(147, 195);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(186, 20);
            this.txtMaDe.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "Quản lý đáp án";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(12, 25);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(102, 23);
            this.btThoat.TabIndex = 45;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // DapAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 444);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaDe);
            this.Controls.Add(this.dgvDapAn);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaCauHoi);
            this.Controls.Add(this.txtNDDapAn);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.btnLuu);
            this.Name = "DapAn";
            this.Text = "DapAn";
            this.Load += new System.EventHandler(this.DapAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDapAn)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDapAn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnThemDapAn;
        private System.Windows.Forms.ToolStripMenuItem btnSuaDapAn;
        private System.Windows.Forms.ToolStripMenuItem btnXoaDapAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.TextBox txtNDDapAn;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
    }
}