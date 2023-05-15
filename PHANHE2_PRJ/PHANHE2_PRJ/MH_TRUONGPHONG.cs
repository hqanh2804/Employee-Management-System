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
    public partial class MH_TRUONGPHONG : Form
    {
        OracleConnection con = new OracleConnection(new CONNECTION_STRING().getString());
        public MH_TRUONGPHONG()
        {
            InitializeComponent();
            display_DSNVTRUONGPHONG();
            display_PHANCONG_TRUONGPHONG();
        }


        public void display_DSNVTRUONGPHONG()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.v_NHANVIEN_truongphong", con);
                adpt.Fill(dt);
                DANHSACHNHANVIENTRUONGPHONG.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void display_PHANCONG_TRUONGPHONG()
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                OracleDataAdapter adpt = new OracleDataAdapter("SELECT * FROM QUANTRIHT.v_phancong_truongphong", con);
                adpt.Fill(dt);
                PHANCONGTRUONGPHONG.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        private void MH_TRUONGPHONG_Load(object sender, EventArgs e)
        {

        }

        private void btn_GIAODIEN_NV_Click(object sender, EventArgs e)
        {
            MH_QLTRUCTIEP displayForm = Application.OpenForms.OfType<MH_QLTRUCTIEP>().FirstOrDefault();
            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_NHANVIEN f = new MH_NHANVIEN();
            f.ShowDialog();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            MH_TRUONGPHONG displayForm = Application.OpenForms.OfType<MH_TRUONGPHONG>().FirstOrDefault();
            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_TRUONGPHONG_CAPNHATPHANCONG f = new MH_TRUONGPHONG_CAPNHATPHANCONG();
            f.ShowDialog();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            MH_TRUONGPHONG displayForm = Application.OpenForms.OfType<MH_TRUONGPHONG>().FirstOrDefault();
            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_TRUONGPHONG_XOAPHANCONG f = new MH_TRUONGPHONG_XOAPHANCONG();
            f.ShowDialog();
        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            MH_TRUONGPHONG displayForm = Application.OpenForms.OfType< MH_TRUONGPHONG>().FirstOrDefault();
            if (displayForm != null)
            {
                displayForm.Hide();
            }

            MH_TRUONGPHONG_THEMPHANCONG f = new MH_TRUONGPHONG_THEMPHANCONG();
            f.ShowDialog();
        }

        private void DANHSACHNHANVIENTRUONGPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PHANCONGTRUONGPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
