using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
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
	public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
	{
        private Boolean isSua = false;
        string HH_info = "";
        Stack undolist = new Stack();
        public FormVatTu()
		{
			InitializeComponent();
		}

		private void hangHoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.hangHoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

		private void FormVatTu_Load(object sender, EventArgs e)
		{
			try
			{
				this.dS.EnforceConstraints = false;
				// TODO: This line of code loads data into the 'dS.LoaiHang' table. You can move, or remove it, as needed.
				this.loaiHangTableAdapter.Connection.ConnectionString = Program.connstr;
				this.loaiHangTableAdapter.Fill(this.dS.LoaiHang);
				// TODO: This line of code loads data into the 'dS.VIEW_HANGHOA' table. You can move, or remove it, as needed.
				this.vIEW_HANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
				this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
				// TODO: This line of code loads data into the 'dS.HangHoa' table. You can move, or remove it, as needed.
				this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
				this.hangHoaTableAdapter.Fill(this.dS.HangHoa);
				if (!Program.mGroup.Equals("CHINHANH"))
				{
					add.Enabled = false;
					update.Enabled = false;
					save.Enabled = false;
					exit.Enabled = false;
					btn_undo.Enabled = false;
					remove.Enabled = false;
				}
				save.Enabled = exit.Enabled = refresh.Enabled = false;
				if (vIEW_HANGHOABindingSource.Count == 0)
				{
					remove.Enabled = false;
				}
				CBB_tenLH.DataSource = loaiHangBindingSource;
				CBB_tenLH.DisplayMember = "TenLH";
				CBB_tenLH.ValueMember = "MaLH";
                CBB_tenLH.SelectedIndex = 1; CBB_tenLH.SelectedIndex = 0;
            }
			catch
			{
				MessageBox.Show("Tải dữ liệu không thành công!\n", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			

        }

		private void vIEW_HANGHOAGridControl_Click(object sender, EventArgs e)
		{

		}

        private void vIEW_HANGHOAGridControl_Click_1(object sender, EventArgs e)
        {
            var gridView = vIEW_HANGHOAGridControl.FocusedView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null && gridView.FocusedRowHandle >= 0) // Kiểm tra có dòng được chọn
            {
                TE_maHH.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "MaHH")?.ToString();
                TE_tenHH.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenHH")?.ToString();
                TE_DVT.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "DVT")?.ToString();
                SP_soLuongTon.Text = gridView.GetRowCellValue(gridView.FocusedRowHandle, "SoLuongTon")?.ToString();
                string LoaiHang = gridView.GetRowCellValue(gridView.FocusedRowHandle, "TenLH")?.ToString();
                var item = loaiHangBindingSource.Cast<DataRowView>()
                                .FirstOrDefault(x => x["TenLH"].ToString() == LoaiHang);
				if (item != null)
				{
					CBB_tenLH.SelectedValue = item["MaLH"];
					SP_MALH.Text = CBB_tenLH.SelectedValue.ToString();
				}

			}
        }

        private void add_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupControl_edit.Enabled = true;
			TE_tenHH.Text = TE_DVT.Text = "";
            groupControl_VT.Enabled = false;
            add.Enabled = false;
            update.Enabled = false;
            remove.Enabled = false;
            save.Enabled = true;
            exit.Enabled = true;
            refresh.Enabled = false;
			SP_MALH.Text = CBB_tenLH.SelectedValue.ToString();
        }

        private void CBB_tenLH_SelectedIndexChanged(object sender, EventArgs e)
        {
            SP_MALH.Text = CBB_tenLH.SelectedValue.ToString();
        }

        private void exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            vIEW_HANGHOABindingSource.RemoveCurrent();
            this.vIEW_HANGHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
           
            groupControl_edit.Enabled = false;
            groupControl_VT.Enabled = true;
            this.vIEW_HANGHOAGridControl.Enabled = true;
            add.Enabled = update.Enabled = remove.Enabled = refresh.Enabled = true;
            save.Enabled = exit.Enabled = false;
            isSua = false;
        }

        private void update_ItemClick(object sender, ItemClickEventArgs e)
        {
            String trangThaiXoa;
            isSua = true;
            TE_maHH.Enabled = false;
            groupControl_edit.Enabled = true;
            vIEW_HANGHOAGridControl.Enabled = false;
            add.Enabled = update.Enabled = remove.Enabled = refresh.Enabled = false;
            save.Enabled = exit.Enabled = true;
        }

        private void remove_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result, resultHH;
            if (vIEW_HANGHOABindingSource.Count == 0)
            {
                MessageBox.Show("Không có nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK);
                remove.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        ///// load data
                        string maHH = ((DataRowView)vIEW_HANGHOABindingSource[vIEW_HANGHOABindingSource.Position])["MaHH"].ToString();
                        string tenHH = ((DataRowView)vIEW_HANGHOABindingSource[vIEW_HANGHOABindingSource.Position])["TenHH"].ToString();
                        string dvt = ((DataRowView)vIEW_HANGHOABindingSource[vIEW_HANGHOABindingSource.Position])["DVT"].ToString();
                        int SLTon = int.Parse(((DataRowView)vIEW_HANGHOABindingSource[vIEW_HANGHOABindingSource.Position])["SoLuongTon"].ToString());
                        string tenLH = ((DataRowView)vIEW_HANGHOABindingSource[vIEW_HANGHOABindingSource.Position])["TenLH"].ToString();
                        string malh = "";
                        var item = loaiHangBindingSource.Cast<DataRowView>()
                                .FirstOrDefault(x => x["TenLH"].ToString() == tenLH);
                        if (item != null) malh = item["MaLH"].ToString();
                        //// check
                        String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKHH] " +
                               "@MAHH = N'" + maHH + "' " +
                               "SELECT 'Return Value' = @return_value";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenhSDT);
                        dataReader.Read();
                        resultHH = dataReader.GetInt32(0);
                        dataReader.Close();
                        Program.conn.Close();
                        if (SLTon > 0||resultHH==1)
                        {
                            MessageBox.Show("Mặt hàng đã được sử dụng, không thể xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        } 
                            
                        HH_info = tenLH + "#" + dvt + "#" + SLTon.ToString() + "#" + malh;
                        string lenh = "delete FROM [dbo].[HangHoa] WHERE MaHH = N'"+maHH+"';";
                        Program.ExecSqlNonQuery(lenh);
                        btn_undo.Enabled = true;
                        undolist.Push(HH_info);
                        undolist.Push("DELETE");
                        this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Xóa Mặt hàng thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            try
            {
                TextEditConstrain test = new TextEditConstrain();
                if (test.CheckLength(TE_tenHH.Text, 30))
                {
                    MessageBox.Show("Tên hàng hóa không được trống, hoặc dài quá 30 kí tự!", "Lỗi", MessageBoxButtons.OK);
                    TE_tenHH.Focus();
                    return;
                }
                if (test.CheckLength(TE_DVT.Text, 100))
                {
                    MessageBox.Show("Tên hàng hóa không được trống, hoặc dài quá 100 kí tự!", "Lỗi", MessageBoxButtons.OK);
                    TE_DVT.Focus();
                    return;
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    if (!isSua)
                    {
                        //check
                        String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKNAMEHH] @MAHH = 0" +
                               ", @TENHH = '" + TE_tenHH.Text.Trim() + "' "+
                               "SELECT 'Return Value' = @return_value";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenhSDT);
                        dataReader.Read();
                        result = dataReader.GetInt32(0);
                        dataReader.Close();
                        Program.conn.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Tên mặt hàng đã bị trùng!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TE_tenHH.Focus();
                            return;
                        }
                        //insert
                        strLenh = $"INSERT [dbo].[HangHoa] ([TenHH], [DVT], [SoLuongTon], [MaLH]) " +
                            $"VALUES (N'{TE_tenHH.Text}', N'{TE_DVT.Text}', 0, {SP_MALH.Text});";
                        Program.ExecSqlDataReader(strLenh);

                        btn_undo.Enabled = true;
                        undolist.Push(TE_tenHH.Text);
                        undolist.Push("INSERT");
                    }
                    else
                    {
                        //check
                        String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKNAMEHH] @MAHH = "+ TE_maHH.Text +
                               ", @TENHH = N'" + TE_tenHH.Text.Trim() + "' " +
                               "SELECT 'Return Value' = @return_value";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenhSDT);
                        dataReader.Read();
                        result = dataReader.GetInt32(0);
                        dataReader.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Tên mặt hàng đã bị trùng!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            TE_tenHH.Focus();
                            return;
                        }
                        //update
                        string lenh = $"update [dbo].[HangHoa] set TenHH = N'{TE_tenHH.Text}', DVT = N'{TE_DVT.Text.Trim()}', " +
                            $"[MaLH] = N'{SP_MALH.Text}'" +
                            $" where MaHH = " + TE_maHH.Text + ";";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(lenh);
                        dataReader.Close();
                        btn_undo.Enabled = true;
                        String HH_info = TE_maHH.Text.Trim() + "#" + TE_tenHH.Text.Trim() + "#" 
                            + TE_DVT.Text.Trim() + "#" + SP_MALH.Text.Trim();
                        undolist.Push(HH_info);
                        undolist.Push("EDIT");
                    }
                    this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
                    groupControl_edit.Enabled = false;
                    groupControl_VT.Enabled = true;
                    add.Enabled = update.Enabled = remove.Enabled = refresh.Enabled =  true;
                    save.Enabled = exit.Enabled = false;
                    vIEW_HANGHOAGridControl.Enabled = true;
                    isSua = false;
                    MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //vIEW_HANGHOABindingSource.Position = vIEW_HANGHOABindingSource.Find("MaHH", maHH.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin Hàng hóa!\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.vIEW_HANGHOATableAdapter.Fill(dS.VIEW_HANGHOA);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_undo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                if (statement.Equals("DELETE"))
                {
                    String TT = undolist.Pop().ToString();
                    String[] TT_HH = TT.Split('#');

                    try
                    {
                        string strLenh = $"INSERT [dbo].[HangHoa] ([TenHH], [DVT], [SoLuongTon], [MaLH]) " +
                             $"VALUES (N'{TT_HH[0]}', N'{TT_HH[1]}', 0, {TT_HH[3]});";
                        Program.ExecSqlDataReader(strLenh);
                        this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hoàn tác Xóa hàng hóa thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (statement.Equals("EDIT"))
                {
                    try
                    {
                        String TT = undolist.Pop().ToString();
                        String[] TT_HH = TT.Split('#');

                        string lenh = $"update [dbo].[HangHoa] set TenHH = N'{TT_HH[1]}', DVT = N'{TT_HH[2]}', " +
                            $"[MaLH] = N'{TT_HH[3]}'" +
                            $" where MaHH = " + TT_HH[0] + ";";
                        Program.ExecSqlNonQuery(lenh);
                        this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
                        vIEW_HANGHOABindingSource.Position = vIEW_HANGHOABindingSource.Find("MaHH", TT_HH[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi không thể rollback sủa nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (statement.Equals("INSERT"))
                {
                    String TenNV = undolist.Pop().ToString();
                    try
                    {
                        string lenh = "DELETE FROM [dbo].[HangHoa] where TenHH = N'" + TenNV + "';";
                        Program.ExecSqlNonQuery(lenh);
                        this.vIEW_HANGHOATableAdapter.Fill(this.dS.VIEW_HANGHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hủy Xóa nhân viên thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
                if (undolist.Count == 0)
            {
                btn_undo.Enabled = false;
            }
        }
    }
}