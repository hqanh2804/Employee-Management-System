using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PHANHE1_PRJ
{
    public partial class Management_Role_Privs : Form
    {

        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand command = null;
        public Management_Role_Privs()
        {
            InitializeComponent();
            display_role_privs();
        }

        private void display_role_privs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select * from sys.VIEW_ROLES_PRIVS", con);
                adpt.Fill(dt);
                dgtv_RolePrivs.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Grant_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nSYS.GRANT_PRIVS_ROLE(:P_ROLENAME,:P_PRIVSNAME,:P_OBJECTNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                command.Parameters.Add(new OracleParameter("P_PRIVSNAME", P_PRIVSNAME.Text));
                command.Parameters.Add(new OracleParameter("P_OBJECTNAME", P_OBJECTNAME.Text));
                
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("GRANT PRIVS SUCESSFULLY");
                //clearUserInput();
                //display_users();

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Revoke_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nSYS.REVOKE_PRIVS_ROLE(:P_ROLENAME,:P_PRIVSNAME,:P_OBJECTNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                command.Parameters.Add(new OracleParameter("P_PRIVSNAME", P_PRIVSNAME.Text));
                command.Parameters.Add(new OracleParameter("P_OBJECTNAME", P_OBJECTNAME.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("REVOKE PRIVS SUCESSFULLY");
                //clearUserInput();
                //display_users();

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_VIEW_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                command = new OracleCommand("SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE = :ROLENAME", con);
                command.Parameters.Add(":ROLENAME", OracleDbType.Char).Value = P_ROLENAME.Text;

                OracleDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgtv_RolePrivs.DataSource = dt;

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
