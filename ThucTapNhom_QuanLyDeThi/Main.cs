using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyDeThi
{
    public partial class Main : Form
    {
        string tk, mk, quyen;

        private void btXuat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn chắc chắn muốn đăng xuất hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                this.Hide();
                DangNhap DN = new DangNhap();
                DN.ShowDialog();
            }
        }

        private void btQLNV_Click(object sender, EventArgs e)
        {
            if(quyen=="Quyen3")
            {
                this.Hide();
                NhanVien t = new NhanVien(tk,mk,quyen);
                t.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này.","thông báo");
            }
        }

        private void btQLTK_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan t = new TaiKhoan(tk,mk,quyen);
            t.ShowDialog();
        }

        private void btQLDT_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDeThi t = new QuanLyDeThi(tk,mk,quyen);
            t.ShowDialog();
        }

        private void btQLCH_Click(object sender, EventArgs e)
        {
            this.Hide();
            CauHoi t = new CauHoi(tk, mk, quyen);
            t.ShowDialog();
        }

        private void btQLDA_Click(object sender, EventArgs e)
        {
            this.Hide();
            DapAn t = new DapAn(tk, mk, quyen);
            t.ShowDialog();
        }

        public Main()
        {
            InitializeComponent();
        }
        public Main(string tk,string mk,string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }
    }
}
