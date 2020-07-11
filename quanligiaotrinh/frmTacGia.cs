using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanligiaotrinh
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            txtMaTacGia.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaKhoa, TenKhoa FROM Khoa",
           cmbMaKhoa, "MaKhoa", "TenKhoa");
            cmbMaKhoa.SelectedIndex = -1;
            DAO.FillDataToCombo("SELECT MaTrinhDo, TenTrinhDo FROM TrinhDo",
           cmbMaTrinhDo, "MaTrinhDo", "TenTrinhDo");
            cmbMaTrinhDo.SelectedIndex = -1;
            ResetValues();
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from TacGia";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable TacGia = new DataTable();
                myAdapter.Fill(TacGia);
                gridViewTacGia.DataSource = TacGia;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
        }
        private void ResetValues()
        {
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
            txtNamSinh.Text = "";
            cmbMaKhoa.Text = "";
            cmbMaTrinhDo.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtMaTacGia.Focus();
                return;
            }
            if (txtTenTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTacGia.Focus();
                return;
            }
            if (txtNamSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm sinh", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }
            if (cmbMaTrinhDo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn trình độ", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaTrinhDo.Focus();
                return;
            }
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaKhoa.Focus();
                return;
            }
            sql = "SELECT MaTacGia FROM TacGia WHERE MaTacGia=N'" + txtMaTacGia.Text.Trim() + "'";
            if (DAO.CheckKey(sql) == true)
            {
                MessageBox.Show("Mã tác giả này đã có, bạn phải nhập mã khác", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTacGia.Focus();
                txtMaTacGia.Text = "";
                return;
            }
            sql = "INSERT INTO TacGia(MaTacGia, TenTacGia, NamSinh, MaTrinhDo, MaKhoa) VALUES(N'"
                + txtMaTacGia.Text.Trim() + "',N'" + txtTenTacGia.Text.Trim() + "',N'"
                + txtNamSinh.Text.Trim() + "',N'" + cmbMaTrinhDo.SelectedValue + "',N'"
                + cmbMaKhoa.SelectedValue + "')";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnDong.Enabled = true;
            btnLuu.Enabled = false;
            txtMaTacGia.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtMaTacGia.Focus();
                return;
            }
            if (txtTenTacGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTacGia.Focus();
                return;
            }
            if (txtNamSinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập năm sinh", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                txtNamSinh.Focus();
                return;
            }

            sql = "UPDATE TacGia SET TenTacGia=N'" + txtTenTacGia.Text + 
                "',NamSinh=N'" + txtNamSinh.Text +
                "',MaTrinhDo=N'" + cmbMaTrinhDo.Text +
                "',MaKhoa=N'" + cmbMaKhoa.Text +
                "' WHERE MaTacGia=N'" + txtMaTacGia.Text + "'";
            DAO.RunSql(sql);
            LoadDataToGridView();
            ResetValues();
            btnDong.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaTacGia.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE TacGia WHERE MaTacGia=N'" + txtMaTacGia.Text + "'";
                DAO.RunSql(sql);
                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaTacGia.Text = gridViewTacGia.CurrentRow.Cells["MaTacGia"].Value.ToString();
            txtTenTacGia.Text = gridViewTacGia.CurrentRow.Cells["TenTacGia"].Value.ToString();
            txtNamSinh.Text = gridViewTacGia.CurrentRow.Cells["NamSinh"].Value.ToString();
            cmbMaTrinhDo.Text = gridViewTacGia.CurrentRow.Cells["MaTrinhDo"].Value.ToString();
            cmbMaKhoa.Text = gridViewTacGia.CurrentRow.Cells["MaKhoa"].Value.ToString();
            txtMaTacGia.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnDong.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaTacGia.Text = DAO.CreateKey("TG");
            txtMaTacGia.Enabled = false;
            txtTenTacGia.Focus();
        }
    }
}
