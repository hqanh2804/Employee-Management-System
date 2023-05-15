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
    public partial class MH_NHANSU_CAPNHATTRUONGPHONG : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;

        public MH_NHANSU_CAPNHATTRUONGPHONG()
        {
            InitializeComponent();
        }

        private void btnPB_Update_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (txt_MAPB == null || txt_TRPHG == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_TRPHG_PB (:mapb, :trphg);\nEND;", conn);
                    cmd.Parameters.Add(new OracleParameter(":mapb", txt_MAPB.Text));
                    cmd.Parameters.Add(new OracleParameter(":trphg", txt_TRPHG.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật TRƯỞNG PHÒNG thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MH_NHANSU_QLPHONGBAN formQLPB = Application.OpenForms.OfType<MH_NHANSU_QLPHONGBAN>().FirstOrDefault();

                    if (formQLPB != null)
                    {
                        formQLPB.loadDataFormQLPB();
                        formQLPB.Show();
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Cập nhật TRƯỞNG PHÒNG KHÔNG thành công!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
