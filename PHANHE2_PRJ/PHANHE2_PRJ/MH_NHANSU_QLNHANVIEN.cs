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
    public partial class MH_NHANSU_QLNHANVIEN : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;
        OracleDataAdapter adpt = new OracleDataAdapter();
        DataTable dt = new DataTable();

        public void loadDataFormQLNV()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from QUANTRIHT.V_NHANVIEN_NHANSU";
            adpt.SelectCommand = cmd;
            dt.Clear();
            adpt.Fill(dt);
            dgv_V_NHANVIEN_NHANSU.DataSource = dt;
            conn.Close();
        }

        public MH_NHANSU_QLNHANVIEN()
        {
            InitializeComponent();
            loadDataFormQLNV();
        }

        private void MH_QLNHANVIEN_Load(object sender, EventArgs e)
        {
            loadDataFormQLNV();
        }

        private void btnQLNV_Insert_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLNHANVIEN formQLNV = Application.OpenForms.OfType<MH_NHANSU_QLNHANVIEN>().FirstOrDefault();

            if (formQLNV != null)
            {
                formQLNV.Hide();
            }

            MH_NHANSU_THEMNHANVIEN f = new MH_NHANSU_THEMNHANVIEN();
            f.ShowDialog();
        }

        private void btnQLNV_Update_Date_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLNHANVIEN formQLNV = Application.OpenForms.OfType<MH_NHANSU_QLNHANVIEN>().FirstOrDefault();

            if (formQLNV != null)
            {
                formQLNV.Hide();
            }

            MH_NHANSU_CAPNHATNGAYSINHNV f = new MH_NHANSU_CAPNHATNGAYSINHNV();
            f.ShowDialog();
        }

        private void btnQLNV_Update_Diachi_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLNHANVIEN formQLNV = Application.OpenForms.OfType<MH_NHANSU_QLNHANVIEN>().FirstOrDefault();

            if (formQLNV != null)
            {
                formQLNV.Hide();
            }

            MH_NHANSU_CAPNHATDIACHINV f = new MH_NHANSU_CAPNHATDIACHINV();
            f.ShowDialog();
        }

        private void btnQLNV_Update_SDT_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLNHANVIEN formQLNV = Application.OpenForms.OfType<MH_NHANSU_QLNHANVIEN>().FirstOrDefault();

            if (formQLNV != null)
            {
                formQLNV.Hide();
            }

            MH_NHANSU_CAPNHATSDTNV f = new MH_NHANSU_CAPNHATSDTNV();
            f.ShowDialog();
        }

        private void btnQLNV_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MH_NHANSU_MENU formMenu = new MH_NHANSU_MENU();
            formMenu.ShowDialog();
            this.Close();
        }
    }
}
