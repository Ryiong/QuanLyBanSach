using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class FormDetailImport : Form
    {
        DataProvider dataProvider = new DataProvider();
        private int codeBook;
        private int codeImport;
        private string nameBook;
        public FormDetailImport(int codeImport)
        {
            InitializeComponent();
            this.codeImport = codeImport;
            init(codeImport);
        }
        private void init(int codeImport)
        {
            titleImport.Text = "CHI TIẾT PHIẾU NHẬP " + codeImport.ToString();
            loadDgDetailImport();
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

        private void loadDgDetailImport()
        {
            DataTable dt = new DataTable();

            StringBuilder query = new StringBuilder("SELECT ten_sach as [Tên sách]");
            query.Append(",tbl_chi_tiet_phieu_nhap.so_luong as [Số lượng]");
            query.Append(",tbl_chi_tiet_phieu_nhap.gia_nhap as [Giá nhập]");
            query.Append(",tbl_chi_tiet_phieu_nhap.gia_nhap * tbl_chi_tiet_phieu_nhap.so_luong as [Thành tiền]");

            query.Append(" FROM tbl_sach, tbl_chi_tiet_phieu_nhap");
            query.Append(" WHERE tbl_sach.ma_sach = tbl_chi_tiet_phieu_nhap.ma_sach");
            query.Append(" AND ma_phieu_nhap = " + codeImport);

            dt = dataProvider.execQuery(query.ToString());

            dgDetailImport.DataSource = dt;

        }

        private void loadTotalPrice()
        {
            if ((int)dataProvider.execScaler("SELECT COUNT(*) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + codeImport) > 0)
            {
                double tongTien = (double)dataProvider.execScaler("SELECT SUM(so_luong * gia_nhap) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + codeImport);
                totalPriceImport.Text = "Tổng tiền: " + tongTien;
            }
            
        }
        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            codeBook = (int)comboBox.SelectedValue;
            nameBook = comboBox.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int dem = (int)dataProvider.execScaler("Select COUNT(*) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + codeImport + " AND ma_sach = " + codeBook);
            if (dem == 0)
            {
                StringBuilder query = new StringBuilder("EXEC proc_them_chi_tiet_phieu_nhap");
                query.Append(" @maPhieuNhap = " + codeImport);
                query.Append(",@maSach = " + codeBook);
                query.Append(",@soLuong = " + numBookQuantity.Value);
                query.Append(",@giaNhap = " + numPriceImport.Value);

                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDgDetailImport();
                    loadTotalPrice();
                    MessageBox.Show("Thêm sách vào phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm sách vào phiếu nhập không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                dem = (int)dataProvider.execScaler("Select SUM(so_luong) FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + codeImport + " AND ma_sach = " + codeBook);
                update(dem);
            }       
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            update(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Bạn có chắc chắc muốn xóa sách " + nameBook + " không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string query = "DELETE FROM tbl_chi_tiet_phieu_nhap WHERE ma_phieu_nhap = " + codeImport + "AND ma_sach = " + codeBook;
                int result = dataProvider.execNonQuery(query.ToString());

                if (result > 0)
                {
                    loadDgDetailImport();
                    loadTotalPrice();
                    MessageBox.Show("Xóa sách khỏi phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa sách khỏi phiếu nhập không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update(int soLuong)
        {
            StringBuilder query = new StringBuilder("EXEC proc_cap_nhat_chi_tiet_phieu_nhap");
            query.Append(" @maPhieuNhap = " + codeImport);
            query.Append(",@maSach = " + codeBook);
            query.Append(",@soLuong = " + (numBookQuantity.Value + soLuong));
            query.Append(",@giaNhap = " + numPriceImport.Value);

            int result = dataProvider.execNonQuery(query.ToString());

            if (result > 0)
            {
                loadDgDetailImport();
                loadTotalPrice();
                MessageBox.Show("Cập nhật sách vào phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Cập nhật sách vào phiếu nhập không thành công !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgDetailImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;
            if (rowId > dgDetailImport.RowCount - 1 && rowId > 0) {
                DataGridViewRow row = dgDetailImport.Rows[rowId];

                nameBook = row.Cells[0].Value.ToString();
                cbBook.Text = nameBook;
                numBookQuantity.Value = (int)row.Cells[1].Value;
                numPriceImport.Value = Convert.ToInt32(row.Cells[2].Value);

                codeBook = (int)dataProvider.execScaler("SELECT ma_sach FROM tbl_sach WHERE tbl_sach.ten_sach = N'" + nameBook + "'");
            }          
        }
    }
}
