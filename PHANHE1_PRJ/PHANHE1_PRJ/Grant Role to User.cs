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
    public partial class Grant_Role_to_User : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand command = null;
        public Grant_Role_to_User()
        {
            InitializeComponent();
        }

        private void btn_GrantRoletoUser_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nSYS.GRANT_ROLE_TO_USER(:P_ROLENAME,:P_USERNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_ROLENAME", P_ROLENAME.Text));
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("GRANT ROLE TO USER SUCESSFULLY");
                //clearUserInput();
                //display_users();

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
