namespace ThucTapNhom_QuanLyDeThi
{
    partial class DeBai
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
            this.dgvMaDe = new System.Windows.Forms.DataGridView();
            this.btnMauDeThi = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnThemDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDe = new System.Windows.Forms.TextBox();
            this.txtMaDe = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaDe)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMaDe
            // 
            this.dgvMaDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaDe.Location = new System.Drawing.Point(47, 256);
            this.dgvMaDe.Name = "dgvMaDe";
            this.dgvMaDe.Size = new System.Drawing.Size(591, 150);
            this.dgvMaDe.TabIndex = 51;
            this.dgvMaDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaDe_CellContentClick);
            // 
            // btnMauDeThi
            // 
            this.btnMauDeThi.Location = new System.Drawing.Point(382, 162);
            this.btnMauDeThi.Name = "btnMauDeThi";
            this.btnMauDeThi.Size = new System.Drawing.Size(122, 23);
            this.btnMauDeThi.TabIndex = 50;
            this.btnMauDeThi.Text = "Mẫu đề thi";
            this.btnMauDeThi.UseVisualStyleBackColor = true;
            this.btnMauDeThi.Click += new System.EventHandler(this.btnMauDeThi_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.btnThemDe,
            this.btnSuaDe,
            this.btnXoaDe});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // btnThemDe
            // 
            this.btnThemDe.Name = "btnThemDe";
            this.btnThemDe.Size = new System.Drawing.Size(122, 22);
            this.btnThemDe.Text = "Thêm Đề";
            this.btnThemDe.Click += new System.EventHandler(this.thêmTàiKhoản_Click);
            // 
            // btnSuaDe
            // 
            this.btnSuaDe.Name = "btnSuaDe";
            this.btnSuaDe.Size = new System.Drawing.Size(122, 22);
            this.btnSuaDe.Text = "Sửa Đề";
            this.btnSuaDe.Click += new System.EventHandler(this.btnSuaDe_Click);
            // 
            // btnXoaDe
            // 
            this.btnXoaDe.Name = "btnXoaDe";
            this.btnXoaDe.Size = new System.Drawing.Size(122, 22);
            this.btnXoaDe.Text = "Xóa Đề";
            this.btnXoaDe.Click += new System.EventHandler(this.btnXoaDe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Tên Đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã Đề";
            // 
            // txtTenDe
            // 
            this.txtTenDe.Location = new System.Drawing.Point(437, 84);
            this.txtTenDe.Name = "txtTenDe";
            this.txtTenDe.Size = new System.Drawing.Size(186, 20);
            this.txtTenDe.TabIndex = 45;
            // 
            // txtMaDe
            // 
            this.txtMaDe.Location = new System.Drawing.Point(124, 84);
            this.txtMaDe.Name = "txtMaDe";
            this.txtMaDe.Size = new System.Drawing.Size(186, 20);
            this.txtMaDe.TabIndex = 43;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(188, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(122, 23);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu Thay Đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Quản lý đề thi";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(12, 25);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(91, 23);
            this.btThoat.TabIndex = 53;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // DeBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMaDe);
            this.Controls.Add(this.btnMauDeThi);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenDe);
            this.Controls.Add(this.txtMaDe);
            this.Controls.Add(this.btnLuu);
            this.Name = "DeBai";
            this.Text = "DeBai";
            this.Load += new System.EventHandler(this.DeBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaDe)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaDe;
        private System.Windows.Forms.Button btnMauDeThi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnThemDe;
        private System.Windows.Forms.ToolStripMenuItem btnSuaDe;
        private System.Windows.Forms.ToolStripMenuItem btnXoaDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDe;
        private System.Windows.Forms.TextBox txtMaDe;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
    }
}