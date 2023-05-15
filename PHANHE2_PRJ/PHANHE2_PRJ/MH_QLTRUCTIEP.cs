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
    public partial class MH_QLTRUCTIEP : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        public MH_QLTRUCTIEP()
        {
            InitializeComponent();
            display_DSNVQLTRUCTIEP();
            display_PHANCONG();
        }
        public void display_DSNVQLTRUCTIEP()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select * from QUANTRIHT.V_NHANVIENQUANLI", con);
                adpt.Fill(dt);
                dtg_DSNVQLTRUCTIEP.DataSource = dt;
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
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.V_PHANCONG_QLTRUCTIEP", con);
                adpt.Fill(dt);
                dtg_PHANCONG.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_GIAODIEN_NV_Click(object sender, EventArgs e)
        {
            MH_QLTRUCTIEP displayForm = Application.OpenForms.OfType<MH_QLTRUCTIEP>().FirstOrDefault();
            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_NHANVIEN f = new MH_NHANVIEN();
            f.ShowDialog();
        }
    }
}
