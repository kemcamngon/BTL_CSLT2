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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTacGia f1 = new frmTacGia();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void giáoTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMGiaoTrinh f1 = new frmDMGiaoTrinh();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void thủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuThu f1 = new frmThuThu();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tìmKiếmGiáoTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTK_GT f1 = new FrmTK_GT();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void tìmKiếmThủThưToolStripMenuItem_Click(object sender, EventArgs e)
        {
             FrmTK_TT f1 = new FrmTK_TT();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhoa f1 = new frmKhoa();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop f1 = new frmLop();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void thẻMượnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTheMuon f1 = new frmTheMuon();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void phạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViPham f1 = new frmViPham();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void tiềnPhạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhat f1 = new frmPhat();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void tạoPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuon f1 = new frmPhieuMuon();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void hồSơMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoSoMuon f1 = new frmHoSoMuon();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void hồSơTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoSoTra f1 = new frmHoSoTra();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void danhSáchHồSơMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoHSM_TM f1 = new frmBaoCaoHSM_TM();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void giáoTrìnhĐượcMượnNhiềuNhấtTheoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCTop5 f1 = new frmBCTop5();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }

        private void danhSáchHồSơMượnCóGiáoTrìnhĐangĐượcMượnChưaTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBCHSM_GTCT f1 = new frmBCHSM_GTCT();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.Show();
        }
    }
}
