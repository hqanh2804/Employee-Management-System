using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE2_PRJ
{
    public partial class MH_NHANVIEN_CAPNHATSODTNV : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand command = null;
        string connectionString = new CONNECTION_STRING().getString();
        public MH_NHANVIEN_CAPNHATSODTNV()
        {
            InitializeComponent();
        }

        private void btn_CAPNHAT_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_SODTNV(:P_SODT);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_SODT", P_SODT.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("CẬP NHẬT THÀNH CÔNG SỐ ĐIỆN THOẠI");

                MH_NHANVIEN displayForm = Application.OpenForms.OfType<MH_NHANVIEN>().FirstOrDefault();

                if (displayForm != null) // nếu tìm thấy
                {
                    displayForm.display_PersonalInf(); // gọi hàm display_PersonalInf() để hiển thị lại dữ liệu
                    this.Close(); // đóng form MH_CAPNHATSODTNV
                    displayForm.Show(); // mở lại form MH_NHANVIEN
                }
            }

            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
