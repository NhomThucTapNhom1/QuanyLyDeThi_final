using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThucTapNhom_QuanLyDeThi
{
    public partial class QuanLyDeThi : Form
    {
        connect con = new connect();
        bool kt,k;
        int r;
        string tk, mk, quyen;
        //DataTable db = new DataTable();
        public QuanLyDeThi()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main t = new Main(tk, mk, quyen);
            t.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            groupbox1.Enabled = true;
            r = dataGridView1.CurrentCell.RowIndex;
            txtTenDeThi.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            btnThem.Enabled = false;
            btnXem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenDeThi.Focus();
            kt = false;
        }

        private void btnKiemTra1_Click(object sender, EventArgs e)
        {
            con.Cmd = new SqlCommand("select count(*) from DeBai where TenDe = N'"+txtTenDeThi.Text+"'",con.Conn1);
            con.Cmd.CommandType = CommandType.Text;
            con.OpenConn();
            try
            {
                if ((int)con.Cmd.ExecuteScalar() == 0)
                {
                    MessageBox.Show("Tên đề bài an toàn không bị trùng", "Thông báo");
                    k = true;
                }
                else
                {
                    MessageBox.Show("Tên đề này đã tồn tại", "Thông báo");
                    k = false;
                }
            }
            catch
            {
                MessageBox.Show("Kiểm tra bị lỗi");
            }
            con.CloseConn();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(kt==true)
            {
                //them de
               if(k==true)
                {
                    try
                    {
                        if (con.SetData("sp_TaoDeThi N'" + txtTenDeThi.Text + "'") == true)
                        {
                            MessageBox.Show("Tạo đề thi thành công.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("thêm mới đề thi bị lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Cần kiểm tra tên đề trước khi lưu lại.");
                }
            }
            else
            {
                //sua de
                if (k == true)
                {
                    try
                    {
                        if (con.SetData("update DeBai set TenDe = N'" + txtTenDeThi.Text + "' where MaDe='"+dataGridView1.Rows[r].Cells[0].Value.ToString()+"'") == true)
                        {
                            MessageBox.Show("sửa tên đề thi thành công.");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("sửa đề thi bị lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Cần kiểm tra tên đề trước khi lưu lại.");
                }
            }
            hienthi();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(kt==true)
            {
                groupbox1.Enabled = false;
                grbDuLieu.Enabled = true;
                btnSua.Enabled = true;
                btnXem.Enabled = true;
                btnXoa.Enabled = true;
                k = false;
            }
            else
            {
                groupbox1.Enabled = false;
                btnThem.Enabled = true;
                btnXem.Enabled = true;
                btnXoa.Enabled = true;
                k = false;
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            r = dataGridView1.CurrentCell.RowIndex;
            this.Hide();
            MauDeThi t = new MauDeThi(tk, mk, quyen,dataGridView1.Rows[r].Cells[1].Value.ToString());
            t.ShowDialog();
            this.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            r = dataGridView1.CurrentCell.RowIndex;
            DialogResult d = MessageBox.Show("bạn có muốn xóa đề thi này không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(d==DialogResult.Yes)
            {
                try
                {
                    if (con.SetData("update DeBai set GhiChu = '0' where MaDe='" + dataGridView1.Rows[r].Cells[0].Value.ToString() + "'") == true)
                    {
                        MessageBox.Show("xóa đề thi thành công.");
                    }
                }
                catch
                {
                    MessageBox.Show("xóa đề thi bị lỗi");
                }
            }  
        }
        void hienthi()
        {
            DataTable dt = new DataTable();
            dt = con.GetData("select MaDe,TenDe from DeBai where GhiChu=1");
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
        private void QuanLyDeThi_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public QuanLyDeThi(string tk,string mk,string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupbox1.Enabled = true;
            grbDuLieu.Enabled = false;
            btnSua.Enabled = false;
            btnXem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenDeThi.Focus();
            kt = true;
        }
    }
}
