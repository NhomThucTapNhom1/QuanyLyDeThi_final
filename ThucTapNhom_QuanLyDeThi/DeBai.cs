using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucTapNhom_QuanLyDeThi.Model;
using System.Data.SqlClient;

namespace ThucTapNhom_QuanLyDeThi
{
    public partial class DeBai : Form
    {
        connect con = new connect();
        string TK, MK, quyen;
        public DeBai()
        {
            InitializeComponent();
        }
        public DeBai(string tk,string mk,string quyen)
        {
            InitializeComponent();
            this.TK = tk;
            this.MK = mk;
            this.quyen = quyen;
        }
        int a = 0;
        private void thêmTàiKhoản_Click(object sender, EventArgs e)
        {
            a = 1;
            txtMaDe.Enabled = true;
            txtTenDe.Enabled = true;
        }
        private void ThemDeBai(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DB.ConnectionFactory())
                {
                    connection.Open();
                    using (var transaction1 = connection.BeginTransaction())
                    {
                        connection.QuerySingleOrDefault<string>("Insert_DeBai",
                             new
                             {

                                 MaDe = txtMaDe.Text,
                                 TenDe = txtTenDe.Text

                             }, commandType: CommandType.StoredProcedure,
                             transaction: transaction1);
                        transaction1.Commit();
                        DeBai_Load(sender, e);
                        MessageBox.Show("Thêm đề bài thành công");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm đề bài không thành công");
            }
            
        }
        private void DeBai_Load(object sender, EventArgs e)
        {
            a = 0;
            txtMaDe.Enabled = false;
            txtTenDe.Enabled = false;
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                List<DeBaiMD> Customer = connection.Query<DeBaiMD>("Get_DeBai", commandType: CommandType.StoredProcedure).ToList();
                dgvMaDe.DataSource = Customer;
            }
        }

        private void btnSuaDe_Click(object sender, EventArgs e)
        {
            //txtMaDe.Enabled = true;
            txtTenDe.Enabled = true;
            a = 2;
        }
        private void SuaDeBai(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DB.ConnectionFactory())
                {
                    connection.Open();
                    connection.QuerySingleOrDefault<string>("Update_DeBai", new
                    {
                        MaDe = txtMaDe.Text,
                        TenDe = txtTenDe.Text
                    }, commandType: CommandType.StoredProcedure);
                    DeBai_Load(sender, e);
                    MessageBox.Show("Cập nhật thành công đề bài");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật không thành công đề bài");
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                ThemDeBai(sender, e);
            } 
            else if(a == 2)
            {
                SuaDeBai(sender, e);
            }
        }

        private void btnXoaDe_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DB.ConnectionFactory())
                {
                    connection.Open();
                    using (var transaction1 = connection.BeginTransaction())
                    {
                        connection.QuerySingleOrDefault<int>("Delete_CauHoi",
                               new
                               {
                                   key = txtMaDe.Text
                               },
                               commandType: CommandType.StoredProcedure,
                               transaction: transaction1);
                        transaction1.Commit();
                        MessageBox.Show("Xoa ok");
                        DeBai_Load(sender, e);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoa ko thành công");
            }
            
        }

        private void btnMauDeThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            MauDeThi t = new MauDeThi();
            t.ShowDialog();
            this.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvMaDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDe.Text = dgvMaDe.CurrentRow.Cells[0].Value.ToString();
            txtTenDe.Text = dgvMaDe.CurrentRow.Cells[1].Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main t = new Main(TK, MK, quyen);
            t.ShowDialog();
        }
    }
}
