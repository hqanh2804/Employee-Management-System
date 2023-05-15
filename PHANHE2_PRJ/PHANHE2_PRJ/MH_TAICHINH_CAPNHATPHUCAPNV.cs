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

    public partial class MH_TAICHINH_CAPNHATPHUCAPNV : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;
        string str = new CONNECTION_STRING().getString();

        public MH_TAICHINH_CAPNHATPHUCAPNV()
        {
            InitializeComponent();
        }

        private void btnPhuCap_Update_Click(object sender, EventArgs e)
        {

            conn.Open();

            if(txt_MANV == null || txt_PhuCap == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_PHUCAPNV (:manv, :phucap);\nEND;", conn);
                    cmd.Parameters.Add(new OracleParameter(":manv", txt_MANV.Text));
                    cmd.Parameters.Add(new OracleParameter(":phucap", txt_PhuCap.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật PHỤ CẤP thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MH_TAICHINH formTC = Application.OpenForms.OfType<MH_TAICHINH>().FirstOrDefault();

                    if (formTC != null)
                    {
                        formTC.loadDataFormNhanVien_TaiChinh();
                        formTC.Show();
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Cập nhật PHỤ CẤP nhân viên KHÔNG thành công!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
