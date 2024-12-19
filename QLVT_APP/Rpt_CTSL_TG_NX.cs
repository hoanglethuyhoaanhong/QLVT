using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_APP
{
    public partial class Rpt_CTSL_TG_NX : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpt_CTSL_TG_NX(string role, string type, string ngaybd, string ngaykt)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = role;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = type;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ngaybd;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = ngaykt;
            this.sqlDataSource1.Fill();
        }

    }
}
