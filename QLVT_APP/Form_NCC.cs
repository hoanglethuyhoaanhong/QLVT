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
    public partial class Form_NCC : DevExpress.XtraEditors.XtraForm
    {
        public Form_NCC()
        {
            InitializeComponent();
        }

        private void nhaCungCapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhaCungCapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Form_NCC_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaCungCapTableAdapter.Fill(this.dS.NhaCungCap);
            if (nhaCungCapBindingSource.Count == 0) remove.Enabled = false;
            save.Enabled = false;
        }

        private void add_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControl_edit.Enabled = true;
            groupControl_NCC.Enabled = false;
            add.Enabled = false;
            save.Enabled = true;
            nhaCungCapBindingSource.AddNew();
            tenNCCTextEdit.Focus();
        }

        private void remove_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            if (MessageBox.Show("Bạn có thật sự muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mancc = ((DataRowView)nhaCungCapBindingSource[nhaCungCapBindingSource.Position])["MaNCC"].ToString();
                strLenh = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKXOANCC] " +
                               "@MANCC = " + mancc + " " +
                               "SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenh);
                dataReader.Read();
                result = dataReader.GetInt32(0);
                dataReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Nhà cung cấp này đã từng cấp hàng, không thể xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    nhaCungCapBindingSource.RemoveCurrent();
                    this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhaCungCapTableAdapter.Update(this.dS.NhaCungCap);
                    this.nhaCungCapTableAdapter.Fill(this.dS.NhaCungCap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khách hàng. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.nhaCungCapTableAdapter.Fill(this.dS.NhaCungCap);
                    nhaCungCapBindingSource.Position = nhaCungCapBindingSource.Find("MaNCC", mancc);
                    return;
                }
            }
            if (nhaCungCapBindingSource.Count == 0)
                remove.Enabled = false;
        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int resultSDT;
            TextEditConstrain test = new TextEditConstrain();
            if (test.CheckLength(tenNCCTextEdit.Text, 40))
            {
                MessageBox.Show("Họ Nhà cung cấp không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
                tenNCCTextEdit.Focus();
                return;
            }
            if (test.CheckName(tenNCCTextEdit.Text.Trim()))
            {
                MessageBox.Show("Nhập sai định dạng họ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tenNCCTextEdit.Focus();
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
                               "EXEC @return_value = [dbo].[SP_CHECKSDTNCC] " +
                              " @SDT = '" + sdt + "' " +
                               "SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenhSDT);
                dataReader.Read();
                resultSDT = dataReader.GetInt32(0);
                dataReader.Close();
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
                    nhaCungCapBindingSource.EndEdit();
                    this.nhaCungCapTableAdapter.Update(this.dS.NhaCungCap);
                    this.nhaCungCapTableAdapter.Fill(this.dS.NhaCungCap);
                    nhaCungCapBindingSource.Position = nhaCungCapBindingSource.Find("SDT", sdt);
                    groupControl_edit.Enabled = false;
                    groupControl_NCC.Enabled = true;
                    remove.Enabled = add.Enabled = true;
                    save.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi khách hàng\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}