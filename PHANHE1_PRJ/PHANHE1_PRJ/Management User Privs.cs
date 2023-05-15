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
    public partial class Management_User_Privs : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand command = null;
        public Management_User_Privs()
        {
            InitializeComponent();
            display_user_privs();
        }

        private void display_user_privs()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select * from sys.VIEW_USERS_PRIVS", con);
                adpt.Fill(dt);
                dgtv_UserPrivs.DataSource = dt;
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

                command = new OracleCommand("BEGIN\nSYS.GRANT_PRIVS_USER(:P_USERNAME,:P_PRIVSNAME,:P_OBJECTNAME,:GRANT_OPTION);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                command.Parameters.Add(new OracleParameter("P_PRIVSNAME", P_PRIVSNAME.Text));
                command.Parameters.Add(new OracleParameter("P_OBJECTNAME", P_OBJECTNAME.Text));
                command.Parameters.Add(new OracleParameter("GRANT_OPTION", GRANT_OPTION.Text));

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

                command = new OracleCommand("BEGIN\nSYS.REVOKE_PRIVS_USER(:P_USERNAME,:P_PRIVSNAME,:P_OBJECTNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
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
                command = new OracleCommand("SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = :USERNAME", con);
                command.Parameters.Add(":USERNAME", OracleDbType.Char).Value = P_USERNAME.Text;

                OracleDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgtv_UserPrivs.DataSource = dt;

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
