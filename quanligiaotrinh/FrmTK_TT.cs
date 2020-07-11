using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanligiaotrinh
{
    public partial class FrmTK_TT : Form
    {
        DataTable tableTKTT;
        public FrmTK_TT()
        {
            InitializeComponent();
        }
        private void loadDataToGridView()
        {
            string sql = "SELECT ThuThu.MaThuThu, ThuThu.TenThuThu, ThuThu.DiaChi, ThuThu.DienThoaiCD, ThuThu.DienThoaiDD, ThuThu.MaQue, HoSoTra.MaHSTra FROM ThuThu, HoSoTra WHERE ThuThu.MaThuThu = HoSoTra.MaThuThu";
            tableTKTT = DAO.LoadDataToGridView(sql);
            gridViewTK_TT.DataSource = tableTKTT;
            //gridViewTK_GT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
        private void FrmTK_TT_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            DAO.FillDataToCombo("SELECT DISTINCT TenThuThu FROM ThuThu", cmbThuThu, "TenThuThu", "TenThuThu");
            cmbThuThu.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT DISTINCT MaHSTra FROM HoSoTra", cmbMaHSTra, "MaHSTra", "MaHSTra");
            cmbMaHSTra.SelectedIndex = -1;
            loadDataToGridView();
            gridViewTK_TT.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cmbThuThu.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cmbThuThu.Text == "") && (cmbMaHSTra.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT ThuThu.MaThuThu, ThuThu.TenThuThu, ThuThu.DiaChi, ThuThu.DienThoaiCD, ThuThu.DienThoaiDD, ThuThu.MaQue, HoSoTra.MaHSTra FROM ThuThu, HoSoTra WHERE ThuThu.MaThuThu = HoSoTra.MaThuThu";
            if (cmbThuThu.Text != "")
                sql = sql + " AND TenThuThu = '" + cmbThuThu.Text + "' ";
            if (cmbMaHSTra.Text != "")
                sql = sql + " AND MaHSTra = '" + cmbMaHSTra.Text + "'";
            DataTable tblGT = DAO.LoadDataToGridView(sql);
            if (tblGT.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblGT.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tableTKTT = DAO.LoadDataToGridView(sql);
            gridViewTK_TT.DataSource = tableTKTT;
            ResetValues();
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            cmbThuThu.Text = "";
            cmbMaHSTra.Text = "";
            gridViewTK_TT.DataSource = null;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT ThuThu.MaThuThu, ThuThu.TenThuThu, ThuThu.DiaChi, ThuThu.DienThoaiCD, ThuThu.DienThoaiDD, ThuThu.MaQue, HoSoTra.MaHSTra FROM ThuThu, HoSoTra WHERE ThuThu.MaThuThu = HoSoTra.MaThuThu";
            tableTKTT = DAO.LoadDataToGridView(sql);
            gridViewTK_TT.DataSource = tableTKTT;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
