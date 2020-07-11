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
    public partial class frmBCHSM_GTCT : Form
    {
        DataTable tblHSM_GTCT;
        public frmBCHSM_GTCT()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            sql = "SELECT a.MaHSM, a.MaThe, a.MaThuThu, a.NgayMuon, a.NgayPhaiTra FROM HoSoMuon a join ChiTietHSMuon b on a.MaHSM=b.MaHSM WHERE b.ChuaTra = 'YES'";
            DAO.RunSql(sql);
            tblHSM_GTCT = DAO.LoadDataToGridView(sql);
            grvHSM_GTCT.DataSource = tblHSM_GTCT;
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            grvHSM_GTCT.DataSource = null;
        }

        private void btnInBC_Click(object sender, EventArgs e)
        {
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
            exRange.Range["D2:I4"].Value = "BÁO CÁO DANH SÁCH HỒ SƠ MƯỢN CÓ GIÁO TRÌNH ĐANG ĐƯỢC MƯỢN CHƯA TRẢ";

            string sql;
            DataTable danhsach;

            sql = "SELECT a.MaHSM, a.MaThe, a.MaThuThu, a.NgayMuon, a.NgayPhaiTra FROM HoSoMuon a join ChiTietHSMuon b on a.MaHSM=b.MaHSM WHERE b.ChuaTra = 'YES'";
            DAO.RunSql(sql);

            danhsach = DAO.GetDataToTable(sql);

            exRange.Range["B5:G5"].Font.Bold = true;
            exRange.Range["B5:G5"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            exRange.Range["B5:B5"].ColumnWidth = 12;
            exRange.Range["C5:C5"].ColumnWidth = 15;
            exRange.Range["D5:D5"].ColumnWidth = 11;
            exRange.Range["E5:E5"].ColumnWidth = 11;
            exRange.Range["F5:F5"].ColumnWidth = 23;
            exRange.Range["G5:G5"].ColumnWidth = 23;
            exRange.Range["B5:B5"].Value = "STT";
            exRange.Range["C5:C5"].Value = "Mã HSM";
            exRange.Range["D5:D5"].Value = "Mã thẻ";
            exRange.Range["E5:E5"].Value = "Mã thủ thư";
            exRange.Range["F5:F5"].Value = "Ngày mượn";
            exRange.Range["G5:G5"].Value = "Ngày phải trả";

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
    }
}
