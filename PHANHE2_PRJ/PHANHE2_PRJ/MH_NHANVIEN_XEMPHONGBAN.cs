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
    public partial class MH_NHANVIEN_XEMPHONGBAN : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        public MH_NHANVIEN_XEMPHONGBAN()
        {
            InitializeComponent();
            display_PHONGBAN();
        }

        public void display_PHONGBAN()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.V_PHONGBAN", con);
                adpt.Fill(dt);
                dtg_PHONGBAN.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
