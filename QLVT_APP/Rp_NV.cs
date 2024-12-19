using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_APP
{
    public partial class Rp_NV : DevExpress.XtraReports.UI.XtraReport
    {
        public Rp_NV(int type)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = type;
            this.sqlDataSource1.Fill();
        }

    }
}
