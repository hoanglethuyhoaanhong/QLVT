using DevExpress.XtraBars;
using DevExpress.XtraLayout.Filtering.Templates;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.FindSearchRichParser;

namespace QLVT_APP
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
		private Boolean isSua = false;
		string NV_info = "";
		Stack undolist = new Stack();
		String CN = "";
		private void xoa_nhan_vien(string maNV)
		{
			try
			{
				DateTime NOW = DateTime.Now;
				string lenh = "update [dbo].[NhanVien] set TrangThaiXoa = 1 where MaNV = " + maNV + ";" +
					$"update [dbo].[CT_NhanVien] set [NgayKetThuc] = N'{NOW:yyyy-MM-dd}' where MaNV = " + maNV + ";";
				Program.ExecSqlNonQuery(lenh);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		public FormNhanVien()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
			String trangThaiXoa;
			trangThaiXoa = ((DataRowView)bds_nv[bds_nv.Position])["TrangThaiXoa"].ToString();
			if (trangThaiXoa == "1")
			{
				MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			isSua = true;
			TE_maNV.Enabled = false;
			groupControl_edit.Enabled = true;
			vIEW_NHANVIENGridControl.Enabled = false;
			bar_btn_add.Enabled = bar_btn_update.Enabled = bar_btn_remove.Enabled = bar_btn_refresh.Enabled = bar_btn_ccn.Enabled = false;
			bar_btn_save.Enabled = bar_btn_exit.Enabled = true;
		}

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.dS.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'dS.VIEW_NHANVIEN' table. You can move, or remove it, as needed.
                this.vIEW_NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
				// TODO: This line of code loads data into the 'dS.CT_NhanVien' table. You can move, or remove it, as needed.
				this.cT_NhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
				this.cT_NhanVienTableAdapter.Fill(this.dS.CT_NhanVien);
				// TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
				this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
				this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

				if (!Program.mGroup.Equals("CHINHANH"))
				{
					bar_btn_add.Enabled = false;
					bar_btn_update.Enabled = false;
					bar_btn_save.Enabled = false;
					bar_btn_exit.Enabled = false;
					bar_btn_undo.Enabled = false;
					bar_btn_remove.Enabled = false;
					bar_btn_ccn.Enabled = false;
				}
				bar_btn_save.Enabled = bar_btn_exit.Enabled = bar_btn_refresh.Enabled = false;
				if (bds_nv.Count == 0)
				{
					bar_btn_remove.Enabled = false;
				}
			}
            catch
            {
                MessageBox.Show("Tải dữ liệu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void textEdit5_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
		{
			string maNV = "";
			String trangThaiXoa;
			trangThaiXoa = ((DataRowView)bds_nv[bds_nv.Position])["TrangThaiXoa"].ToString();

			if (trangThaiXoa == "1")
			{
				MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK);
				return;
			}
			if (bds_nv.Count == 0)
			{
				MessageBox.Show("Không có nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK);
				bar_btn_remove.Enabled = false;
			}
			else
			{
				if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					try
					{
						maNV = ((DataRowView)bds_nv[bds_nv.Position])["MANV"].ToString();
						if (maNV.Equals(Program.username))
						{
							MessageBox.Show("Không thể xóa chính mình!", "Thông báo", MessageBoxButtons.OK);
							return;
						}
						String NV_info = maNV.ToString();
						//bds_nv.RemoveCurrent();
						xoa_nhan_vien(maNV);
						bar_btn_undo.Enabled = true;
						undolist.Push(NV_info);
						undolist.Push("DELETE");
						this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
						this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Lỗi xóa nhân viên. Hãy xóa lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
						bds_nv.Position = bds_nv.Find("MANV", maNV);
						return;
					}
				}
				}
			}

		private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
		{
			try
			{
				this.vIEW_NHANVIENTableAdapter.Fill(dS.VIEW_NHANVIEN);
				this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
				this.nhanVienTableAdapter.Update(this.dS.NhanVien);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void bar_btn_add_ItemClick(object sender, ItemClickEventArgs e)
		{
			groupControl_edit.Enabled = true;
			TE_maNV.Text = TE_DC.Text = TE_ho.Text = TE_ten.Text = TE_SDT.Text = "";
			groupControl_nv.Enabled = false;
			bar_btn_add.Enabled = false;
			bar_btn_update.Enabled = false;
			bar_btn_remove.Enabled = false;
			bar_btn_save.Enabled = true;
			bar_btn_exit.Enabled = true;
			bar_btn_refresh.Enabled = false;
			bar_btn_ccn.Enabled = false;
			DE_NBD.EditValue = DateTime.Now;
			DE_NS.EditValue = DateTime.Now;
			CK_TTX.Checked = true;
			CK_TTX.Enabled = false;
			TE_maNV.Focus();
			
		}

		private void bar_btn_exit_ItemClick(object sender, ItemClickEventArgs e)
		{
			bds_nv.RemoveCurrent();
			this.vIEW_NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
			this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
			this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
			this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
			groupControl_edit.Enabled = false;
			groupControl_nv.Enabled = true;
			this.vIEW_NHANVIENGridControl.Enabled = true;	
			bar_btn_add.Enabled = bar_btn_update.Enabled = bar_btn_remove.Enabled = bar_btn_refresh.Enabled = bar_btn_ccn.Enabled = true;
			bar_btn_save.Enabled = bar_btn_exit.Enabled = false;
		}

		private void bar_btn_save_ItemClick(object sender, ItemClickEventArgs e)
		{
			string strLenh;
			SqlDataReader dataReader = null;
			int result, resultSDT;
			TextEditConstrain test = new TextEditConstrain();
			if (test.CheckLength(TE_ho.Text, 40))
			{
				MessageBox.Show("Họ nhân viên không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
				TE_ho.Focus();
				return;
			}
			if (test.CheckName(TE_ho.Text.Trim()))
			{
				MessageBox.Show("Nhập sai định dạng họ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TE_ho.Focus();
				return;
			}
			if (test.CheckLength(TE_ten.Text, 40))
			{
				MessageBox.Show("Tên nhân viên không được trống, hoặc dài quá 40 kí tự!", "Lỗi", MessageBoxButtons.OK);
				TE_ten.Focus();
				return;
			}
			if (test.CheckName(TE_ten.Text.Trim()))
			{
				MessageBox.Show("Nhập sai định dạng tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TE_ten.Focus();
				return;
			}
			if (test.CheckDC(TE_DC.Text.Trim()))
			{
				MessageBox.Show("Địa chỉ không được trống!", "Lỗi", MessageBoxButtons.OK);
				TE_DC.Focus();
				return;
			}
			if (test.CheckLength(TE_SDT.Text, 15))
			{
				MessageBox.Show("Số điện thoại không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TE_SDT.Focus();
				return;
			}
			if (test.CheckSDT(TE_SDT.Text.Trim()))
			{
				MessageBox.Show("Nhập sai định dạng SĐT!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				TE_SDT.Focus();
				return;
			}
			try
			{
				/// Check SDT
				String strLenhSDT = "DECLARE @return_value int " +
							   "EXEC @return_value = [dbo].[SP_CHECKSDTNV] " +
							   "@MANV = '" + TE_maNV.Text.Trim() + "' , @SDT = '" +
							   TE_SDT.Text.Trim() + "' " +
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
					TE_SDT.Focus();
					return;
				}
				///// Ghi dữ liệu
				DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
					  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (dr == DialogResult.OK)
				{
					int maNV = 0;
					if (!isSua)
					{
						string chinhanh;
						if (Program.mChiNhanh == 0)
						{
							chinhanh = "CN1       ";
						}
						else
						{
							chinhanh = "CN2       ";
						}
						DateTime ngaySinh = DE_NS.DateTime;
                        strLenh = "DECLARE @return_value int " + $"EXEC  @return_value = SP_CREATENV @HO = N'{TE_ho.Text}', @TEN = N'{TE_ten.Text}', " +
							$"@DIACHI = N'{TE_DC.Text}', @SDT = N'{TE_SDT.Text}', @NS = N'{ngaySinh:yyyy-MM-dd}', " +
							$"@CN = N'{chinhanh}' SELECT 'Return Value' = @return_value";
                        dataReader = null;
						dataReader = Program.ExecSqlDataReader(strLenh);
						dataReader.Read();

						maNV = dataReader.GetInt32(0);
						dataReader.Close();

						DateTime NOW = DateTime.Now;
						strLenh = $"INSERT [dbo].[CT_NhanVien] ([MaCN], [MaNV], [NgayBatDau], [NgayKetThuc])  " +
							$"VALUES (N'{chinhanh}', {maNV}, N'{NOW:yyyy-MM-dd}', NULL);";
						bar_btn_undo.Enabled = true;
						undolist.Push(maNV.ToString());
						undolist.Push("INSERT");
					}
					else
					{
						DateTime ngaySinh = DE_NS.DateTime;
						string lenh = $"update [dbo].[NhanVien] set Ho = N'{TE_ho.Text}', Ten = N'{TE_ten.Text.Trim()}', " +
							$"[DiaChi] = N'{TE_DC.Text.Trim()}', [SÐT] = N'{TE_SDT.Text.Trim()}', [NgaySinh] = N'{ngaySinh:yyyy-MM-dd}'" +
							$" where MaNV = " + TE_maNV.Text + ";";
						dataReader = null;
						dataReader = Program.ExecSqlDataReader(lenh);
						dataReader.Close();
						bar_btn_undo.Enabled = true;
						String NV_info = TE_maNV.Text.Trim() + "#" + TE_ho.Text.Trim() + "#" + TE_ten.Text.Trim() 
							+ "#" + TE_DC.Text.Trim() +"#" + TE_SDT.Text.Trim() + "#" + DE_NS.Text;
						undolist.Push(NV_info);
						undolist.Push("EDIT");
					}
					this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
					groupControl_edit.Enabled = false;
					groupControl_nv.Enabled = true;
					bar_btn_add.Enabled = bar_btn_update.Enabled = bar_btn_remove.Enabled = bar_btn_refresh.Enabled = bar_btn_ccn.Enabled = true;
					bar_btn_save.Enabled = bar_btn_exit.Enabled = false;
					vIEW_NHANVIENGridControl.Enabled = true;
					isSua = false;
					MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					bds_nv.Position = bds_nv.Find("MaNV", maNV.ToString());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin nhân viên!\n" + ex.Message,
								"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void maNVLabel_Click(object sender, EventArgs e)
		{

		}

		private void bar_btn_undo_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (undolist.Count > 0)
			{
				String statement = undolist.Pop().ToString();
				if (statement.Equals("DELETE"))
				{
					String TT = undolist.Pop().ToString();
					String TT_NV = TT;

					try
					{
						string lenh = "update[dbo].[NhanVien] set TrangThaiXoa = 0 where MANV = '" + TT_NV + "'";
						Program.ExecSqlNonQuery(lenh);
						this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
						bds_nv.Position = bds_nv.Find("MANV", TT_NV);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Hủy Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else if (statement.Equals("EDIT"))
				{
					try
					{
						String TT = undolist.Pop().ToString();
						String[] TT_NV = TT.Split('#');

						string lenh = "update[dbo].[NhanVien] set Ho= '" + TT_NV[1] + "',Ten= '" + TT_NV[2] + "',DIACHI= '" + TT_NV[3] +
							"',SODT= '" + TT_NV[4] + "',NgaySinh= N'" + TT_NV[5] + "' where MaNV = '" + TT_NV[0] + "'";
						Program.ExecSqlNonQuery(lenh);
						this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
						bds_nv.Position = bds_nv.Find("MANV", TT_NV[0]);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Lỗi không thể rollback sủa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else if (statement.Equals("INSERT"))
				{
					String maNV = undolist.Pop().ToString();
					try
					{
						string lenh = "DELETE FROM [dbo].[CT_NhanVien] where MANV = '" + maNV + "';" +
							"DELETE FROM [dbo].[NhanVien] where MANV = '" + maNV + "';";
						Program.ExecSqlNonQuery(lenh);
						this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
					}
					catch (Exception ex)
					{
						MessageBox.Show("Hủy Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				else if (statement.Equals("GOTO"))
				{
					String maNV = undolist.Pop().ToString();
					string chinhanh;
					if (Program.mChiNhanh == 0)
					{
						chinhanh = "CN1       ";
					}
					else
					{
						chinhanh = "CN2       ";
					}
					string strLenh = $"EXEC LINK1.[QLVT].[dbo].SP_ChuyenCN @manv = {maNV}, @macngo = N'{chinhanh}'";
					
					Program.ExecSqlNonQuery(strLenh);

					this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
				}
			}
				if (undolist.Count == 0)
			{
				bar_btn_undo.Enabled = false;
			}
		}

		private void vIEW_NHANVIENGridControl_Click(object sender, EventArgs e)
		{
			var gridView = vIEW_NHANVIENGridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;

			if (gridView != null && gridView.FocusedRowHandle >= 0) // Kiểm tra có dòng được chọn
			{
				TE_ho.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ho")?.ToString();
				TE_ten.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "Ten")?.ToString();
				TE_DC.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DiaChi")?.ToString();
				TE_maNV.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaNV")?.ToString();
				TE_SDT.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "SÐT")?.ToString();
				DE_NS.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgaySinh")?.ToString();
				DE_NBD.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgayBatDau")?.ToString();
				DE_NKT.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "NgayKetThuc")?.ToString();
				string ttx = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TrangThaiXoa")?.ToString();
				if (ttx.Equals("1")) CK_TTX.Checked = false;
				else CK_TTX.Checked = true;
			}
		}

		private void bar_btn_ccn_ItemClick(object sender, ItemClickEventArgs e)
		{
			string maNV = "";
			SqlDataReader dataReader = null;
			String trangThaiXoa;
			trangThaiXoa = ((DataRowView)bds_nv[bds_nv.Position])["TrangThaiXoa"].ToString();

			if (trangThaiXoa == "1")
			{
				MessageBox.Show("Nhân viên đã bị xoá!", "Lỗi", MessageBoxButtons.OK);
				return;
			}
			if (MessageBox.Show("Bạn có thật sự muốn chuyển chi nhánh nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
			{
				try
				{
					maNV = ((DataRowView)bds_nv[bds_nv.Position])["MANV"].ToString();
					if (maNV.Equals(Program.username))
					{
						MessageBox.Show("Không thể Chuyển chính mình!", "Thông báo", MessageBoxButtons.OK);
						return;
					}
					string chinhanh;
					if (Program.mChiNhanh == 1)
					{
						chinhanh = "CN1       ";
					}
					else
					{
						chinhanh = "CN2       ";
					}
					string strLenh = $"EXEC SP_ChuyenCN @manv = {maNV}, @macngo = N'{chinhanh}'";
					dataReader = null;
					dataReader = Program.ExecSqlDataReader(strLenh);
					dataReader.Close();
					undolist.Push(maNV);
					undolist.Push("GOTO");
					MessageBox.Show("Chuyển nhân viên thành công Nhân viên!", "Thành công", MessageBoxButtons.OK);
					this.vIEW_NHANVIENTableAdapter.Fill(this.dS.VIEW_NHANVIEN);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi chuyển nhân viên. Không thành công!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
					bds_nv.Position = bds_nv.Find("MANV", maNV);
					return;
				}
			}
		}
	}
}