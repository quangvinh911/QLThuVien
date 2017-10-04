using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class QLThuVien : Form
    {
        frmDanhSachPhieuMuon DSPhieuMuon;
        frmDangKy DangKy;
        frmDangNhap DangNhap;
        frmPhieuMuon PhieuMuon;
        frmThongTinSach ThongTinSach;
        CapNhatTaiKhoan CapNhatTaiKhoan;
        frmNhapSach NhapSach;
        frmTraSach TraSach;
        frmThongTinPhieuMuon TTPhieuMuon;

        public QLThuVien()
        {
            InitializeComponent();
        }


        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatTaiKhoan = new CapNhatTaiKhoan();
            CapNhatTaiKhoan.ShowDialog();
        }

        private void cấpPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuon = new frmPhieuMuon();
            PhieuMuon.ShowDialog();
        }



        private void nhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSach = new frmThongTinSach();
            ThongTinSach.ShowDialog();
        }

        private void nhậpSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NhapSach = new frmNhapSach();
            NhapSach.ShowDialog();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy = new frmDangKy();
            DangKy.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap = new frmDangNhap();

            this.Hide();
            DangNhap.ShowDialog(); 
        }


        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSach = new frmTraSach();
            TraSach.ShowDialog();
        }

        private void thôngTinPhiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTPhieuMuon = new frmThongTinPhieuMuon();
            TTPhieuMuon.ShowDialog();
        }


    }
}
