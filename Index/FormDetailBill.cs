using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class FormDetailBill : Form
    {
        DataProvider dataProvider = new DataProvider();
        private int codeBill;
        private int codeBook;
        private string nameBook;
        public FormDetailBill(int codeBill)
        {
            InitializeComponent();
            this.codeBill = codeBill;
            init(codeBill);
        }

        private void init(int codeBill)
        {
            titleBill.Text = "CHI TIẾT HÓA ĐƠN " + codeBill.ToString();
            loadDgDetailBill();
            loadCbBook();
            loadTotalPrice();
        }

        private void loadCbBook()
        {
            DataTable dt = new DataTable();

            dt = dataProvider.execQuery("SELECT * FROM tbl_sach");

            cbBook.DisplayMember = "ten_sach";
            cbBook.ValueMember = "ma_sach";

            cbBook.DataSource = dt;
        }

        private void loadDgDetailBill()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ten_sach as [Tên sách]");
            query.Append(",tbl_chi_tiet_hoa_don.so_luong as [Số lượng]");
            query.Append(",tbl_sach.gia_ban * tbl_chi_tiet_hoa_don.so_luong as [Thành tiền]");

            query.Append(" FROM tbl_sach, tbl_chi_tiet_hoa_don");
            query.Append(" WHERE tbl_sach.ma_sach = tbl_chi_tiet_hoa_don.ma_sach");
            query.Append(" AND ma_hoa_don = " + codeBill);

            dt = dataProvider.execQuery(query.ToString());

            dgDetailBill.DataSource = dt;

        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            codeBook = (int)comboBox.SelectedValue;
            nameBook = comboBox.Text;
        }

        private void loadTotalPrice()
        {
            if ((int)dataProvider.execScaler("SELECT COUNT(*) FROM tbl_chi_tiet_hoa_don WHERE ma_hoa_don = " + codeBill) > 0)
            {
                int tongTien = (int)dataProvider.execScaler("SELECT SUM(tbl_chi_tiet_hoa_don.so_luong * tbl_sach.gia_ban) FROM tbl_chi_tiet_hoa_don, tbl_sach WHERE ma_hoa_don = " + codeBill + " AND tbl_sach.ma_sach = tbl_chi_tiet_hoa_don.ma_sach");
                totalPriceBill.Text = "Tổng tiền: " + tongTien;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int dem = (int)dataProvider.execScaler("Select COUNT(*) FROM tbl_chi_tiet_hoa_don WHERE ma_hoa_don = " + codeBill + " AND ma_sach = " + codeBook);
            if (dem == 0)
            {
                StringBuilder query = new StringBuilder("EXEC proc_them_chi_tiet_hoa_don");
                query.Append(" @maHoaDon = " + codeBill);
                query.Append(",@maSach = " + codeBook);
                query.Append(",@soLuong = " + numBookQuantity.Value);

                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDgDetailBill();

                    MessageBox.Show("Thêm sách vào phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm sách vào phiếu nhập không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dem = (int)dataProvider.execScaler("Select SUM(so_luong) FROM tbl_chi_tiet_hoa_don WHERE ma_hoa_don = " + codeBill + " AND ma_sach = " + codeBook);
                update(dem);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            update(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắc muốn xóa sách " + nameBook + " khỏi hóa đơn không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_chi_tiet_hoa_don WHERE ma_hoa_don = " + codeBill + "AND ma_sach = " + codeBook;
                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDgDetailBill();
                    loadTotalPrice();
                    MessageBox.Show("Xóa sách khỏi hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa sách khỏi hóa đơn không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update(int soLuong)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_chi_tiet_hoa_don");
            query.Append(" @maHoaDon = " + codeBill);
            query.Append(",@maSach = " + codeBook);
            query.Append(",@soLuong = " + (numBookQuantity.Value + soLuong));

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgDetailBill();
                loadTotalPrice();
                MessageBox.Show("Cập nhật sách vào phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật sách vào phiếu nhập không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgDetailBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId > dgDetailBill.RowCount - 1 && rowId > 0)
            {
                DataGridViewRow row = dgDetailBill.Rows[rowId];

                nameBook = row.Cells[0].Value.ToString();
                cbBook.Text = nameBook;
                numBookQuantity.Value = (int)row.Cells[1].Value;

                codeBook = (int)dataProvider.execScaler("SELECT ma_sach FROM tbl_sach WHERE tbl_sach.ten_sach = N'" + nameBook + "'");
            }
        }
    }
}
