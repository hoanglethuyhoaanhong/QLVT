using DevExpress.XtraBars;
using QLVT_APP.Constrains;
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
    public partial class Form_KH : DevExpress.XtraEditors.XtraForm
    {
        public Form_KH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Form_KH_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.dS.KhachHang);
            if(khachHangBindingSource.Count==0) remove.Enabled = false;
            save.Enabled = false;
        }

        private void add_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControl_edit.Enabled = true;
            groupControl_KH.Enabled = false;
            add.Enabled = false;
            save.Enabled = true;
            khachHangBindingSource.AddNew();
            string chinhanh;
            if (Program.mChiNhanh == 0)
            {
                chinhanh = "CN1       ";
            }
            else
            {
                chinhanh = "CN2       ";
            }
            maCNTextEdit.Text = chinhanh;
            hoTextEdit.Focus();
        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int resultSDT;
            TextEditConstrain test = new TextEditConstrain();
            if (test.CheckLength(hoTextEdit.Text, 40))
            {
                MessageBox.Show("Họ khách hàng không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
                hoTextEdit.Focus();
                return;
            }
            if (test.CheckName(hoTextEdit.Text.Trim()))
            {
                MessageBox.Show("Nhập sai định dạng họ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hoTextEdit.Focus();
                return;
            }
            if (test.CheckLength(tenTextEdit.Text, 40))
            {
                MessageBox.Show("Tên khách hàng không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
                tenTextEdit.Focus();
                return;
            }
            if (test.CheckName(tenTextEdit.Text.Trim()))
            {
                MessageBox.Show("Nhập sai định dạng tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tenTextEdit.Focus();
                return;
            }
            if (test.CheckDC(diaChiTextEdit.Text.Trim()))
            {
                MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
                diaChiTextEdit.Focus();
                return;
            }
            if (test.CheckLength(sDTTextEdit.Text, 15))
            {
                MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sDTTextEdit.Focus();
                return;
            }
            if (test.CheckSDT(sDTTextEdit.Text.Trim()))
            {
                MessageBox.Show("Nhập sai định dạng SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sDTTextEdit.Focus();
                return;
            }
            try
            {
                String sdt = sDTTextEdit.Text.Trim();
                /// Check SDT
				String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKSDTKH] " +
                              " @SDT = '" + sdt + "' " +
                               "SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenhSDT);
                dataReader.Read();
                resultSDT = dataReader.GetInt32(0);
                dataReader.Close();
                Program.conn.Close();
                if (resultSDT == 1)
                {
                    MessageBox.Show("Số Điện thoại đã bị trùng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sDTTextEdit.Focus();
                    return;
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    String lgname = "KH" + sdt;
                    strLenh = "EXEC [SP_TAOACCOUNT] " +
                                "@LGNAME = " + lgname + " , @PASS = " +
                                sdt + ", @USERNAME = " + sdt + " , @ROLE = 'USER' ";
                    Program.ExecSqlNonQuery(strLenh);
                    khachHangBindingSource.EndEdit();
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    khachHangBindingSource.Position = khachHangBindingSource.Find("SDT", sdt);
                    groupControl_edit.Enabled = false;
                    groupControl_KH.Enabled = true;
                    remove.Enabled = add.Enabled = true;
                    save.Enabled = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hàng\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void remove_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string makh = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["MaKH"].ToString();
                strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKXOAKH] " +
                               "@MAKH = " + makh + " " +
                               "SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                dataReader.Read();
                result = dataReader.GetInt32(0);
                dataReader.Close();
                Program.conn.Close();
                if (result == 1)
                {
                    MessageBox.Show("Khách hàng này đã từng đặt hàng, không thể xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    khachHangBindingSource.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Update(this.dS.KhachHang);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.dS.KhachHang);
                    khachHangBindingSource.Position = khachHangBindingSource.Find("MaKH", makh);
                    return;
                }
            }
            if (khachHangBindingSource.Count == 0)
                remove.Enabled = false;
        }
    }
}