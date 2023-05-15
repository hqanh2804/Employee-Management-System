using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANHE2_PRJ
{
    public partial class MH_NHANSU_THEMPHONGBAN : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;
        public MH_NHANSU_THEMPHONGBAN()
        {
            InitializeComponent();
        }

        private void btnPB_Insert_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (txt_MAPB == null || txt_TenPB == null || txt_TRPHG == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_THEM_PHONGBAN (:mapb, :tenpb, :trphg);\nEND;", conn);
                    cmd.Parameters.Add(new OracleParameter(":mapb", txt_MAPB.Text));
                    cmd.Parameters.Add(new OracleParameter(":tenpb", txt_TenPB.Text));
                    cmd.Parameters.Add(new OracleParameter(":trphg", txt_TRPHG.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Thêm PHÒNG BAN thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Thêm PHÒNG BAN KHÔNG thành công!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } 
        }
    }
}
