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
    public partial class Management_Users : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTIONSTRING().getString());
        OracleCommand command = null;

        public Management_Users()
        {
            InitializeComponent();
            display_users();
            clearUserInput();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearUserInput()
        {
            P_USERNAME.Text = "";
            P_PASSWORD.Text = "";
        }

      

        private void display_users()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("select username from sys.view_users", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_CREATEUSER_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nSYS.CREATE_USER(:P_USERNAME,:P_PASSWORD);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                command.Parameters.Add(new OracleParameter("P_PASSWORD", P_PASSWORD.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("CREATE USER SUCESSFULLY");
                clearUserInput();
                display_users();

            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_DROPUSER_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                command = new OracleCommand("BEGIN\nSYS.DROP_USER(:P_USERNAME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DROP USER SUCCESSFULLY.");
                display_users();
                clearUserInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ALTERUSER_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleCommand command = new OracleCommand("BEGIN\nSYS.ALTER_USER(:P_USERNAME, :P_PASSWORD);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_USERNAME", P_USERNAME.Text));
                command.Parameters.Add(new OracleParameter("P_PASSWORD", P_PASSWORD.Text));
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Change user's password successfully.");
                display_users();
                clearUserInput();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void Management_Users_Load(object sender, EventArgs e)
        {

        }
    }
}
