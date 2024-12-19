using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_APP
{
    public partial class Frm_ViewNV : Form
    {
        Int32 type = 0;
        public Frm_ViewNV()
        {
            InitializeComponent();
        }

        private void cmb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_chiNhanh.SelectedIndex == Program.mChiNhanh)
            {
                type = 0;
            }
            else
            {
                type = 1;
            }
        }

        private void Frm_ViewNV_Load(object sender, EventArgs e)
        {
            cmb_chiNhanh.DataSource = Program.bds_dspm;
            cmb_chiNhanh.DisplayMember = "TENCN";
            cmb_chiNhanh.ValueMember = "TENSERVER";
            cmb_chiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup.Equals("CHINHANH"))
            {
                cmb_chiNhanh.Enabled = false;
            }else
            {
                cmb_chiNhanh.Enabled = true;
            }
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            Rp_NV rp = new Rp_NV(type);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }
    }
}
