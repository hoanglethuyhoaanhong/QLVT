using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QLVT_APP
{
    public partial class Rpt_TongHopNX : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpt_TongHopNX(string ngaybd, string ngaykt)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ngaybd;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ngaykt;
            this.sqlDataSource1.Fill();
            lb_bd.Text = "Từ: " + ngaybd;
            lb_kt.Text = "Đến" + ngaykt;
        }

    }
}
