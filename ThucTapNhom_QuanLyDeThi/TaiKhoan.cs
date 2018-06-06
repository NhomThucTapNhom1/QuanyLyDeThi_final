using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucTapNhom_QuanLyDeThi
{
    public partial class TaiKhoan : Form
    {
        connect con = new connect();
        String MK = "", TK = "", quyen = "";

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    //frmMain t = new frmMain(pass,user,maquyen);
        //    //t.ShowDialog();
        //}

        void hienthi()
        {
            string sql1 = "sp_TaiKhoanTS";
            string sql = "sp_TaiKhoanNV";
            ttUser.Text = this.TK;
            ttMK1.Text = this.MK;
            if (this.quyen == "Quyen2" || this.quyen == "Quyen3")
            {
                DataTable dt = new DataTable();
                dt = con.GetData(sql1);
                dgv1.DataSource = dt;
                dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv1.Refresh();
            }
            if (this.quyen == "Quyen3")
            {
                DataTable dt = new DataTable();
                dt = con.GetData(sql);
                dgv2.DataSource = dt;
                dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv2.Refresh();
            }
        }
        private void frmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv2.CurrentCell.RowIndex;
            textTK.Text = dgv2.Rows[r].Cells[2].Value.ToString();
            textMK1.Text = dgv2.Rows[r].Cells[3].Value.ToString();
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv1.CurrentCell.RowIndex;
            txtUser.Text = dgv1.Rows[r].Cells[2].Value.ToString();
            txtMK1.Text = dgv1.Rows[r].Cells[3].Value.ToString();
        }

        private void btDMK_Click(object sender, EventArgs e)
        {
            if (ttMK2.Text != null && ttMK3.Text != null)
            {
                if (ttMK2.Text == ttMK3.Text)
                {
                    if (con.SetData("sp_SuaTK N'" + ttMK2.Text + "',N'" + ttUser.Text + "'") == true)
                        MessageBox.Show("Sửa thành công.", "thông báo");
                    else
                        MessageBox.Show("Sửa không thành công.", "thông báo");
                }
                else
                {
                    MessageBox.Show("Hai mật khẩu mới phải khớp với nhau", "thông báo");
                }
            }
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (txtMK2.Text != null && txtMK3.Text != null)
            {
                if (txtMK2.Text == txtMK3.Text)
                {
                    if (con.SetData("sp_SuaTK N'" + txtMK2.Text + "',N'" + txtUser.Text + "'") == true)
                        MessageBox.Show("Sửa thành công.", "thông báo");
                    else
                        MessageBox.Show("Sửa không thành công.", "thông báo");
                }
                else
                {
                    MessageBox.Show("Hai mật khẩu mới phải khớp với nhau", "thông báo");
                }
            }
            hienthi();
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (textMK2.Text != null && textMK3.Text != null)
            {
                if (textMK2.Text == textMK3.Text)
                {
                    if (con.SetData("sp_SuaTK N'" + textMK2.Text + "',N'" + textTK.Text + "'") == true)
                        MessageBox.Show("Sửa thành công.", "thông báo");
                    else
                        MessageBox.Show("Sửa không thành công.", "thông báo");
                }
                else
                {
                    MessageBox.Show("Hai mật khẩu mới phải khớp với nhau", "thông báo");
                }
            }
            hienthi();
        }

        private void butTao_Click(object sender, EventArgs e)
        {
            if(cbNV.Enabled == false)
            {
                string sql = "sp_HienThiNV";
                DataTable dt = new DataTable();
                dt = con.GetData(sql);
                cbNV.DataSource = dt;
                cbNV.ValueMember = "MaNV";
                textTK.ReadOnly = false;
                textTK.Text = "";
                lbMKNV.Enabled = false;
                textMK1.Enabled = false;
                lbMaNV.Enabled = true;
                cbNV.Enabled = true;
                button1.Enabled = true;
                but2.Enabled = false;
            }
            else
            {
                textMK1.Text = "";
                textTK.Text = "";
                textTK.ReadOnly = true;
                lbMKNV.Enabled = true;
                textMK1.Enabled = true;
                cbNV.Enabled = false;
                lbMaNV.Enabled = false;
                but2.Enabled = true;
                button1.Enabled = false;
            }
        }

        //135
        private void button1_Click(object sender, EventArgs e)
        {
                string sql1 = "sp_taoTKNV '" + cbNV.Text + "','" + textTK.Text + "','" + textMK2.Text + "'";
                string sql2 = "select count(*) from TaiKhoan where TenTK= '" + textTK.Text + "'";
                con.Cmd = new SqlCommand(sql2, con.Conn1);
            try
            {
                    con.Cmd.CommandText = sql2;
                    if ((int)con.Cmd.ExecuteScalar() == 0)
                    {
                        try
                        {
                            if (textMK2.Text == textMK3.Text && textMK2.Text != null)
                            {
                                con.SetData(sql1);
                                MessageBox.Show("tạo tài khoản thành công.", "thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Hai mật khẩu mới phải khớp với nhau", "thông báo");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("tạo tài khoản bị lỗi.", "thông báo");
                        }
                    }
                    else
                        MessageBox.Show("Tên tài khoản đã có người sử dụng.", "thông báo");
                
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Mã nhân viên.", "thông báo");
            }
            hienthi();
        }

        private void butTTK_Click(object sender, EventArgs e)
        {
            if (cbTS.Enabled == false)
            {
                string sql = "sp_HienThiTS";
                DataTable dt = new DataTable();
                dt = con.GetData(sql);
                cbTS.DataSource = dt;
                cbTS.ValueMember = "MaThe";
                but1.Enabled = false;
                butLuu.Enabled = true;
                lbTD.Enabled = true;
                cbTS.Enabled = true;
                txtUser.ReadOnly = false;
                txtUser.Text = "";
                txtMK1.Enabled = false;
                lbMk.Enabled = false;
            }
            else
            {
                but1.Enabled = true;
                butLuu.Enabled = false;
                lbTD.Enabled = false;
                cbTS.Enabled = false;
                txtUser.ReadOnly = true;
                txtUser.Text = "";
                txtMK1.Enabled = true;
                lbMk.Enabled = true;
                txtMK1.Text = "";
            }
        }
        //194
        private void butLuu_Click(object sender, EventArgs e)
        {
            string sql1 = "sp_taoTKTS '" + cbTS.Text + "','" + txtUser.Text + "','" + txtMK2.Text + "'";
            string sql2 = "select count(*) from TaiKhoan where TenTK= '" + txtUser.Text + "'";
            con.Cmd = new SqlCommand(sql2, con.Conn1);
            try
            {
                    con.Cmd.CommandText = sql2;
                    if ((int)con.Cmd.ExecuteScalar() == 0)
                    {
                        try
                        {
                            if (txtMK2.Text == txtMK3.Text && txtMK2.Text != null)
                            {
                                con.SetData(sql1);
                                MessageBox.Show("tạo tài khoản thành công.", "thông báo");
                            }
                            else
                            {
                                MessageBox.Show("Hai mật khẩu mới phải khớp với nhau", "thông báo");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("tạo tài khoản bị lỗi.", "thông báo");
                        }
                    }
                    else
                        MessageBox.Show("Tên tài khoản đã có người sử dụng.", "thông báo");
                
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra lại Mã thí sinh.", "thông báo");
            }
            hienthi();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main t = new Main(TK,MK,quyen);
            t.ShowDialog();
        }

        public TaiKhoan()
        {
            InitializeComponent();
        }
        public TaiKhoan( string user,string pass,string MaQuyen)
        {
            InitializeComponent();
            this.MK = pass;
            this.TK = user;
            this.quyen = MaQuyen;
        }
    }
}
