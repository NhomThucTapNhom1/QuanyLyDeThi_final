namespace ThucTapNhom_QuanLyDeThi
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btQLCH = new System.Windows.Forms.Button();
            this.btQLNV = new System.Windows.Forms.Button();
            this.btQLTK = new System.Windows.Forms.Button();
            this.btQLDT = new System.Windows.Forms.Button();
            this.btQLDA = new System.Windows.Forms.Button();
            this.btXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý ngân hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "đề thi câu hỏi toán rời rạc";
            // 
            // btQLCH
            // 
            this.btQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLCH.Location = new System.Drawing.Point(94, 159);
            this.btQLCH.Name = "btQLCH";
            this.btQLCH.Size = new System.Drawing.Size(183, 31);
            this.btQLCH.TabIndex = 3;
            this.btQLCH.Text = "Quản lý Câu hỏi thi";
            this.btQLCH.UseVisualStyleBackColor = true;
            this.btQLCH.Click += new System.EventHandler(this.btQLCH_Click);
            // 
            // btQLNV
            // 
            this.btQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNV.Location = new System.Drawing.Point(94, 270);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(183, 31);
            this.btQLNV.TabIndex = 4;
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.UseVisualStyleBackColor = true;
            this.btQLNV.Click += new System.EventHandler(this.btQLNV_Click);
            // 
            // btQLTK
            // 
            this.btQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLTK.Location = new System.Drawing.Point(94, 233);
            this.btQLTK.Name = "btQLTK";
            this.btQLTK.Size = new System.Drawing.Size(183, 31);
            this.btQLTK.TabIndex = 5;
            this.btQLTK.Text = "Quản lý tài khoản";
            this.btQLTK.UseVisualStyleBackColor = true;
            this.btQLTK.Click += new System.EventHandler(this.btQLTK_Click);
            // 
            // btQLDT
            // 
            this.btQLDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLDT.Location = new System.Drawing.Point(94, 196);
            this.btQLDT.Name = "btQLDT";
            this.btQLDT.Size = new System.Drawing.Size(183, 31);
            this.btQLDT.TabIndex = 6;
            this.btQLDT.Text = "Quản lý đề thi";
            this.btQLDT.UseVisualStyleBackColor = true;
            this.btQLDT.Click += new System.EventHandler(this.btQLDT_Click);
            // 
            // btQLDA
            // 
            this.btQLDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLDA.Location = new System.Drawing.Point(94, 122);
            this.btQLDA.Name = "btQLDA";
            this.btQLDA.Size = new System.Drawing.Size(183, 31);
            this.btQLDA.TabIndex = 2;
            this.btQLDA.Text = "Quản lý đáp án";
            this.btQLDA.UseVisualStyleBackColor = true;
            this.btQLDA.Click += new System.EventHandler(this.btQLDA_Click);
            // 
            // btXuat
            // 
            this.btXuat.Location = new System.Drawing.Point(12, 7);
            this.btXuat.Name = "btXuat";
            this.btXuat.Size = new System.Drawing.Size(75, 23);
            this.btXuat.TabIndex = 8;
            this.btXuat.Text = "Đăng xuất";
            this.btXuat.UseVisualStyleBackColor = true;
            this.btXuat.Click += new System.EventHandler(this.btXuat_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 327);
            this.Controls.Add(this.btXuat);
            this.Controls.Add(this.btQLDT);
            this.Controls.Add(this.btQLTK);
            this.Controls.Add(this.btQLNV);
            this.Controls.Add(this.btQLCH);
            this.Controls.Add(this.btQLDA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQLCH;
        private System.Windows.Forms.Button btQLNV;
        private System.Windows.Forms.Button btQLTK;
        private System.Windows.Forms.Button btQLDT;
        private System.Windows.Forms.Button btQLDA;
        private System.Windows.Forms.Button btXuat;
    }
}