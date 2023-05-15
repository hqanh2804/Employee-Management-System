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
    public partial class MH_TAICHINH : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;
        OracleDataAdapter adptNV = new OracleDataAdapter();
        OracleDataAdapter adptPC = new OracleDataAdapter();
        DataTable dtNV = new DataTable();
        DataTable dtPC = new DataTable();

        public void loadDataFormNhanVien_TaiChinh()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from QUANTRIHT.V_NHANVIEN_TAICHINH";
            adptNV.SelectCommand = cmd;
            dtNV.Clear();
            adptNV.Fill(dtNV);
            dgv_V_NHANVIEN_TAICHINH.DataSource = dtNV;
            conn.Close();
        }

        public void loadDataFormPhanCong_TaiChinh()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from QUANTRIHT.V_PHANCONG_TAICHINH";
            adptPC.SelectCommand = cmd;
            dtPC.Clear();
            adptPC.Fill(dtPC);
            dgv_V_PHANCONG_TAICHINH.DataSource = dtPC;
            conn.Close();
        }

        public MH_TAICHINH()
        {
            InitializeComponent();
            loadDataFormNhanVien_TaiChinh();
            loadDataFormPhanCong_TaiChinh();
        }

        private void MH_TAICHINH_Load(object sender, EventArgs e)
        {
            loadDataFormNhanVien_TaiChinh();
            loadDataFormPhanCong_TaiChinh();
        }

        private void btnTaiChinh_Luong_Click(object sender, EventArgs e)
        {
            MH_TAICHINH formTC = Application.OpenForms.OfType<MH_TAICHINH>().FirstOrDefault();

            if(formTC != null)
            {
                formTC.Hide();
            }

            MH_TAICHINH_CAPNHATLUONGNV f = new MH_TAICHINH_CAPNHATLUONGNV();
            f.ShowDialog();
        }

        private void btnTaiChinh_PhuCap_Click(object sender, EventArgs e)
        {
            MH_TAICHINH formTC = Application.OpenForms.OfType<MH_TAICHINH>().FirstOrDefault();

            if (formTC != null)
            {
                formTC.Hide();
            }

            MH_TAICHINH_CAPNHATPHUCAPNV f = new MH_TAICHINH_CAPNHATPHUCAPNV();
            f.ShowDialog();
        }

        private void btnTaiChinh_NV_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Về màn hình quản lý thông tin cá nhân?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                this.Hide();
                MH_NHANVIEN f = new MH_NHANVIEN();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnTaiChinh_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
