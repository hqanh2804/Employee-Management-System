using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PHANHE2_PRJ
{
    public partial class MH_NHANSU_MENU : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());

        public MH_NHANSU_MENU()
        {
            InitializeComponent();
        }

        private void btnMenu_QLNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MH_NHANSU_QLNHANVIEN formQLNV = new MH_NHANSU_QLNHANVIEN();
            formQLNV.ShowDialog();
            this.Close();
        }

        private void btnMenu_QLPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            MH_NHANSU_QLPHONGBAN formQLPB = new MH_NHANSU_QLPHONGBAN();
            formQLPB.ShowDialog();
            this.Close();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                MH_DANGNHAP displayForm = Application.OpenForms.OfType<MH_DANGNHAP>().FirstOrDefault();

                if (displayForm != null) // nếu tìm thấy
                {
                    this.Close(); // đóng form MH_CAPNHATDIACHINV
                    displayForm.Show(); // mở lại form MH_DANGNHAP
                }
            }            
        }
    }
}
