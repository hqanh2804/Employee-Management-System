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
    public partial class MH_TRGDEAN : Form
    {
        OracleConnection conn = new OracleConnection(new CONNECTION_STRING().getString());        
        OracleCommand cmd;
        OracleDataAdapter adpt = new OracleDataAdapter();
        DataTable dt = new DataTable();

        public void loadDataFormTDA()
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from QUANTRIHT.V_DEAN_TRUONGDEAN";
            adpt.SelectCommand = cmd;
            dt.Clear();
            adpt.Fill(dt);
            dgv_V_DEAN_TRUONGDEAN.DataSource = dt;
            conn.Close();
        }

        public MH_TRGDEAN()
        {
            InitializeComponent();
            loadDataFormTDA();
        }

        private void MH_TRUONGDEAN_Load(object sender, EventArgs e)
        {
            loadDataFormTDA();
        }

        private void btnTDA_Insert_Click(object sender, EventArgs e)
        {
            MH_TRGDEAN formTDA = Application.OpenForms.OfType<MH_TRGDEAN>().FirstOrDefault();

            if (formTDA != null)
            {
                formTDA.Hide();
            }

            MH_TRGDEAN_THEMDEAN f = new MH_TRGDEAN_THEMDEAN();
            f.ShowDialog();
        }

        private void btnTDA_Update_PB_Click(object sender, EventArgs e)
        {
            MH_TRGDEAN formTDA = Application.OpenForms.OfType<MH_TRGDEAN>().FirstOrDefault();
            
            if(formTDA != null)
            {
                formTDA.Hide();
            }

            MH_TRGDEAN_CAPNHATPHONGBANDA f = new MH_TRGDEAN_CAPNHATPHONGBANDA();
            f.ShowDialog();
        }

        private void btnTDA_Update_Date_Click(object sender, EventArgs e)
        {
            MH_TRGDEAN formTDA = Application.OpenForms.OfType<MH_TRGDEAN>().FirstOrDefault();

            if (formTDA != null)
            {
                formTDA.Hide();
            }

            MH_TRGDEAN_CAPNHATNGAYBATDAU f = new MH_TRGDEAN_CAPNHATNGAYBATDAU();
            f.ShowDialog();
        }

        private void btnTDA_Delete_Click(object sender, EventArgs e)
        {
            MH_TRGDEAN formTDA = Application.OpenForms.OfType<MH_TRGDEAN>().FirstOrDefault();

            if (formTDA != null)
            {
                formTDA.Hide();
            }

            MH_TRGDEAN_XOADEAN f = new MH_TRGDEAN_XOADEAN();
            f.ShowDialog();
        }

        private void btnTDA_NV_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Về màn hình quản lý thông tin cá nhân?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                this.Hide();
                MH_NHANVIEN f = new MH_NHANVIEN();
                f.ShowDialog();
                this.Close();
            }
        }

        private void btnTDA_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
