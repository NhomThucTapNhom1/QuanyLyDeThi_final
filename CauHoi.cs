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
    public partial class CauHoi : Form
    {
        string tk, mk, quyen;
        public CauHoi()
        {
            InitializeComponent();
        }
        public CauHoi(string tk,string mk,string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }
        private int a = 0;
        private void CauHoi_Load(object sender, EventArgs e)
        {
            txtMaCauHoi.Enabled = false;
            txtMaDe.Enabled = false;
            txtNDCauHoi.Enabled = false;
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                List<CauHoiMD> Customres = connection.Query<CauHoiMD>("Get_CauHoi", commandType: CommandType.StoredProcedure).ToList();

                dgvCauHoi.DataSource = Customres;
            }
        }

        private void thêmTàiKhoản_Click(object sender, EventArgs e)
        {
            a = 1;
            txtMaCauHoi.Enabled = true;
            txtMaDe.Enabled = true;
            txtNDCauHoi.Enabled = true;
        }
        private void ThemCauHoi(object sender, EventArgs e)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using (var transaction1 = connection.BeginTransaction())
                {
                    connection.QuerySingleOrDefault<string>("CauHoi_Insert",
                         new
                         {

                             MaCauHoi = txtMaCauHoi.Text,
                             MaDe = txtMaDe.Text,
                             NDCauHoi = txtNDCauHoi.Text

                         }, commandType: CommandType.StoredProcedure,
                         transaction: transaction1);
                    transaction1.Commit();
                    CauHoi_Load(sender, e);
                    MessageBox.Show("Thêm câu hỏi thành công");
                }
            }
        }
        private void sửaTàiKhoản_Click(object sender, EventArgs e)
        {
            a = 2;
            txtMaCauHoi.Enabled = true;
            txtMaDe.Enabled = true;
            txtNDCauHoi.Enabled = true;
        }
        private void SuaCauHoi(object sender, EventArgs e)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                connection.QuerySingleOrDefault<string>("UpDate_CauHoi", new
                {
                    MaCauHoi = txtMaCauHoi.Text,
                    NDCauHoi = txtNDCauHoi.Text
                }, commandType: CommandType.StoredProcedure);
                CauHoi_Load(sender, e);
                MessageBox.Show("Cập nhật thành công câu hỏi");

            }
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtMaCauHoi.Enabled = false;
            txtMaDe.Enabled = false;
            txtNDCauHoi.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(a == 1)
            {
                ThemCauHoi(sender, e);
            }
            else if(a == 2)
            {
                SuaCauHoi(sender, e);
            }
        }

        private void btnXoaCauHoi_Click(object sender, EventArgs e)
        {
            using (var connection = DB.ConnectionFactory())
            {
                connection.Open();
                using (var transaction1 = connection.BeginTransaction())
                {
                     connection.QuerySingleOrDefault<int>("Delete_CauHoi", 
                            new
                            {
                                key = txtMaCauHoi.Text
                            }, 
                            commandType: CommandType.StoredProcedure,
                            transaction: transaction1);
                    transaction1.Commit();
                    MessageBox.Show("Xoa ok");
                    CauHoi_Load(sender, e);
                }
            }
        }

        private void dgvCauHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtMaCauHoi.Text = dgvCauHoi.CurrentRow.Cells[0].Value.ToString();
            txtMaDe.Text = dgvCauHoi.CurrentRow.Cells[2].Value.ToString();
            txtNDCauHoi.Text = dgvCauHoi.CurrentRow.Cells[1].Value.ToString();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main t = new Main(tk, mk, quyen);
            t.ShowDialog();
        }
    }
}
