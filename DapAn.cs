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

namespace ThucTapNhom_QuanLyDeThi
{
    public partial class DapAn : Form
    {
        string tk, mk, quyen;
        public DapAn()
        {
            InitializeComponent();
        }
        public DapAn(string tk,string mk,string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }
        private int a = 0;
        private void btnThemDapAn_Click(object sender, EventArgs e)
        {
            txtMaDA.Enabled = true;
            txtNDDapAn.Enabled = true;
            txtMaCauHoi.Enabled = true;
            txtGhiChu.Enabled = true;
            txtMaDe.Enabled = true;
            a = 1;
        }
        private void ThemDapAn(object sender, EventArgs e)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using (var transaction1 = connection.BeginTransaction())
                {
                    connection.QuerySingleOrDefault<string>("Insert_DapAn",
                         new
                         {
                             MaDapAn = txtMaDA.Text,
                             NDDA = txtNDDapAn.Text,
                             GhiChu = txtGhiChu.Text,
                             MaCauHoi = txtMaCauHoi.Text,
                             MaDe = txtMaDe.Text,

                         }, commandType: CommandType.StoredProcedure,
                         transaction: transaction1);
                    transaction1.Commit();
                    DapAn_Load(sender, e);
                    MessageBox.Show("Thêm đáp án thành công");
                }
            }
        }
        private void btnSuaDapAn_Click(object sender, EventArgs e)
        {
            //txtMaDA.Enabled = true;
            txtNDDapAn.Enabled = true;
            //txtMaCauHoi.Enabled = true;
            txtGhiChu.Enabled = true;
            //txtMaDe.Enabled = true;
            a = 2;
        }
        private void SuaDapAn(object sender, EventArgs e)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                connection.QuerySingleOrDefault<string>("Update_DapAn", new
                {
                    MaDapAn = txtMaDA.Text,
                    NDDA = txtNDDapAn.Text,
                    GhiChu = txtGhiChu.Text
                }, commandType: CommandType.StoredProcedure);
                DapAn_Load(sender, e);
                MessageBox.Show("Cập nhật thành công đáp án");

            }
        }

        private void DapAn_Load(object sender, EventArgs e)
        {
            txtMaDA.Enabled = false;
            txtNDDapAn.Enabled = false;
            txtMaCauHoi.Enabled = false;
            txtGhiChu.Enabled = false;
            txtMaDe.Enabled = false;
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                List<DapAnMD> customer = connection.Query<DapAnMD>("Get_DapAn", commandType : CommandType.StoredProcedure).ToList();
                dgvDapAn.DataSource = customer;
            }
        }

        private void btnXoaDapAn_Click(object sender, EventArgs e)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using (var transaction1 = connection.BeginTransaction())
                {
                    connection.QuerySingleOrDefault<int>("Delete_CauHoi",
                           new
                           {
                               key = txtMaDA.Text
                           },
                           commandType: CommandType.StoredProcedure,
                           transaction: transaction1);
                    transaction1.Commit();
                    MessageBox.Show("Xoa ok");
                    DapAn_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                ThemDapAn(sender, e);
            }
            else if(a == 2)
            {
                SuaDapAn(sender, e);
            }
        }

        private void dgvDapAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDA.Text = dgvDapAn.CurrentRow.Cells[0].Value.ToString();
            txtNDDapAn.Text = dgvDapAn.CurrentRow.Cells[1].Value.ToString();
            txtGhiChu.Text = dgvDapAn.CurrentRow.Cells[2].Value.ToString();
            txtMaCauHoi.Text = dgvDapAn.CurrentRow.Cells[3].Value.ToString();
            txtMaDe.Text = dgvDapAn.CurrentRow.Cells[4].Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main t = new Main(tk, mk, quyen);
            t.ShowDialog();
        }
    }
}
