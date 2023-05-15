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
    public partial class MH_NHANSU_QLPHONGBAN : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;
        OracleDataAdapter adpt = new OracleDataAdapter();
        DataTable dt = new DataTable();

        public void loadDataFormQLPB()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from QUANTRIHT.V_PHONGBAN_NHANSU";
            adpt.SelectCommand = cmd;
            dt.Clear();
            adpt.Fill(dt);
            dgv_V_PHONG_NHANSU.DataSource = dt;
            conn.Close();
        }

        public MH_NHANSU_QLPHONGBAN()
        {
            InitializeComponent();
            loadDataFormQLPB();
        }

        private void MH_QLPHONGBAN_Load(object sender, EventArgs e)
        {
            loadDataFormQLPB();
        }

        private void btnQLPB_Insert_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLPHONGBAN formQLPB = Application.OpenForms.OfType<MH_NHANSU_QLPHONGBAN>().FirstOrDefault();

            if (formQLPB != null)
            {
                formQLPB.Hide();
            }

            MH_NHANSU_THEMPHONGBAN f = new MH_NHANSU_THEMPHONGBAN();
            f.ShowDialog();
        }

        private void btnQLPB_Update_Ten_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLPHONGBAN formQLPB = Application.OpenForms.OfType<MH_NHANSU_QLPHONGBAN>().FirstOrDefault();

            if (formQLPB != null)
            {
                formQLPB.Hide();
            }

            MH_NHANSU_CAPNHATTENPHONGBAN f = new MH_NHANSU_CAPNHATTENPHONGBAN();
            f.ShowDialog();
        }

        private void btnQLNV_Update_TRPHG_Click(object sender, EventArgs e)
        {
            MH_NHANSU_QLPHONGBAN formQLPB = Application.OpenForms.OfType<MH_NHANSU_QLPHONGBAN>().FirstOrDefault();

            if (formQLPB != null)
            {
                formQLPB.Hide();
            }

            MH_NHANSU_CAPNHATTRUONGPHONG f = new MH_NHANSU_CAPNHATTRUONGPHONG();
            f.ShowDialog();
        }

        private void btnQLPB_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MH_NHANSU_MENU formMenu = new MH_NHANSU_MENU();
            formMenu.ShowDialog();
            this.Close();
        }
    }
}
