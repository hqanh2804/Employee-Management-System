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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANHE2_PRJ
{
    public partial class MH_DANGNHAP : Form
    {
        string sysString = @"Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XE))); User Id=QUANTRIHT;password=123" ;
        CONNECTION_STRING str = new CONNECTION_STRING();
        OracleConnection sysCon;
        OracleCommand cmd;
        string role;

        private void MH_DANGNHAP_Load(object sender, EventArgs e)
        {
            sysCon = new OracleConnection(sysString);
            sysCon.Open();
        }

        public MH_DANGNHAP()
        {
            InitializeComponent();
        }

        private void bt_DANGNHAP_Click(object sender, EventArgs e)
        {
            sysCon = new OracleConnection(sysString);
            sysCon.Open();
            cmd = new OracleCommand("select VAITRO from NHANVIEN where MANV = :username", sysCon);
            cmd.Parameters.Add(":username", OracleDbType.Char).Value = P_USERNAME.Text;
            role = Convert.ToString(cmd.ExecuteScalar());
            sysCon.Close();

            str.setConStr(P_USERNAME.Text, P_PASSWORD.Text);
            OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());

            try
            {
                con.Open();
                con.Close();

                MessageBox.Show("Đăng nhập thành công!!!");

                MH_DANGNHAP displayForm = Application.OpenForms.OfType<MH_DANGNHAP>().FirstOrDefault();
                if (displayForm != null)
                {
                    displayForm.Hide();
                }

                if (this.role == "Nhan vien")
                {
                    MH_NHANVIEN f = new MH_NHANVIEN();
                    f.ShowDialog();
                }

                else if (this.role == "QL Truc Tiep")
                {
                    MH_QLTRUCTIEP f = new MH_QLTRUCTIEP();
                    f.ShowDialog();
                }

                else if (this.role == "Truong phong")
                {
                    MH_TRUONGPHONG f = new MH_TRUONGPHONG();
                    f.ShowDialog();
                }

                else if (this.role == "Tai chinh")
                {
                    MH_TAICHINH f = new MH_TAICHINH();
                    f.ShowDialog();
                }

                else if (this.role == "Nhan su")
                {
                    MH_NHANSU_MENU f = new MH_NHANSU_MENU();
                    f.ShowDialog();
                }

                else if (this.role == "Truong de an")
                {
                    MH_TRGDEAN f = new MH_TRGDEAN();
                    f.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show("Invalid name or password.");
            }
        }
    }
}