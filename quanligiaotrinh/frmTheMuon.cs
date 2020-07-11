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
    public partial class frmTheMuon : Form
    {
        public frmTheMuon()
        {
            InitializeComponent();
        }

        private void frmTheMuon_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            txtMaThe.Enabled = false;
            btnLuu.Enabled = false;
            LoadDataToGridView();
            DAO.FillDataToCombo("SELECT MaKhoa FROM Khoa", cmbMaKhoa, "MaKhoa", "MaKhoa");
            DAO.FillDataToCombo("SELECT MaLop FROM Lop", cmbMaLop, "MaLop", "MaLop");
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nu");
            cmbGioiTinh.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            txtMaThe.Text = "";
            txtHoTen.Text = "";
            cmbGioiTinh.Text = "";
            cmbMaKhoa.Text = "";
            cmbMaLop.Text = "";
        }
        private void LoadDataToGridView()
        {
            try
            {
                DAO.OpenConnection();
                string sql = "select * from TheMuon";
                SqlDataAdapter myAdapter = new SqlDataAdapter(sql, DAO.conn);
                DataTable TheMuon = new DataTable();
                myAdapter.Fill(TheMuon);
                gridViewTheMuon.DataSource = TheMuon;
                gridViewTheMuon.Update();
                gridViewTheMuon.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                DAO.CloseConnection();
            }
//            string sql1 = "select a.MaThe, HoTen, GioiTinh, MaLop, MaKhoa, MaViPham, SoLuongMuon, NgayNopPhat , "+
//"(CASE  WHEN MaViPham != '' and NgayNopPhat = ''"+
//                     "THEN 'TRUE'"+
//                 " ELSE 'FALSE'"+
//            "END) as KhoaThe FROM TheMuon a join HoSoMuon b on a.MaThe = b.MaThe join HoSoTra c on b.MaHSM = c.MaHSM join ChitietHSTra d on d.MaHSTra = c.MaHSTra WHERE 1 = 1;";

            //TheMuon = DAO.GetDataToTable(sql1);
            //gridViewTheMuon.DataSource = TheMuon;
            //gridViewTheMuon.Update();
            //gridViewTheMuon.Refresh();
            //gridViewTheMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void gridViewTheMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThe.Text = gridViewTheMuon.CurrentRow.Cells["MaThe"].Value.ToString();
            txtHoTen.Text = gridViewTheMuon.CurrentRow.Cells["HoTen"].Value.ToString();
            cmbMaKhoa.Text = gridViewTheMuon.CurrentRow.Cells["MaKhoa"].Value.ToString();
            cmbMaLop.Text = gridViewTheMuon.CurrentRow.Cells["MaLop"].Value.ToString();
            cmbGioiTinh.Text = gridViewTheMuon.CurrentRow.Cells["GioiTinh"].Value.ToString();
            txtMaThe.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            //txtMaThe.Text = DAO.CreateKey("T");
            txtMaThe.Enabled = true;
            LoadDataToGridView();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaThe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaThe.Focus();
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            /*if (txtTTNopPhat = new string[] { Convert.ToString(formcollection["Chua nop"]))
            {
                sql= "Update TheMuon Set KhoaThe = ""Da khoa"" where MaThe = (Select MaThe from HoSoMuon a join HoSoTra b on a.MaThe = b.MaThe where MaHSTra = txtMaHSTra)";
            }*/
            //thực hiện lệnh update ở bảng thẻ mượn
            /*if (txtKhoaThe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khóa thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKhoaThe.Focus();
                return;
            }*/
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaKhoa.Focus();
                return;
            }
            if (cmbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaLop.Focus();
                return;
            }
            if (cmbGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGioiTinh.Focus();
                return;
            }
            // sql = "SELECT MaLop FROM Lop WHERE MaLop = N'" + txtMaThe.Text.Trim() + "'";
            sql = "INSERT INTO TheMuon VALUES ('" + txtMaThe.Text + "',N'" + txtHoTen.Text + "',N'" + cmbGioiTinh.Text + "',N'" + cmbMaLop.Text + "',N'" + cmbMaKhoa.Text + "','FALSE',0);";
            DAO.RunSql(sql);
            MessageBox.Show("them thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
           //if (DAO.CheckKey(sql))
           // {
           //     MessageBox.Show("Mã lớp này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           //     txtMaThe.Focus();
           //     txtMaThe.Text = "";
           //     return;
           // }
  

            LoadDataToGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaThe.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaThe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }
            if (cmbMaKhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaKhoa.Focus();
                return;
            }
            if (cmbMaLop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbMaLop.Focus();
                return;
            }
            if (cmbGioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbGioiTinh.Focus();
                return;
            }
            sql = "UPDATE TheMuon SET HoTen=N'" + txtHoTen.Text + "',MaKhoa=N'" + cmbMaKhoa.Text + "',MaLop=N'" + cmbMaLop.Text + "',GioiTinh=N'" + cmbGioiTinh.Text + "'WHERE MaThe=N'" + txtMaThe.Text + "'";
            DAO.RunSql(sql);
            MessageBox.Show("Sửa thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            LoadDataToGridView();
            ResetValues();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DAO.OpenConnection();
            string sql;
            if (txtMaThe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE FROM TheMuon WHERE MaThe=N'" + txtMaThe.Text + "'";
                DAO.RunSql(sql);
                MessageBox.Show("Xóa thanh cong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                LoadDataToGridView();
                ResetValues();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cmbMaLop.Text == "")
            {
                cmbMaKhoa.Text = "";
            }
            str = "SELECT MaKhoa FROM Lop WHERE MaLop =N'" + cmbMaLop.SelectedValue + "'";
            cmbMaKhoa.Text = DAO.GetFieldValues(str);
        }

        //private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        //{
        //    string sql;
        //    sql = "SELECT NgayNopPhat FROM Phat WHERE MaPhat = N'" + cmbNgayNopPhat.Text.Trim() + "'";
        //}

    }
}
