using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRENKACI.Modal
{
    public partial class Mposition : Form
    {
        Position _pst;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Mposition(Position pst)
        {
            _pst = pst;
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mposition_Load(object sender, EventArgs e)
        {
            TbID.Enabled = false;

            if (_pst.TypeForm == "I")
            {
                TbPosition.Enabled = true;
                BtnDelete.Enabled = false;
                TbPosition.Select();
            }
            else
            {
                BtnDelete.Enabled = true;
                TbID.Text = _pst.DfId;
                TbPosition.Text = _pst.DfName;
            }
        }

        private void ClearForm()
        {
            TbID.Text = string.Empty;
            TbPosition.Text = string.Empty;
            TbPosition.Select();

            BtnDelete.Enabled = false;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Action();
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
                    string query = "DELETE FROM position WHERE id = @idData";
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
                    _pst.InitialData();
                    this.Close();
                }

            }
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
            var name = TbPosition.Text;

            if (_pst.TypeForm == "I")
            {
                query = "INSERT INTO position (id, name, created_date, created_time, "
                    + "updated_date, updated_time) "
                    + "values (@id, @name, @crdt, @crtm, @updt, @uptm)";
                id = "PST" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            else
                query = "UPDATE position SET name = @name, updated_date = @updt, updated_time = @uptm " +
                    "where id = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (_pst.TypeForm == "I")
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

            msg = row > 0 ? "Berhasil " + (_pst.TypeForm == "I" ? "Insert" : "Update") + " Data"
                : "Terjadi Kesalahan, Gagal " + (_pst.TypeForm == "I" ? "Insert" : "Update") + " Data";

            DialogResult dr = MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                if (msg.Contains("Berhasil"))
                {
                    _pst.InitialData();
                    ClearForm();
                    this.Close();
                }
            }

        }

        private string ValidationForm()
        {
            if (_pst.TypeForm == "U")
            {
                var id = TbID.Text;
                if (string.IsNullOrEmpty(id))
                    return "ID data tidak boleh kosong";
            }

            var name = TbPosition.Text;
            if (string.IsNullOrEmpty(name))
            {
                TbPosition.Select();
                return "Position tidak boleh kosong";
            }

            return string.Empty;
        }
    }
}
