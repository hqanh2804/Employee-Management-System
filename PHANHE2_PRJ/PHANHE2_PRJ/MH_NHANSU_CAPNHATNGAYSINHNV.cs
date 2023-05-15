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
    public partial class MH_NHANSU_CAPNHATNGAYSINHNV : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;

        public MH_NHANSU_CAPNHATNGAYSINHNV()
        {
            InitializeComponent();
        }

        private void btnQLNV_UpdateDate_Click(object sender, EventArgs e)
        {
            conn.Open();

            if(txt_MANV == null || txt_Date == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_CAPNHAT_NGAYSINHNV_NS (:manv, TO_DATE(:ngaysinh, 'DD/MM/YYYY'));\nEND;", conn);
                    cmd.Parameters.Add(new OracleParameter(":manv", txt_MANV.Text));
                    cmd.Parameters.Add(new OracleParameter(":ngaysinh", txt_Date.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Cập nhật NGÀY SINH nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MH_NHANSU_QLNHANVIEN formTDA = Application.OpenForms.OfType<MH_NHANSU_QLNHANVIEN>().FirstOrDefault();

                    if (formTDA != null)
                    {
                        formTDA.loadDataFormQLNV();
                        formTDA.Show();
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Cập nhật NGÀY SINH nhân viên KHÔNG thành công!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
