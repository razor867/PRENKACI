using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PRENKACI.Modal
{
    public partial class Mmanufacture : Form
    {
        Manufacture _mfc;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Mmanufacture(Manufacture mfc)
        {
            _mfc = mfc;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mmanufacture_FormClosing);
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mmanufacture_Load(object sender, EventArgs e)
        {
            TbID.Enabled = false;

            if (_mfc.TypeForm == "I")
            {
                TbManufacture.Enabled = true;
                BtnDelete.Enabled = false;
                TbManufacture.Select();
            }
            else
            {
                BtnDelete.Enabled = true;
                TbID.Text = _mfc.DfId;
                TbManufacture.Text = _mfc.DfNama;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            TbID.Text = string.Empty;
            TbManufacture.Text = string.Empty;
            TbManufacture.Select();

            BtnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            Action();
        }

        private void Action()
        {
            int row;
            var query = string.Empty;
            var msg = ValidationForm();
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = TbID.Text;
            var name = TbManufacture.Text;

            if (_mfc.TypeForm == "I")
            {
                query = "INSERT INTO manufacture (manufacture_no, name, created_date, created_time, " 
                    + "updated_date, updated_time) "
                    + "values (@id, @name, @crdt, @crtm, @updt, @uptm)";
                id = "MFC" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else
                query = "UPDATE manufacture SET name = @name, updated_date = @updt, updated_time = @uptm " +
                    "where manufacture_no = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (_mfc.TypeForm == "I")
                    {
                        cmd.Parameters.AddWithValue("@crdt", Convert.ToDecimal(DateTime.Now.ToString("yyyyMMdd")));
                        cmd.Parameters.AddWithValue("@crtm", Convert.ToDecimal(DateTime.Now.ToString("HHmmss")));
                    }

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@updt", Convert.ToDecimal(DateTime.Now.ToString("yyyyMMdd")));
                    cmd.Parameters.AddWithValue("@uptm", Convert.ToDecimal(DateTime.Now.ToString("HHmmss")));
                    row = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            msg = row > 0 ? "Berhasil " + (_mfc.TypeForm == "I" ? "Insert" : "Update") + " Data"
                : "Terjadi Kesalahan, Gagal " + (_mfc.TypeForm == "I" ? "Insert" : "Update") + " Data";

            DialogResult dr = MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                if (msg.Contains("Berhasil"))
                {
                    ClearForm();
                    this.Close();
                }
            }

        }

        private string ValidationForm()
        {
            if (_mfc.TypeForm == "U")
            {
                var id = TbID.Text;
                if (string.IsNullOrEmpty(id))
                    return "ID data tidak boleh kosong";
            }

            var name = TbManufacture.Text;
            if (string.IsNullOrEmpty(name))
            {
                TbManufacture.Select();
                return "Nama Manufacture tidak boleh kosong";
            }

            return string.Empty;
        }

        private void Mmanufacture_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mfc.InitialData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int row;
            var msg = "Apakah anda yakin ingin hapus data ini?";
            DialogResult res = MessageBox.Show(msg, "Confimration", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    string query = "DELETE FROM manufacture WHERE manufacture_no = @idData";
                    conn.Open();
                    using (SqlCommand com = new SqlCommand(query, conn))
                    {
                        com.Parameters.AddWithValue("@idData", TbID.Text);
                        row = com.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                msg = row > 0 ? "Berhasil delete"
                    : "Terjadi kesalahan, gagal delete";
                DialogResult dr = MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    ClearForm();
                    _mfc.InitialData();
                    this.Close();
                }

            }
        }
    }
}
