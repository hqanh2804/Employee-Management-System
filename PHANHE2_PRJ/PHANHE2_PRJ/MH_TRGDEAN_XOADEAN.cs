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
    public partial class MH_TRGDEAN_XOADEAN : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;

        public MH_TRGDEAN_XOADEAN()
        {
            InitializeComponent();
        }

        private void btnDA_Delete_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (txt_MADA == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn xoá đề án này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_XOA_DEAN (:mada);\nEND;", conn);
                        cmd.Parameters.Add(new OracleParameter(":mada", txt_MADA.Text));

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Xoá ĐỀ ÁN thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MH_TRGDEAN formTDA = Application.OpenForms.OfType<MH_TRGDEAN>().FirstOrDefault();

                        if (formTDA != null)
                        {
                            formTDA.loadDataFormTDA();
                            formTDA.Show();
                            this.Close();
                        }
                    }

                    catch (Exception ex)
                    {
                        conn.Close();
                        MessageBox.Show("Không thể xoá đề án đã được phân công\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
