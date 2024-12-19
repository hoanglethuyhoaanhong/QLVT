using System;
using DevExpress.XtraBars;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLVT_APP
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Frm_login f_dangNhap;
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        public void hienThongTinStatus()
        {
            MANV.Text = "MaNV: " + Program.username;
            HOTEN.Text = "TenNV: " + Program.mHoTen;
            NHOM.Text = "Nhom: " + Program.mGroup;

            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
        }
        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mGroup != "")
            {
                MessageBox.Show("Bạn chưa đăng xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Form frm_dangNhap = this.CheckExists(typeof(Frm_login));
            if (frm_dangNhap != null)
                frm_dangNhap.Close();
            Form frm = this.CheckExists(typeof(Frm_login));
            if (frm != null) frm.Activate();
            else
            {
                f_dangNhap = new Frm_login();
                f_dangNhap.MdiParent = this;
                //f_dangNhap.f_main = this;
                f_dangNhap.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(FormVatTu));
            if (form != null) form.Activate();
            else
            {
                FormVatTu f = new FormVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(FormNhanVien));
            if (form != null) form.Activate();
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

		private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (Program.mHoTen.Trim().Length == 0 || Program.mGroup.Trim().Length == 0)
			{
				MessageBox.Show("Bạn chưa đăng nhập!", "Lỗi", MessageBoxButtons.OK);
				return;
			}
			Program.myReader = null;
			Program.username = "";
			Program.mlogin = "";
			Program.password = "";
			Program.mloginDN = "";
			Program.passwordDN = "";
			Program.mGroup = "";
			Program.mHoTen = "";
			Program.mChiNhanh = 0;
			FormMain f1 = new FormMain();
			f1.hienThongTinStatus();
			MANV.Text = "MaNV: ";
			HOTEN.Text = "TenNV: ";
			NHOM.Text = "Nhom: ";
			MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK);
			return;
		}

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(FormKho));
            if (form != null) form.Activate();
            else
            {
                FormKho f = new FormKho();
                f.MdiParent = this;
                f.Show();
            }
        }

		private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
			{
				MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
				return;
			}
			Form form = this.CheckExists(typeof(FormDDH));
			if (form != null) form.Activate();
			else
			{
				FormDDH f = new FormDDH();
				f.MdiParent = this;
				f.Show();
			}
		}

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rpt_HangHoa rp = new Rpt_HangHoa();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Rpt_DDH_KPN rp = new Rpt_DDH_KPN();
            ReportPrintTool print = new ReportPrintTool(rp);
            print.ShowPreviewDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Frm_ViewNV));
            if (form != null) form.Activate();
            else
            {
                Frm_ViewNV f = new Frm_ViewNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Frm_CTSL_TG_NX));
            if (form != null) form.Activate();
            else
            {
                Frm_CTSL_TG_NX f = new Frm_CTSL_TG_NX();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTaoTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Form_TaoTK));
            if (form != null) form.Activate();
            else
            {
                Form_TaoTK f = new Form_TaoTK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Form_KH));
            if (form != null) form.Activate();
            else
            {
                Form_KH f = new Form_KH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Form_NCC));
            if (form != null) form.Activate();
            else
            {
                Form_NCC f = new Form_NCC();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Frm_TongHopNX));
            if (form != null) form.Activate();
            else
            {
                Frm_TongHopNX f = new Frm_TongHopNX();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Program.mHoTen.Equals("") || Program.mGroup.Equals(""))
            {
                MessageBox.Show("Vui lòng đăng nhập trước!", "Lỗi!", MessageBoxButtons.OK);
                return;
            }
            Form form = this.CheckExists(typeof(Frm_HDNV));
            if (form != null) form.Activate();
            else
            {
                Frm_HDNV f = new Frm_HDNV();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
