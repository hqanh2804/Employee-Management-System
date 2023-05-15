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

namespace PHANHE2_PRJ
{
    public partial class MH_TRUONGPHONG_CAPNHATPHANCONG : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand command = null;
        string connectionString = new CONNECTION_STRING().getString();

        public MH_TRUONGPHONG_CAPNHATPHANCONG()
        {
            InitializeComponent();
        }

        private void MANV_TextChanged(object sender, EventArgs e)
        {

        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_THOIGIAN_PHANCONG(:MANV,:MADA,:TIME);\nEND;", con);
                command.Parameters.Add(new OracleParameter("MANV", MANV.Text));
                command.Parameters.Add(new OracleParameter("MADA", MADA.Text));
                command.Parameters.Add(new OracleParameter("TIME", TIME.Text));
                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("CẬP NHẬT THÀNH CÔNG PHÂN CÔNG");

                MH_NHANVIEN displayForm = Application.OpenForms.OfType<MH_NHANVIEN>().FirstOrDefault();

                if (displayForm != null) // nếu tìm thấy
                {
                    displayForm.display_PersonalInf(); // gọi hàm display_PersonalInf() để hiển thị lại dữ liệu
                    this.Close(); // đóng form MH_CAPNHATDIACHINV
                    displayForm.Show(); // mở lại form MH_NHANVIEN
                }
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void MADA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
