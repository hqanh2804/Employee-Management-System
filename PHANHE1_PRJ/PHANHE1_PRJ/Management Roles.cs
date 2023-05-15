using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.ManagedDataAccess.Client;

namespace PHANHE1_PRJ
{
    public partial class Management_Roles : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand COMMAND = null;
        public Management_Roles()
        {
            InitializeComponent();
            display_roles();
            clearRoleInput();
        }


        private void clearRoleInput()
        {
            P_ROLENAME.Text = "";
            P_PASSWORD.Text = "";

        }

        private void display_roles()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select role from sys.view_roles", con);
                adpt.Fill(dt);
                dtgv_ROLE.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CreateRole_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                COMMAND = new OracleCommand("BEGIN\nSYS.CREATE_ROLE(:P_ROLENAME, :P_PASSWORD);\nEND;", con);
                COMMAND.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                COMMAND.Parameters.Add(new OracleParameter("P_PASSWORD", P_PASSWORD.Text));
                COMMAND.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("CREATE ROLE SUCCESSFULLY.");
                display_roles();
                clearRoleInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DropRole_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                COMMAND = new OracleCommand("BEGIN\nSYS.DROP_ROLE(:P_ROLENAME);\nEND;", con);
                COMMAND.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                COMMAND.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DROP ROLE SUCCESSFULY.");
                display_roles();
                clearRoleInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_AlterRole_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                COMMAND = new OracleCommand("BEGIN\nSYS.ALTER_ROLE(:P_ROLENAME, :P_PASSWORD);\nEND;", con);
                COMMAND.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                COMMAND.Parameters.Add(new OracleParameter("P_PASSWORD", P_PASSWORD.Text));
                COMMAND.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Change role's password successfully.");
                display_roles();
                clearRoleInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }


}
