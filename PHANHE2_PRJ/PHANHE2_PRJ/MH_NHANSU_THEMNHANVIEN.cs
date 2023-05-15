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
    public partial class MH_NHANSU_THEMNHANVIEN : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());
        OracleCommand cmd;

        public MH_NHANSU_THEMNHANVIEN()
        {
            InitializeComponent();
        }

        private void btnQLNV_Insert_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txt_MANV == null || txt_TenNV == null || cbb_Phai == null || cbb_Role == null || txt_Phong == null)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    cmd = new OracleCommand("BEGIN\nQUANTRIHT.SP_THEMNV_NS (:manv, :tennv, :phai, TO_DATE(:ngaysinh, 'DD/MM/YYYY'), :diachi, :sdt, NULL, NULL, :vaitro, :manql, :pban, :cn, :lv);\nEND;", conn);
                    cmd.Parameters.Add(new OracleParameter(":manv", txt_MANV.Text));
                    cmd.Parameters.Add(new OracleParameter(":tennv", txt_TenNV.Text));
                    cmd.Parameters.Add(new OracleParameter(":phai", cbb_Phai.Text));
                    cmd.Parameters.Add(new OracleParameter(":ngaysinh", txt_Date.Text));
                    cmd.Parameters.Add(new OracleParameter(":diachi", txt_Diachi.Text));
                    cmd.Parameters.Add(new OracleParameter(":sdt", txt_SDT.Text));
                    cmd.Parameters.Add(new OracleParameter(":vaitro", cbb_Role.Text));
                    cmd.Parameters.Add(new OracleParameter(":manql", txt_MaNQL.Text));
                    cmd.Parameters.Add(new OracleParameter(":pban", txt_Phong.Text));
                    cmd.Parameters.Add(new OracleParameter(":cn", cbb_CN.Text));
                    cmd.Parameters.Add(new OracleParameter(":lv", cbb_LV.Text));

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Thêm NHÂN VIÊN thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MH_NHANSU_QLNHANVIEN formQLNV = Application.OpenForms.OfType<MH_NHANSU_QLNHANVIEN>().FirstOrDefault();

                    if (formQLNV != null)
                    {
                        formQLNV.loadDataFormQLNV();
                        formQLNV.Show();
                        this.Close();
                    }
                }

                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Thêm NHÂN VIÊN KHÔNG thành công!\n" + ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
