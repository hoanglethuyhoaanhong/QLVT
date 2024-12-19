using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.XtraBars;
using QLVT_APP.Constrains;
using System;
using System.Collections;
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
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        Stack undolist = new Stack();
        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
            if (!Program.mGroup.Equals("CHINHANH"))
            {
                add.Enabled = false;
                save.Enabled = false;
                exit.Enabled = false;
                remove.Enabled = false;
            }
            undo.Enabled = save.Enabled = exit.Enabled = false;
        }

        private void add_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControl_edit.Enabled = true;
            sp_MaKho.Text = TE_tenKho.Text = TE_DC.Text = "";
            string chinhanh;
            if (Program.mChiNhanh == 0)
            {
                chinhanh = "CN1       ";
            }
            else
            {
                chinhanh = "CN2       ";
            }
            TE_maCN.Text = chinhanh;
            groupControl_Kho.Enabled = false;
            add.Enabled = false;
            remove.Enabled = false;
            save.Enabled = true;
            exit.Enabled = true;
            TE_tenKho.Focus();
        }

        private void exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            khoBindingSource.RemoveCurrent();
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            groupControl_edit.Enabled = false;
            groupControl_Kho.Enabled = true;
            this.khoGridControl.Enabled = true;
            add.Enabled  = remove.Enabled = true;
            save.Enabled = exit.Enabled = false;
        }

        private void remove_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            if (khoBindingSource.Count == 0)
            {
                MessageBox.Show("Không có kho để xóa!", "Thông báo", MessageBoxButtons.OK);
                remove.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        string MaKho = ((DataRowView)khoBindingSource[khoBindingSource.Position])["MaKho"].ToString();
                        String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKKho] " +
                               "@MAKHO = " + MaKho + " " +
                               "SELECT 'Return Value' = @return_value";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenhSDT);
                        dataReader.Read();
                        
                        result = dataReader.GetInt32(0);
                        dataReader.Close();
                        Program.conn.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Kho này đã được sử dụng, không thể xóa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        String info = TE_tenKho.Text.Trim() + "#" + TE_DC.Text.Trim() + "#" +  TE_maCN.Text;

                        khoBindingSource.RemoveCurrent();
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.dS.Kho);
                        undo.Enabled = true;
                        undolist.Push(info);
                        undolist.Push("DELETE");
                        this.khoTableAdapter.Fill(this.dS.Kho);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Xóa Kho thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

		private void save_ItemClick(object sender, ItemClickEventArgs e)
		{
			string strLenh;
			SqlDataReader dataReader = null;
            int maKho = 0;
			int result;
            try
            {
				TextEditConstrain test = new TextEditConstrain();
				if (test.CheckLength(TE_tenKho.Text, 30))
				{
					MessageBox.Show("Tên hàng hóa không được trống, hoặc dài quá 30 kí tự!", "Lỗi", MessageBoxButtons.OK);
					TE_tenKho.Focus();
					return;
				}
				if (test.CheckLength(TE_DC.Text, 100))
				{
					MessageBox.Show("Tên hàng hóa không được trống, hoặc dài quá 100 kí tự!", "Lỗi", MessageBoxButtons.OK);
					TE_DC.Focus();
					return;
				}
				DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
					  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
					//check
					String strLenhSDT = "DECLARE @return_value int " +
						   "EXEC @return_value = [dbo].[SP_CHECKTENKHO]" +
						   "@TENKHO = '" + TE_tenKho.Text.Trim() + "' " +
						   "SELECT 'Return Value' = @return_value";
					dataReader = null;
					dataReader = Program.ExecSqlDataReader(strLenhSDT);
					dataReader.Read();
					result = dataReader.GetInt32(0);
					dataReader.Close();
					if (result == 1)
					{
						MessageBox.Show("Tên kho đã bị trùng!", "Thông báo",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
						TE_tenKho.Focus();
						return;
					}
					//insert
					strLenh = $"INSERT [dbo].[Kho] ([TenKho], [DiaChi], [MaCN]) " +
						$"VALUES (N'{TE_tenKho.Text}', N'{TE_DC.Text}', N'{TE_maCN.Text}'); " +
                        $"SELECT SCOPE_IDENTITY();";
					dataReader = null;
					dataReader = Program.ExecSqlDataReader(strLenh);
					dataReader.Read();
					maKho = Convert.ToInt32(dataReader[0]);
					dataReader.Close();
					undo.Enabled = true;
					undolist.Push(maKho.ToString());
					undolist.Push("INSERT");
					this.khoTableAdapter.Fill(this.dS.Kho);
					groupControl_edit.Enabled = false;
					groupControl_Kho.Enabled = true;
					add.Enabled = remove.Enabled = true;
					save.Enabled = exit.Enabled = false;
					khoGridControl.Enabled = true;
					MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					khoBindingSource.Position = khoBindingSource.Find("MaKho", maKho.ToString());
				}
			}
			catch (Exception ex) 
            {
				MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin Hàng hóa!\n" + ex.Message,
								"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void undo_ItemClick(object sender, ItemClickEventArgs e)
		{
			string strLenh;
			SqlDataReader dataReader = null;
			int maKho = 0;
			int result;
			if (undolist.Count > 0)
            {
				String statement = undolist.Pop().ToString();
				switch (statement)
                {
                    case "DELETE":
						String TT = undolist.Pop().ToString();
						String[] TT_Kho = TT.Split('#'); // tên Kho # địa chỉ # mã chi nhánh

						try
						{
							//check
							String strLenhSDT = "DECLARE @return_value int " +
								   "EXEC @return_value = [dbo].[SP_CHECKTENKHO]" +
								   "@TENKHO = '" + TT_Kho[0] + "' " +
								   "SELECT 'Return Value' = @return_value";
							dataReader = null;
							dataReader = Program.ExecSqlDataReader(strLenhSDT);
							dataReader.Read();
							result = dataReader.GetInt32(0);
							dataReader.Close();
							if (result == 1)
							{
								MessageBox.Show("Tên kho đã bị trùng!", "Thông báo",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
								TE_tenKho.Focus();
								return;
							}
							//insert
							strLenh = $"INSERT [dbo].[Kho] ([TenKho], [DiaChi], [MaCN]) " +
								$"VALUES (N'{TT_Kho[0]}', N'{TT_Kho[1]}', N'{TT_Kho[2]}'); " +
								$"SELECT SCOPE_IDENTITY();";
							dataReader = null;
							dataReader = Program.ExecSqlDataReader(strLenh);
							dataReader.Read();
							maKho = Convert.ToInt32(dataReader[0]);
							dataReader.Close();
							this.khoTableAdapter.Fill(this.dS.Kho);
							khoBindingSource.Position = khoBindingSource.Find("MaKho", maKho.ToString());
						}
						catch (Exception ex)
						{
							MessageBox.Show("Hoàn tác Xóa kho thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						break;
                    case "INSERT":
						String MaKho = undolist.Pop().ToString();
						try
						{
							String strLenhSDT = "DECLARE @return_value int " +
							   "EXEC @return_value = [dbo].[SP_CHECKKho] " +
							   "@MAKHO = " + MaKho + " " +
							   "SELECT 'Return Value' = @return_value";
							dataReader = null;
							dataReader = Program.ExecSqlDataReader(strLenhSDT);
							dataReader.Read();
							result = dataReader.GetInt32(0);
							dataReader.Close();
							if (result == 1)
							{
								MessageBox.Show("Kho này đã được sử dụng, không thể xóa!", "Thông báo",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							int vitri = khoBindingSource.Find("MaKho", MaKho);
							khoBindingSource.Position = vitri;
							khoBindingSource.RemoveCurrent();
							this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
							this.khoTableAdapter.Update(this.dS.Kho);
							this.khoTableAdapter.Fill(this.dS.Kho);
						}
						catch (Exception ex)
						{
							MessageBox.Show("Hoàn tác Them kho thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
						break;
                    default:
						MessageBox.Show("Hoàn tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
                }

			}
			if (undolist.Count == 0)
			{
				undo.Enabled = false;
			}
		}
	}
}