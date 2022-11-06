using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PRENKACI.Modal
{
    public partial class Mcustomer : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;
        Customer _ctm;

        public Mcustomer(Customer ctm)
        {
            _ctm = ctm;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mcustomer_FormClosing);
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mcustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ctm.initialData();
        }

        private void Mcustomer_Load(object sender, EventArgs e)
        {
            TbID.Enabled = false;
            BtnDelete.Enabled = _ctm.TypeForm != "I";

        }

        private void ClearForm()
        {
            TbID.Clear();
            TbName.Clear();
            TbBornPlace.Clear();
            TbNik.Clear();
            TbAddress.Clear();

            CbGender.SelectedIndex = 0;
            DtBorn.Value = DateTime.Now;

            BtnDelete.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TbID.Text))
            {
                int row;
                var msg = "Apakah anda yakin ingin hapus data ini?";
                DialogResult res = MessageBox.Show(msg, "Confimration", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        string query = "DELETE FROM customer WHERE id = @idData";
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
                        this.Close();
                    }

                }
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Action();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Action()
        {
            int row;
            string id = string.Empty;
            string query = string.Empty;
            var strDate = DateTime.Now.ToString("yyyyMMdd");
            var strTime = DateTime.Now.ToString("HHmmss");

            string msg = ValidationForm();
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string gender = (string)CbGender.SelectedItem == "Laki-laki" ? "L" : "P";
            var born = Convert.ToDecimal(DtBorn.Value.ToString("yyyyMMdd"));

            if (_ctm.TypeForm == "I")
            {
                id = "CUS" + DateTime.Now.ToString("yyyyMMddHHmmss");
                query = "INSERT INTO customer (id, name, born, born_place, nik, gender, " +
                    "address, created_date, created_time, updated_date, updated_time)" +
                    "VALUES (@id, @name, @born, @born_place, @nik, @gender, @address, " +
                    "@created_date, @created_time, @updated_date, @updated_time) ";
            }
            else
            {
                query = "UPDATE customer SET name = @name, born = @born, " +
                    "born_place = @born_place, nik = @nik, gender = @gender, address = @address " +
                    "updated_date = @updated_date, updated_time = @updated_time WHERE " +
                    "id = @id";
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", TbName.Text);
                    cmd.Parameters.AddWithValue("@born", born);
                    cmd.Parameters.AddWithValue("@born_place", TbBornPlace.Text);
                    cmd.Parameters.AddWithValue("@nik", TbNik.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", TbAddress.Text);
                    
                    if (_ctm.TypeForm == "I")
                    {
                        cmd.Parameters.AddWithValue("@created_date", strDate);
                        cmd.Parameters.AddWithValue("@created_time", strTime);
                    }

                    cmd.Parameters.AddWithValue("@updated_date", strDate);
                    cmd.Parameters.AddWithValue("@updated_time", strTime);
                    row = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            msg = row > 0 ? "Berhasil " + (_ctm.TypeForm == "I" ? "Insert" : "Update") + " Data"
                : "Terjadi Kesalahan, Gagal " + (_ctm.TypeForm == "I" ? "Insert" : "Update") + " Data";

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
            if (_ctm.TypeForm == "U")
                if (string.IsNullOrEmpty(TbID.Text))
                    return "ID harus diisi";

            if (string.IsNullOrEmpty(TbName.Text))
            {
                TbName.Select();
                return "Nama harus diisi";
            }
                

            if (string.IsNullOrEmpty(TbAddress.Text))
            {
                TbAddress.Select();
                return "Address harus diisi";
            }

            if (string.IsNullOrEmpty(TbBornPlace.Text))
            {
                TbBornPlace.Select();
                return "Born Place harus diisi";
            }

            if (string.IsNullOrEmpty(TbNik.Text))
            {
                TbNik.Select();
                return "NIK harus diisi";
            }

            if (CbGender.SelectedIndex == -1)
                return "Gender harus diisi";

            return string.Empty;
        }
    }
}
