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
    public partial class MH_NHANVIEN_XEMDEAN : Form
    {
        public MH_NHANVIEN_XEMDEAN()
        {
            InitializeComponent();
            display_DEAN();
        }

        public void display_DEAN()
        {
            OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.V_DEAN", con);
                adpt.Fill(dt);
                dtg_XEMDEAN.DataSource = dt;
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
