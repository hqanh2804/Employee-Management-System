using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE1_PRJ
{
    public partial class QUANTRI_CONSOLE : Form
    {
        public QUANTRI_CONSOLE()
        {
            InitializeComponent();
        }

        private void QUANTRI_CONSOLE_Load(object sender, EventArgs e)
        {

        }


        private void btn_MngUsers_Click(object sender, EventArgs e)
        {
            Management_Users f = new Management_Users();
            f.ShowDialog();
        }

        private void btn_View_DBA_USERS_Click(object sender, EventArgs e)
        {

        }

        private void btn_MngRoles_Click(object sender, EventArgs e)
        {
            Management_Roles f = new Management_Roles();
            f.ShowDialog();
        }

        private void btn_MngUserPrivs_Click(object sender, EventArgs e)
        {
            Management_User_Privs f = new Management_User_Privs();
            f.ShowDialog();
        }

        private void btn_MngRolePrivs_Click(object sender, EventArgs e)
        {
            Management_Role_Privs f = new Management_Role_Privs();
            f.ShowDialog();
        }

        private void btn_GrantRoletoUser_Click(object sender, EventArgs e)
        {
            Grant_Role_to_User f = new Grant_Role_to_User();
            f.ShowDialog();
        }
    }
}
