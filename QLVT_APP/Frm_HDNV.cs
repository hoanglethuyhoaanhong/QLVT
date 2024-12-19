using DevExpress.XtraLayout.Customization;
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
    public partial class Frm_HDNV : Form
    {
        DataTable dt = new DataTable();
        public Frm_HDNV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_HDNV_Load(object sender, EventArgs e)
        {
            de_ngayBD.Text = DateTime.Now.ToString();
            de_ngayKT.Text = DateTime.Now.ToString();
            dt = Program.ExecSqlDataTable("SELECT * FROM VIEW_NHANVIEN");
            cmb_nhanVien.DataSource = dt;
            cmb_nhanVien.DisplayMember = "MANV";
            cmb_nhanVien.ValueMember = "MANV";
            cmb_nhanVien.SelectedIndex = 0;
        }

        private void btn_Preview_Click(object sender, EventArgs e)
        {

            int manv = 0;
            string ngay1, ngay2, type = "NHAP";
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
            manv = Convert.ToInt32(cmb_nhanVien.SelectedValue);
            //if (cmb_nhanVien.SelectedIndex.Equals("Nhập"))
            //{
            //    type = "NHAP";
            //}
            //else
            //{
            //    type = "XUAT";
            //}
            Rpt_HDNV rp = new Rpt_HDNV(manv, ngay1, ngay2);
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void cmb_nhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmb_nhanVien.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                // Lấy giá trị Ho và Ten từ DataRowView
                string ho = selectedRow["Ho"].ToString();
                string ten = selectedRow["Ten"].ToString();

                // Hiển thị vào TextBox
                tb_name.Text = $"{ho} {ten}";
            }
        }
    }
}
