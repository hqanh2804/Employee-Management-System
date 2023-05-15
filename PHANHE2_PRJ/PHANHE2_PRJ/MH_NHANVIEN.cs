using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE2_PRJ
{
    public partial class MH_NHANVIEN : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        
        public MH_NHANVIEN()
        {
            InitializeComponent();
            display_PersonalInf();
            display_PHANCONG();
        }

        public void display_PersonalInf()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.V_NHANVIEN", con);
                adpt.Fill(dt);
                dtg_V_NHANVIEN.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void display_PHANCONG()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.V_PHANCONG", con);
                adpt.Fill(dt);
                dtg_V_PHANCONG.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CAPNHATNGAYSINH_Click(object sender, EventArgs e)
        {
            MH_NHANVIEN displayForm = Application.OpenForms.OfType<MH_NHANVIEN>().FirstOrDefault();

            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_NHANVIEN_CAPNHATNGAYSINHNV f = new MH_NHANVIEN_CAPNHATNGAYSINHNV();
            f.ShowDialog();

            display_PersonalInf();
        }

        private void btn_CAPNHATDIACHI_Click(object sender, EventArgs e)
        {
            MH_NHANVIEN displayForm = Application.OpenForms.OfType<MH_NHANVIEN>().FirstOrDefault();

            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_NHANVIEN_CAPNHATDIACHINV f = new MH_NHANVIEN_CAPNHATDIACHINV();
            f.ShowDialog();

            display_PersonalInf();
        }

        private void btn_CAPNHATSODT_Click(object sender, EventArgs e)
        {
            MH_NHANVIEN displayForm = Application.OpenForms.OfType<MH_NHANVIEN>().FirstOrDefault();

            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_NHANVIEN_CAPNHATSODTNV f = new MH_NHANVIEN_CAPNHATSODTNV();
            f.ShowDialog();

            display_PersonalInf();

        }
        private void MH_NHANVIEN_Activated(object sender, EventArgs e)
        {
            display_PersonalInf();
        }

        private void P_XEMPHONGBAN_Click(object sender, EventArgs e)
        {
            MH_NHANVIEN_XEMPHONGBAN f = new MH_NHANVIEN_XEMPHONGBAN();
            f.ShowDialog();
        }

        private void P_XEMDEAN_Click(object sender, EventArgs e)
        {
            MH_NHANVIEN_XEMDEAN f = new MH_NHANVIEN_XEMDEAN();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
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
