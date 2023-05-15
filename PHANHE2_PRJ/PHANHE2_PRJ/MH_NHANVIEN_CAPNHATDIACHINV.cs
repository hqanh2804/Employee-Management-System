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
    public partial class MH_NHANVIEN_CAPNHATDIACHINV : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand command = null;
        string connectionString = new CONNECTION_STRING().getString();
        
        public MH_NHANVIEN_CAPNHATDIACHINV()
        {
            InitializeComponent();
        }

        private void btn_CAPNHAT_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                command = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_DIACHINV(:P_DIACHI);\nEND;", con);
                command.Parameters.Add(new OracleParameter("P_DIACHI", P_DIACHI.Text));

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("CẬP NHẬT THÀNH CÔNG ĐỊA CHỈ");

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
    }
}
