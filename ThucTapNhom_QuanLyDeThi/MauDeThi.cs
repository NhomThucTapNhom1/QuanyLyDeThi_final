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
    public partial class MauDeThi : Form
    {
        connect con = new connect();
        string tk, mk, quyen,tende;
        public MauDeThi()
        {
            InitializeComponent();
        }
        public MauDeThi(string tk,string mk,string quyen,string TenDe)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
            this.tende = TenDe;
            //MessageBox.Show(this.tende);
        }
        void hienthi()
        {
            //string str = "select TenDe from DeBai";
            //DataTable dt = new DataTable();
            //dt = con.GetData(str);
            //cb1.DataSource = dt;
            //cb1.ValueMember = "TenDe";
            txtTenDe.Text = this.tende;
            DataTable dt = new DataTable();
            con.Cmd = new SqlCommand("", con.Conn1);
            con.Cmd.CommandType = CommandType.Text;
            con.OpenConn();
            //buoc 1:lay ten de bai
            string MaDe;
            //MessageBox.Show(TenDe);
            //buoc 2 lay ma cua de qua ten de
            con.Cmd.CommandText = "select MaDe from DeBai where TenDe = N'" + this.tende + "'";
            MaDe = con.Cmd.ExecuteScalar().ToString();
            //MessageBox.Show(MaDe);
            //buoc 3 lay ten cua cac cau hoi trong 1 de thi
            //cau 1
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau1','" + MaDe + "'";
            labCau1.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 2
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau2','" + MaDe + "'";
            labCau2.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 3
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau3','" + MaDe + "'";
            labCau3.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 4
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau4','" + MaDe + "'";
            labCau4.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 5
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau5','" + MaDe + "'";
            labCau5.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 6
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau6','" + MaDe + "'";
            labCau6.Text = con.Cmd.ExecuteScalar().ToString();
            //cau7
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau7','" + MaDe + "'";
            labCau7.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 8
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau8','" + MaDe + "'";
            labCau8.Text = con.Cmd.ExecuteScalar().ToString();
            //cau 9
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau9','" + MaDe + "'";
            labCau9.Text = con.Cmd.ExecuteScalar().ToString();
            //cau10
            con.Cmd.CommandText = "sp_Cau_a_De_b 'Cau10','" + MaDe + "'";
            labCau10.Text = con.Cmd.ExecuteScalar().ToString();

            //buoc 4 : lay tung dap an cua tung cau ra

            //dap an cau 1
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau1','" + MaDe + "'");
            DapAnACau1.Text = dt.Rows[0]["NDDA"].ToString();
            DapAnbCau1.Text = dt.Rows[1]["NDDA"].ToString();
            DapAncCau1.Text = dt.Rows[2]["NDDA"].ToString();
            DapAnDCau1.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 2
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau2','" + MaDe + "'");
            DapAnACau2.Text = dt.Rows[0]["NDDA"].ToString();
            DapAnbCau2.Text = dt.Rows[1]["NDDA"].ToString();
            DapAncCau2.Text = dt.Rows[2]["NDDA"].ToString();
            DapAnDCau2.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 3
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau3','" + MaDe + "'");
            DapAnACau3.Text = dt.Rows[0]["NDDA"].ToString();
            DapAnbCau3.Text = dt.Rows[1]["NDDA"].ToString();
            DapAncCau3.Text = dt.Rows[2]["NDDA"].ToString();
            DapAnDCau3.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 4
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau4','" + MaDe + "'");
            DapAnACau4.Text = dt.Rows[0]["NDDA"].ToString();
            DapAnbCau4.Text = dt.Rows[1]["NDDA"].ToString();
            DapAncCau4.Text = dt.Rows[2]["NDDA"].ToString();
            DapAnDCau4.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 5
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau5','" + MaDe + "'");
            DapAnACau5.Text = dt.Rows[0]["NDDA"].ToString();
            DapAnbCau5.Text = dt.Rows[1]["NDDA"].ToString();
            DapAncCau5.Text = dt.Rows[2]["NDDA"].ToString();
            DapAnDCau5.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 6
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau6','" + MaDe + "'");
            DaAnACau6.Text = dt.Rows[0]["NDDA"].ToString();
            DaAnBCau6.Text = dt.Rows[1]["NDDA"].ToString();
            DaAnCCau6.Text = dt.Rows[2]["NDDA"].ToString();
            DaAnDCau6.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 7
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau7','" + MaDe + "'");
            DaAnACau7.Text = dt.Rows[0]["NDDA"].ToString();
            DaAnBCau7.Text = dt.Rows[1]["NDDA"].ToString();
            DaAnCCau7.Text = dt.Rows[2]["NDDA"].ToString();
            DaAnDCau7.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 8
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau8','" + MaDe + "'");
            DaAnACau8.Text = dt.Rows[0]["NDDA"].ToString();
            DaAnBCau8.Text = dt.Rows[1]["NDDA"].ToString();
            DaAnCCau8.Text = dt.Rows[2]["NDDA"].ToString();
            DaAnDCau8.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 9
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau9','" + MaDe + "'");
            DaAnACau9.Text = dt.Rows[0]["NDDA"].ToString();
            DaAnBCau9.Text = dt.Rows[1]["NDDA"].ToString();
            DaAnCCau9.Text = dt.Rows[2]["NDDA"].ToString();
            DaAnDCau9.Text = dt.Rows[3]["NDDA"].ToString();

            //dap an cau 10
            dt = con.GetData("sp_DapAn_Cau_a_De_b 'Cau10','" + MaDe + "'");
            DaAnACau10.Text = dt.Rows[0]["NDDA"].ToString();
            DaAnBCau10.Text = dt.Rows[1]["NDDA"].ToString();
            DaAnCCau10.Text = dt.Rows[2]["NDDA"].ToString();
            DaAnDCau10.Text = dt.Rows[3]["NDDA"].ToString();
            con.CloseConn();

        }
        private void btnLoadDe_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDeThi t = new QuanLyDeThi(tk, mk, quyen);
            t.ShowDialog();
        }

        private void MauDeThi_Load(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}
