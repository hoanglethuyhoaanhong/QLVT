using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLVT_APP
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr; // biến dùng để kết nối tải dữ liệu về thông qua tableadapter.
        public static String connstr_publisher = "Data Source=DESKTOP-3SHLE4Q;Initial Catalog=QLVT; Integrated Security=True;TrustServerCertificate=True";

        public static SqlDataReader myReader;
        public static String servername = "";// Lưu thông tin server đang kết nối tới
        public static String username = "";// Lưu thông tin username 
        public static String mlogin = ""; // Lưu thông tin login
        public static String password = "";// Lưu thông tin password
        public static String database = "QLVT";// tên db
        public static String remotelogin = "HTKN";// login để kết nối qua site khác
        public static String remotepassword = "123";// mật khẩu để kết nối qua site khác
        public static String mloginDN = "HTKN";
        public static String passwordDN = "123";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static int mChiNhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();
        public static FormMain formChinh;

        /// </summary>
        /// 
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password + ";TrustServerCertificate=True";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Open) conn.Close();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formChinh = new FormMain();
            Application.Run(formChinh);
        }
    }
}
