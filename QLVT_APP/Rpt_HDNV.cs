using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QLVT_APP
{
    public partial class Rpt_HDNV : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpt_HDNV(int manv, string ngaybd, string ngaykt)
        {
            try
            {
                InitializeComponent();
                this.sqlDataSource1.Queries[0].Parameters[0].Value = manv;
                this.sqlDataSource1.Queries[0].Parameters[1].Value = ngaybd;
                this.sqlDataSource1.Queries[0].Parameters[2].Value = ngaykt;
                this.sqlDataSource1.Fill();
                String sql = $"SELECT * FROM dbo.NhanVien AS n WHERE n.MaNV = {manv};" ;
                SqlDataReader myRender = Program.ExecSqlDataReader(sql);
                myRender.Read();
                lb_manv.Text = myRender.GetInt32(0).ToString();
                lb_ten.Text = myRender.GetString(1)+" "+ myRender.GetString(2);
                lb_dc.Text = myRender.GetString(3);
                lb_sdt.Text = myRender.GetString(4);
                lb_ns.Text = myRender.GetDateTime(5).ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Hiển thị dữ liệu không thành công vui lòng kiểm tra thông tin nhân viên!\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
