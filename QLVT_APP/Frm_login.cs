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

namespace QLVT_APP
{
    public partial class Frm_login : Form
    {
        private SqlConnection conn_publisher = new SqlConnection();
        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmb_chiNhanh.DataSource = dt;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
        }
        public Frm_login()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối vào dữ liệu gốc", "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void btn_dangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmb_chiNhanh.SelectedValue.ToString();
            }
            catch (Exception) { }
        }

        private void cb_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_pass.Checked)
            {
                this.txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                this.txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_dangNhap_Click_1(object sender, EventArgs e)
        {
            if (txt_user.Text.Trim() == "" || txt_pass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txt_user.Text; Program.password = txt_pass.Text;
            try
            {
                if (Program.KetNoi() == 0) return;
                Program.mChiNhanh = cmb_chiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                string strLenh;
                if (checkBox1.Checked) strLenh = "EXEC SP_DANGNHAPKH '" + Program.mlogin + "'";
                else strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
				string chinhanh;
				if (Program.mChiNhanh == 0)
				{
					chinhanh = "CN1       ";
				}
				else
				{
					chinhanh = "CN2       ";
				}
                string this_CN = Program.myReader.GetString(0);
                if (!this_CN.Equals(chinhanh))
                {
					MessageBox.Show("Login bạn nhập không có quyền truy trong chi nhánh này", "", MessageBoxButtons.OK);
					return;
				}
				int TrangThai = Program.myReader.GetInt32(1);
                if (TrangThai == 1)
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Nhân Viên đã bị Xóa", "", MessageBoxButtons.OK);
                    return;
                }
                Program.username = Program.myReader.GetString(2);     // Lay user name
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }

                Program.mHoTen = Program.myReader.GetString(3);
                Program.mGroup = Program.myReader.GetString(4);
                Program.myReader.Close();
                Program.conn.Close();
                Program.formChinh.hienThongTinStatus();
                if (checkBox1.Checked) MessageBox.Show("Khách Hàng - Nhóm : " + Program.mHoTen + " - " + Program.mGroup, "", MessageBoxButtons.OK);
                else MessageBox.Show("Nhân viên - Nhóm : " + Program.mHoTen + " - " + Program.mGroup, "", MessageBoxButtons.OK);

            }
            catch (Exception)
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại quyền truy cập", "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            if (KetNoi_CSDLGOC() == 0) return;
            LayDSPM("SELECT * FROM V_DS_PHANMANH");
            cmb_chiNhanh.SelectedIndex = 1; cmb_chiNhanh.SelectedIndex = 0;
        }
        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            this.txt_pass.Text = "";
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            this.txt_pass.Text = "";
        }
    }
}
