using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class FormMain : Form
    {
        private DataProvider dataProvider = new DataProvider();
        private int codeBookBookType;
        private int codeBookBook;
        private int codeBookTypeBookType;
        private int codeBillBill;
        private int codeImportImport;
        public FormMain()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            initBook();
            initBookType();
            initBill();
            initImport();
        }
        
        //Book Interface
        private void initBook()
        {
            loadDgBook(); //Loading table book
            loadCbBookBookType();
        }

        //Level Book
        private void loadDgBook()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_sach as [Mã sách]");
            query.Append(",ten_sach as [Tên sách]");
            query.Append(",ten_loai_sach as [Loại sách]");
            query.Append(",tac_gia as [Tác giả]");
            query.Append(",so_luong as [Số lượng]");
            query.Append(",gia_ban as [Giá bán]");
            query.Append(" FROM tbl_sach, tbl_loai_sach");
            query.Append(" WHERE tbl_sach.ma_loai_sach = tbl_loai_sach.ma_loai_sach");

            dt = dataProvider.execQuery(query.ToString());

            dgBook.DataSource = dt;

            codeBookBook = (int)dt.Rows[0][0];
        }

        private void loadCbBookBookType()
        {
            DataTable dt = new DataTable();

            dt = dataProvider.execQuery("SELECT * FROM tbl_loai_sach");

            cbBookBookType.DisplayMember = "ten_loai_sach";
            cbBookBookType.ValueMember = "ma_loai_sach";

            cbBookBookType.DataSource = dt;
        }

        private void dgBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < dgBook.RowCount - 1 && rowId >= 0)
            {
                DataGridViewRow row = dgBook.Rows[rowId];

                codeBookBook = (int)row.Cells[0].Value;
                textBookNameBook.Text = row.Cells[1].Value.ToString();
                cbBookBookType.Text = row.Cells[2].Value.ToString();
                textBookAuthor.Text = row.Cells[3].Value.ToString();
                numBookQuantity.Value = (int)row.Cells[4].Value;
                numBookPrice.Value = (int)row.Cells[5].Value;

                codeBookBookType = (int)dataProvider.execScaler("SELECT ma_loai_sach FROM tbl_loai_sach WHERE ten_loai_sach = N'" + cbBookBookType.Text + "'");
            }
        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_sach");
            query.Append(" @tenSach = N'" + textBookNameBook.Text + "'");
            query.Append(",@maLoaiSach = " + codeBookBookType);
            query.Append(",@tacGia = N'" + textBookAuthor.Text + "'");
            query.Append(",@soLuong = " + numBookQuantity.Value);
            query.Append(",@giaBan = " + numBookPrice.Value);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgBook();
                MessageBox.Show("Thêm sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else
            {
                MessageBox.Show("Thêm sách không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookChange_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_sach");
            query.Append(" @maSach = " + codeBookBook);
            query.Append(",@tenSach = N'" + textBookNameBook.Text + "'");
            query.Append(",@maLoaiSach = " + codeBookBookType);
            query.Append(",@tacGia = N'" + textBookAuthor.Text + "'");
            query.Append(",@soLuong = " + numBookQuantity.Value);
            query.Append(",@giaBan = " + numBookPrice.Value);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgBook();
                MessageBox.Show("Cập nhật sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật sách không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắc muốn xóa hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes) {
                string query = "DELETE FROM tbl_sach WHERE ma_sach = " + codeBookBook;
                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDgBook();
                    MessageBox.Show("Xóa sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } else
                {
                    MessageBox.Show("Xóa sách không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbBookBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            codeBookBookType = (int)comboBox.SelectedValue;
        }

        //Level BookType
        private void initBookType()
        {
            loadDgBookType();
        }

        private void loadDgBookType()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_loai_sach as [Mã loại sách]");
            query.Append(",ten_loai_sach as [Tên loại sách]");
            query.Append(" FROM tbl_loai_sach");

            dt = dataProvider.execQuery(query.ToString());

            dgBookType.DataSource = dt;

            codeBookTypeBookType = (int)dt.Rows[0][0];
        }

        private void dgBookType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < dgBookType.RowCount - 1 && rowId >= 0)
            {
                DataGridViewRow row = dgBookType.Rows[rowId];

                codeBookTypeBookType = (int)row.Cells[0].Value;
                textBookTypeNameBookType.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnBookTypeAdd_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_loai_sach");
            query.Append(" @tenLoaiSach = N'" + textBookTypeNameBookType.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgBookType();
                loadCbBookBookType();
                MessageBox.Show("Thêm loại sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm loại sách thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookTypeChange_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_loai_sach");
            query.Append(" @tenLoaiSach = N'" + textBookTypeNameBookType.Text + "'");
            query.Append(",@maLoaiSach = " + codeBookTypeBookType);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgBookType();
                loadDgBook();
                loadCbBookBookType();
                MessageBox.Show("Cập nhật loại sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật loại sách thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookTypeDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa loại sách " + textBookTypeNameBookType.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_loai_sach WHERE ma_loai_sach = " + codeBookTypeBookType;
                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadDgBookType();
                    loadCbBookBookType();
                    MessageBox.Show("Xóa loại sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa loại sách không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Level Bill
        private void initBill()
        {
            loadDgBill();
        }

        private void loadDgBill()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_hoa_don as [Mã hóa đơn]");
            query.Append(",ngay_lap_hoa_don as [Ngày lập hóa đơn]");
            query.Append(",ten_khach_hang as [Tên khách hàng]");
            query.Append(",sdt_khach_hang as [SĐT khách hàng]");
            query.Append(" FROM tbl_hoa_don");

            dt = dataProvider.execQuery(query.ToString());

            dgBill.DataSource = dt;

            codeBillBill = (int)dt.Rows[0][0];
        }

        private void dgBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < dgBill.RowCount - 1 && rowId >= 0)
            {
                DataGridViewRow row = dgBill.Rows[rowId];

                codeBillBill = (int)row.Cells[0].Value;
                dateTimeMakeBill.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                textBillNameCustomer.Text = row.Cells[2].Value.ToString();
                textPhoneCustomer.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_hoa_don");
            query.Append(" @ngayLapHoaDon = '" + dateTimeMakeBill.Value + "'");
            query.Append(",@tenKhachHang = N'" + textBillNameCustomer.Text + "'");
            query.Append(",@sdtKhachHang = '" + textPhoneCustomer.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgBill();
                MessageBox.Show("Thêm hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBillChange_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_hoa_don");
            query.Append(" @ngayLapHoaDon = '" + dateTimeMakeBill.Value + "'");
            query.Append(",@tenKhachHang = N'" + textBillNameCustomer.Text + "'");
            query.Append(",@sdtKhachHang = '" + textPhoneCustomer.Text + "'");
            query.Append(",@maHoaDon = " + codeBillBill);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgBill();
                MessageBox.Show("Cập nhật hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật hóa đơn thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn có mã " + codeBillBill + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_hoa_don WHERE ma_hoa_don = " + codeBillBill;
                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadDgBill();
                    MessageBox.Show("Xóa hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textPhoneCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnBillDetail_Click(object sender, EventArgs e)
        {
            FormDetailBill form = new FormDetailBill(codeBillBill);
            form.ShowDialog();
        }

        //Level Import
        private void initImport()
        {
            loadDgImport();
        }
        private void loadDgImport()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ma_phieu_nhap as [Mã phiếu nhập]");
            query.Append(",ngay_lap_phieu_nhap as [Ngày lập phiếu nhập]");
            query.Append(",ten_nha_cung_cap as [Tên nhà cung cấp]");
            query.Append(" FROM tbl_phieu_nhap");

            dt = dataProvider.execQuery(query.ToString());

            dgImport.DataSource = dt;

            codeImportImport = (int)dt.Rows[0][0];
        }

        private void dgImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId < dgImport.RowCount - 1 && rowId >= 0)
            {
                DataGridViewRow row = dgImport.Rows[rowId];

                codeImportImport = (int)row.Cells[0].Value;
                dateTimeMakeImport.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                textImportNameProvider.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnImportAdd_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_them_phieu_nhap");
            query.Append(" @ngayLapPhieuNhap = '" + dateTimeMakeImport.Value + "'");
            query.Append(",@tenNhaCungCap = N'" + textImportNameProvider.Text + "'");

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgImport();
                MessageBox.Show("Thêm phiếu thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm phiếu thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportChange_Click(object sender, EventArgs e)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_phieu_nhap");
            query.Append(" @ngayLapPhieuNhap = '" + dateTimeMakeImport.Value + "'");
            query.Append(",@tenNhaCungCap = N'" + textImportNameProvider.Text + "'");
            query.Append(",@maPhieuNhap = " + codeImportImport);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgImport();
                MessageBox.Show("Cập nhật phiếu thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật phiếu thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập có mã " + codeImportImport + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_phieu_nhap WHERE ma_phieu_nhap = " + codeImportImport;
                int result = dataProvider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    loadDgImport();
                    MessageBox.Show("Xóa phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa phiếu nhập không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImportDetail_Click(object sender, EventArgs e)
        {
            FormDetailImport form = new FormDetailImport(codeImportImport);
            form.ShowDialog();
        }
    }
}
