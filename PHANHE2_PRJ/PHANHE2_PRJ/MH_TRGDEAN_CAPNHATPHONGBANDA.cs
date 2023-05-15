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
    public partial class MH_TRGDEAN_CAPNHATPHONGBANDA : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;

        public MH_TRGDEAN_CAPNHATPHONGBANDA()
        {
            InitializeComponent();
        }

        private void btnDA_UpdatePB_Click(object sender, EventArgs e)
        {
            conn.Open();
            
            if (txt_MADA == null || txt_Phong == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_PHONG_DEAN (:mada, :pban);\nEND;", conn);
                    cmd.Parameters.Add(new OracleParameter(":mada", txt_MADA.Text));
                    cmd.Parameters.Add(new OracleParameter(":pban", txt_Phong.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật PHÒNG BAN phụ trách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Cập nhật PHÒNG BAN phụ trách KHÔNG thành công!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
