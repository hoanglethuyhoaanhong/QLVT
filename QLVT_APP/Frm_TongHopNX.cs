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
    public partial class Frm_TongHopNX : Form
    {
        public Frm_TongHopNX()
        {
            InitializeComponent();
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {
            string ngay1, ngay2;
            ngay1 = de_ngayBD.Text;
            ngay2 = de_ngayKT.Text;
            if (ngay1.Length == 0 || ngay2.Length == 0)
            {
                MessageBox.Show("Không được để trống ngày sao kê\n Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var parsedDate1 = DateTime.Parse(ngay1);
            var parsedDate2 = DateTime.Parse(ngay2);

            int result = DateTime.Compare(parsedDate1, parsedDate2);

            if (result > 0)
            {
                MessageBox.Show("Ngày không hợp lệ!\n Vui lòng chọn lại ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            
            Rpt_TongHopNX rp = new Rpt_TongHopNX(ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void Frm_TongHopNX_Load(object sender, EventArgs e)
        {
            de_ngayBD.Text = DateTime.Now.ToString();
            de_ngayKT.Text = DateTime.Now.ToString();
        }
    }
}
