using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace quanligiaotrinh
{
    public partial class frmBCTop5 : Form
    {
        DataTable tblBaoCao;
        public frmBCTop5()
        {
            InitializeComponent();
        }

        private void frmBCTop5_Load(object sender, EventArgs e)
        {
            //Đổ 4 quý vào combobox
            cmbQuy.Items.Add("1");
            cmbQuy.Items.Add("2");
            cmbQuy.Items.Add("3");
            cmbQuy.Items.Add("4");
        }
        private void ResetValues()
        {
            txtNam.Text = "";
            cmbQuy.Text = "";
        }
        private void btnInBC_Click(object sender, EventArgs e)
        {
            if (cmbQuy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbQuy.Focus();
                return;
            }
            if (txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNam.Focus();
                return;
            }
            // Khởi động chương trình Excel
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            Excel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            Excel.Range exRange;
            int hang = 0, cot = 0;
            exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Quản lý giáo trình";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (036)9592656";
            exRange.Range["D2:I4"].Font.Size = 16;
            exRange.Range["D2:I4"].Font.Bold = true;
            exRange.Range["D2:I4"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["D2:I4"].MergeCells = true;
            exRange.Range["D2:I4"].WrapText = true;
            exRange.Range["D2:I4"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["D2:I4"].Value = "BÁO CÁO 5 GIÁO TRÌNH ĐƯỢC MƯỢN NHIỀU NHẤT THEO QUÝ " + cmbQuy.Text;

            string sql;
            DataTable danhsach;

            //exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //exSheet = exBook.Worksheets[1];
            //exRange = exSheet.Cells[1, 1];
            //exRange.Range["A1:Z300"].Font.Name = "Times new roman";
            //exRange.Range["C2:G2"].Font.Size = 16;
            //exRange.Range["C2:G2"].Font.Bold = true;
            //exRange.Range["C2:G2"].Font.ColorIndex = 3;
            //exRange.Range["C2:G2"].MergeCells = true;
            //exRange.Range["C2:G2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C2:G2"].Value = "Báo cáo danh sách 5 giáo trình được mượn nhiều nhất theo quý";
            sql = "SELECT TOP 5 a.MaGT,a.TenGT,a.MaTacGia,Datepart(quarter,c.NgayMuon) as Quy,a.NamXB,a.LanTB,a.MaChuyenNganh, SUM(Soluong) as SolanMuon from (DMGiaoTrinh a join ChiTietHSMuon b on a.MaGT=b.MaGT) join HoSoMuon c on b.MaHSM = c.MaHSM where Datepart(year,c.NgayMuon) = '" + txtNam.Text + "' and Datepart(quarter,c.NgayMuon) ='" + cmbQuy.Text + "' GROUP BY a.MaGT,a.TenGT,a.MaTacGia,a.NamXB,a.LanTB,a.MaChuyenNganh ,c.NgayMuon ORDER BY SUM(SoLuong) desc";



            danhsach = DAO.GetDataToTable(sql);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 11;
            exRange.Range["D5:D5"].ColumnWidth = 23;
            exRange.Range["E5:E5"].ColumnWidth = 23;
            exRange.Range["F5:F5"].ColumnWidth = 23;
            exRange.Range["G5:G5"].ColumnWidth = 23;
            exRange.Range["H5:H5"].ColumnWidth = 23;
            exRange.Range["I5:I5"].ColumnWidth = 23;
            exRange.Range["J5:J5"].ColumnWidth = 23;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã GT";
            exRange.Range["D5:D5"].Value = "Tên GT";
            exRange.Range["E5:E5"].Value = "Mã tác giả";
            exRange.Range["F5:F5"].Value = "Quý";
            exRange.Range["G5:G5"].Value = "Năm xuất bản";
            exRange.Range["H5:H5"].Value = "Lần tái bản";
            exRange.Range["I5:I5"].Value = "Mã chuyên ngành";
            exRange.Range["J5:J5"].Value = "Tổng số lượng mượn theo quý";

            for (hang = 0; hang < danhsach.Rows.Count; hang++)
            {
                exSheet.Cells[2][hang + 6] = hang + 1;
                for (cot = 0; cot < danhsach.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 3][hang + 6] = danhsach.Rows[hang][cot].ToString();
                }
            }

            exRange = exSheet.Cells[2][hang + 8];
            exRange.Range["D1:F1"].MergeCells = true;
            exRange.Range["D1:F1"].Font.Italic = true;
            exRange.Range["D1:F1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["D1:F1"].Value = "Hà Nội, Ngày " + DateTime.Now.ToShortDateString();
            exSheet.Name = "Báo cáo";
            exApp.Visible = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            if (cmbQuy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn quý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbQuy.Focus();
                return;
            }
            if (txtNam.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNam.Focus();
                return;
            }
            // string sql = "SELECT TOP 5 a.MaGT,a.TenGT,a.MaTacGia,a.NamXB,a.LanTB,a.MaChuyenNganh, SUM(Soluong) from DMGiaoTrinh as a, HoSoMuon as b where a.MaGT=b.MaGT AND (datepart(QQ,NgayMuon) = '" + cmbQuy.Text + "') AND ((YEAR(b.NgayMuon) = '" + txtNam.Text + "')) GROUP BY a.MaGT,a.TenGT,a.MaTacGia,a.NamXB,a.LanTB,a.MaChuyenNganh ORDER BY SUM(SoLuong) desc";
            string sql = "SELECT TOP 5 a.MaGT,a.TenGT,a.MaTacGia,Datepart(quarter,c.NgayMuon) as Quy,a.NamXB,a.LanTB,a.MaChuyenNganh, SUM(Soluong) as SolanMuon from (DMGiaoTrinh a join ChiTietHSMuon b on a.MaGT=b.MaGT) join HoSoMuon c on b.MaHSM = c.MaHSM where Datepart(year,c.NgayMuon) = '" + txtNam.Text + "' and Datepart(quarter,c.NgayMuon) ='" + cmbQuy.Text + "' GROUP BY a.MaGT,a.TenGT,a.MaTacGia,a.NamXB,a.LanTB,a.MaChuyenNganh ,c.NgayMuon ORDER BY SUM(SoLuong) desc";

            tblBaoCao = DAO.GetDataToTable(sql);
            grvTop5.DataSource = tblBaoCao;
            grvTop5.Columns[0].HeaderText = "Mã GT";
            grvTop5.Columns[1].HeaderText = "Tên GT";
            grvTop5.Columns[2].HeaderText = "Mã tác giả";
            grvTop5.Columns[3].HeaderText = "Quý";
            grvTop5.Columns[4].HeaderText = "Năm xuất bản";
            grvTop5.Columns[5].HeaderText = "Lần tái bản";
            grvTop5.Columns[6].HeaderText = "Mã chuyên ngành";
            grvTop5.Columns[7].HeaderText = "Tổng số lượng mượn theo quý";
            grvTop5.Columns[0].Width = 100;
            grvTop5.Columns[1].Width = 100;
            grvTop5.Columns[2].Width = 100;
            grvTop5.Columns[3].Width = 100;
            grvTop5.Columns[4].Width = 100;
            grvTop5.Columns[5].Width = 100;
            grvTop5.Columns[6].Width = 100;
            grvTop5.Columns[7].Width = 100;
            grvTop5.AllowUserToAddRows = false;
            grvTop5.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtNam.Text = "";
            cmbQuy.Text = "";
            grvTop5.DataSource = null;
        }

        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void cmbQuy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
