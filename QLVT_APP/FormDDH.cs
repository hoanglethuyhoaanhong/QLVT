using DevExpress.XtraBars;
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

namespace QLVT_APP
{
	public partial class FormDDH : DevExpress.XtraEditors.XtraForm
	{
        private Boolean isSua = false;
        string info = "";
        Stack undolist = new Stack();
        public FormDDH()
		{
			InitializeComponent();
		}

		private void donDatHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.donDatHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
		private void SP_NCC_EditValueChanged(object sender, EventArgs e)
		{
			// Logic xử lý khi giá trị thay đổi
		}
		private void FormDDH_Load(object sender, EventArgs e)
		{

			this.dS.EnforceConstraints = false;
			// TODO: This line of code loads data into the 'dS.DonDatHang' table. You can move, or remove it, as needed.
			this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
			this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
            // TODO: This line of code loads data into the 'dS.CT_DonDatHang' table. You can move, or remove it, as needed.
            this.cT_DonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
			this.cT_DonDatHangTableAdapter.Fill(this.dS.CT_DonDatHang);
			// TODO: This line of code loads data into the 'dS.HangHoa' table. You can move, or remove it, as needed.
			this.hangHoaTableAdapter.Connection.ConnectionString = Program.connstr;
			this.hangHoaTableAdapter.Fill(this.dS.HangHoa);
			// TODO: This line of code loads data into the 'dS.NhaCungCap' table. You can move, or remove it, as needed.
			this.nhaCungCapTableAdapter.Connection.ConnectionString = Program.connstr;
			this.nhaCungCapTableAdapter.Fill(this.dS.NhaCungCap);
			// TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
			this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
			this.khoTableAdapter.Fill(this.dS.Kho);
			if (!Program.mGroup.Equals("CHINHANH"))
			{
				add.Enabled = false;
				update.Enabled = false;
				save.Enabled = false;
				exit.Enabled = false;
				undo.Enabled = false;
				remove.Enabled = false;
			}
			undo.Enabled = save.Enabled = exit.Enabled = refresh.Enabled = false;
			CBB_NCC.DataSource = nhaCungCapBindingSource;
			CBB_NCC.DisplayMember = "TenNCC";
			CBB_NCC.ValueMember = "MaNCC";
			CBB_Kho.DataSource = khoBindingSource;
			CBB_Kho.DisplayMember = "TenKho";
			CBB_Kho.ValueMember = "MaKho";
			CBB_HH.DataSource = hangHoaBindingSource;
			CBB_HH.DisplayMember = "TenHH";
			CBB_HH.ValueMember = "MaHH";
		}
		private void SP_maKho_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void SP_maHH_EditValueChanged(object sender, EventArgs e)
		{

		}

        private void add_ItemClick(object sender, ItemClickEventArgs e)
        {
            //donDatHangBindingSource.AddNew();
            groupControl_edit.Enabled = true;
			DE_NT.EditValue = DateTime.Now;
			SP_maNV.Text = Program.username;
			CBB_Kho.SelectedIndex = CBB_NCC.SelectedIndex = 0;
            SP_maNCC.Text = CBB_NCC.SelectedValue.ToString();
            SP_maKho.Text = CBB_Kho.SelectedValue.ToString();
            groupControl_DDH.Enabled = false;
            add.Enabled = false;
            update.Enabled = false;
            remove.Enabled = false;
            save.Enabled = true;
            exit.Enabled = true;
			btn_HH.Enabled = btn_DDH.Enabled = false;
        }

        private void exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            donDatHangBindingSource.RemoveCurrent();
            // TODO: This line of code loads data into the 'dS.DonDatHang' table. You can move, or remove it, as needed.
            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
            // TODO: This line of code loads data into the 'dS.CT_DonDatHang' table. You can move, or remove it, as needed.
            this.cT_DonDatHangTableAdapter.Fill(this.dS.CT_DonDatHang);
            groupControl_edit.Enabled = false;
            groupControl_DDH.Enabled = true;
            add.Enabled  = update.Enabled  = refresh.Enabled =  true;
            save.Enabled = exit.Enabled = false;
            btn_HH.Enabled = btn_DDH.Enabled = true;
        }

        private void refresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
                this.cT_DonDatHangTableAdapter.Fill(this.dS.CT_DonDatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CBB_NCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_NCC.SelectedItem == null || CBB_NCC.SelectedValue == null)
            {
                return;
            }
            SP_maNCC.Text = CBB_NCC.SelectedValue.ToString();
        }

        private void CBB_Kho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_Kho.SelectedItem == null || CBB_Kho.SelectedValue == null)
            {
                return;
            }
            SP_maKho.Text = CBB_Kho.SelectedValue.ToString();
        }

        private void update_ItemClick(object sender, ItemClickEventArgs e)
        {
            isSua = true;
            groupControl_edit.Enabled = true;
            groupControl_DDH.Enabled = false;
            add.Enabled = false;
            update.Enabled = false;
            remove.Enabled = refresh.Enabled = false;
            save.Enabled = true;
            exit.Enabled = true;
            btn_HH.Enabled = btn_DDH.Enabled = false;

        }

        private void btn_DDH_Click(object sender, EventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            //check
            String strLenhSDT = "DECLARE @return_value int " +
                   "EXEC @return_value = [dbo].[SP_CHECKDDH] @MADDH = " + SP_SDDH.Text +
                   " SELECT 'Return Value' = @return_value";
            dataReader = null;
            dataReader = Program.ExecSqlDataReader(strLenhSDT);
            dataReader.Read();
            result = dataReader.GetInt32(0);
            dataReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Đơn đặt hàng đã được nhập không thể sửa!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string MaDDH = ((DataRowView)donDatHangBindingSource[donDatHangBindingSource.Position])["SoDDH"].ToString();
            SP_SDDH_CT.Text = MaDDH;
            groupControl_editCT.Enabled = true;
            groupControl_DDH.Enabled = false;
            save.Enabled = refresh.Enabled = add.Enabled = false;
            update.Enabled = false;
            remove.Enabled = false;
            save.Enabled = true;
            exit.Enabled = true;
            btn_DDH.Enabled = false;
            btn_HH.Enabled = true;
        }

        private void groupControl_editCT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl_edit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void soDDHLabel_Click(object sender, EventArgs e)
        {

        }

        private void SP_SDDH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ngayLapLabel_Click(object sender, EventArgs e)
        {

        }

        private void cT_DonDatHangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DE_NT_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void maNVLabel_Click(object sender, EventArgs e)
        {

        }

        private void maNCCLabel_Click(object sender, EventArgs e)
        {

        }

        private void save_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    int maDDH = 0;
                    if (!isSua)
                    {
                        DateTime ngaytao = DE_NT.DateTime;
                        
                        strLenh = $"INSERT [dbo].[DonDatHang] ([NgayLap], [MaNV], [MaNCC], [MaKho]) " +
                        $"VALUES (N'{ngaytao:yyyy-MM-dd}', {SP_maNV.Text}, {SP_maNCC.Text}, {SP_maKho.Text}); " +
                        $"SELECT SCOPE_IDENTITY();";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenh);
                        dataReader.Read();
                        maDDH = Convert.ToInt32(dataReader[0]);
                        dataReader.Close();;
                        undo.Enabled = true;
                        undolist.Push(maDDH.ToString());
                        undolist.Push("INSERT");

                    }
                    else
                    {
                        //check
                        String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKDDH] @MADDH = " + SP_SDDH.Text +
                               " SELECT 'Return Value' = @return_value";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenhSDT);
                        dataReader.Read();
                        result = dataReader.GetInt32(0);
                        dataReader.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Đơn đặt hàng đã được nhập không thể sửa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        //update
                        DateTime ngaytao = DE_NT.DateTime;
                        string lenh = $"update [dbo].[DonDatHang] set [NgayLap] = N'{ngaytao:yyyy-MM-dd}', [MaNV] = {SP_maNV.Text}, " +
                            $"[MaNCC] = {SP_maNCC.Text}, [MaKho] = {SP_maKho.Text}" +
                            $" where MaHH = {SP_SDDH.Text};";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(lenh);
                        dataReader.Close();
                        undo.Enabled = true;
                        info = SP_SDDH.Text.Trim() + "#" + DE_NT.Text.Trim() + "#"
                            + SP_maNV.Text.Trim() + "#" + SP_maNCC.Text.Trim() + "#" + SP_maKho.Text.Trim();
                        undolist.Push(info);
                        undolist.Push("EDIT");
                        maDDH = int.Parse(SP_SDDH.Text);
                    }
                    this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
                    groupControl_edit.Enabled = false;
                    groupControl_DDH.Enabled = true;
                    add.Enabled = update.Enabled = remove.Enabled = true;
                    save.Enabled = exit.Enabled = false;
                    donDatHangGridControl.Enabled = true;
                    MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    donDatHangBindingSource.Position = donDatHangBindingSource.Find("SoDDH", maDDH.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lưu dữ liệu không thành công vui lòng kiểm tra thông tin Hàng hóa!\n" + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void CBB_HH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBB_HH.SelectedItem == null || CBB_HH.SelectedValue == null)
            {
                return;
            }
            SP_maHH.Text = CBB_HH.SelectedValue.ToString();
        }

        private void remove_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            if (donDatHangBindingSource.Count == 0)
            {
                MessageBox.Show("Không có Đơn đặt hàng để xóa!", "Thông báo", MessageBoxButtons.OK);
                remove.Enabled = false;
            }
            else
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa kho này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        string MaDDH = ((DataRowView)donDatHangBindingSource[donDatHangBindingSource.Position])["SoDDH"].ToString();
                        String strLenhSDT = "DECLARE @return_value int " +
                               "EXEC @return_value = [dbo].[SP_CHECKDDH] @MADDH = " + MaDDH +
                               " SELECT 'Return Value' = @return_value";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenhSDT);
                        dataReader.Read();
                        result = dataReader.GetInt32(0);
                        dataReader.Close();
                        if (result == 1)
                        {
                            MessageBox.Show("Đơn đặt hàng này đã được sử dụng, không thể xóa!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        String info = DE_NT.Text + "#" + SP_maNV.Text + "#" + SP_maNCC.Text + "#" + SP_maKho.Text;

                        donDatHangBindingSource.RemoveCurrent();
                        this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.donDatHangTableAdapter.Update(this.dS.DonDatHang);
                        undo.Enabled = true;
                        undolist.Push(info);
                        undolist.Push("DELETE");
                        this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa Đơn đặt hàng thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void undo_ItemClick(object sender, ItemClickEventArgs e)
        {
            string strLenh;
            SqlDataReader dataReader = null;
            int result;
            if (undolist.Count > 0)
            {
                String statement = undolist.Pop().ToString();
                int maDDH = 0;
                switch (statement)
                {
                    case "DELETE":
                        String TT = undolist.Pop().ToString();
                        String[] TT_DDH = TT.Split('#'); // ngày tạo # mã nv # mã ncc # mã kho
                        strLenh = $"INSERT [dbo].[DonDatHang] ([NgayLap], [MaNV], [MaNCC], [MaKho]) " +
                        $"VALUES (N'{TT_DDH[0]}', {TT_DDH[1]}, {TT_DDH[2]}, {TT_DDH[3]}); " +
                        $"SELECT SCOPE_IDENTITY();";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(strLenh);
                        dataReader.Read();
                        maDDH = Convert.ToInt32(dataReader[0]);
                        dataReader.Close(); ;
                        this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
                        donDatHangBindingSource.Position = donDatHangBindingSource.Find("SoDDH", maDDH.ToString());
                        MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        donDatHangBindingSource.Position = donDatHangBindingSource.Find("SoDDH", maDDH.ToString());
                        break;
                    case "INSERT":
                        String MaDDH = undolist.Pop().ToString();
                        int vitri = donDatHangBindingSource.Find("SoDDH", MaDDH);
                        donDatHangBindingSource.Position = vitri;
                        donDatHangBindingSource.RemoveCurrent();
                        this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.donDatHangTableAdapter.Update(this.dS.DonDatHang);
                        this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
                        maDDH = int.Parse(MaDDH);
                        MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        donDatHangBindingSource.Position = donDatHangBindingSource.Find("SoDDH", maDDH.ToString());
                        break;
                    case "UPDATE":
                        int maDDH_update = 0;
                        String TT_update = undolist.Pop().ToString();
                        String[] TT_DDH_update = TT_update.Split('#'); // số ddh # ngày tạo # mã nv # mã ncc # mã kho
                        string lenh = $"update [dbo].[DonDatHang] set [NgayLap] = N'{TT_DDH_update[1]}', [MaNV] = {TT_DDH_update[2]}, " +
                            $"[MaNCC] = {TT_DDH_update[3]}, [MaKho] = {TT_DDH_update[4]}" +
                            $" where MaHH = {TT_DDH_update[0]};";
                        dataReader = null;
                        dataReader = Program.ExecSqlDataReader(lenh);
                        dataReader.Close();
                        this.donDatHangTableAdapter.Fill(this.dS.DonDatHang);
                        maDDH = int.Parse(TT_DDH_update[0]);
                        MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        donDatHangBindingSource.Position = donDatHangBindingSource.Find("SoDDH", maDDH.ToString());
                        break;
                    case "ADDVT":
                        String TT_VT = undolist.Pop().ToString();
                        String[] TT_VTx = TT_VT.Split('#'); //số DDH # mã hh
                        string lenhXoa = $"delete FROM [dbo].[CT_DonDatHang] WHERE SoDDH = {TT_VTx[0]} AND MaHH = {TT_VTx[1]} ;";
                        Program.ExecSqlNonQuery(lenhXoa);
                        MessageBox.Show("Ghi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                    default :
                        MessageBox.Show("Hoàn tác thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                        break;

                }
                
            }
            if (undolist.Count == 0)
            {
                undo.Enabled = false;
            }
        }

        private void btn_HH_Click(object sender, EventArgs e)
        {
            try
            {
                string strLenh;
                SqlDataReader dataReader = null;
                int result;
                //check
                String strLenhSDT = "DECLARE @return_value int " +
                       "EXEC @return_value = [dbo].[SP_CHECK_DDH_VT] @MADDH = " + SP_SDDH_CT.Text +
                       ", @MAHH = "+ SP_maHH.Text + " SELECT 'Return Value' = @return_value";
                dataReader = null;
                dataReader = Program.ExecSqlDataReader(strLenhSDT);
                dataReader.Read();
                result = dataReader.GetInt32(0);
                dataReader.Close();
                if (result == 1)
                {
                    MessageBox.Show("Sản phẩm đã được thêm vào đơn đặt hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // insert
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string data = SP_SDDH_CT.Text + "#" + SP_maHH.Text;
                    undolist.Push(data);
                    undolist.Push("ADDVT");
                    //cT_DonDatHangBindingSource.AddNew();
                    //cT_DonDatHangBindingSource.EndEdit();
                    //this.cT_DonDatHangTableAdapter.Update(this.dS.CT_DonDatHang);
                    //this.cT_DonDatHangTableAdapter.Fill(this.dS.CT_DonDatHang);
                    strLenh = $"INSERT [dbo].[CT_DonDatHang] ([SoDDH], [MaHH], [SoLuong], [DonGia]) " +
                        $"VALUES ({SP_SDDH_CT.Text}, {SP_maHH.Text}, {SP_SL.Text}, {SP_DG.Text}); ";
                    Program.ExecSqlNonQuery(strLenh);
                    undo.Enabled = true;
                    this.cT_DonDatHangTableAdapter.Fill(this.dS.CT_DonDatHang);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm hàng hóa vào Đơn đặt hàng thất bại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}