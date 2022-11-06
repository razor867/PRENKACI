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
using System.Windows.Interop;

namespace PRENKACI.Modal
{
    public partial class Mvehicle : Form
    {
        Vehicle _vhc;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Mvehicle(Vehicle vhc)
        {
            _vhc = vhc;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mvehicle_FormClosing);
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mvehicle_FormClosing(object sender, FormClosingEventArgs e)
        {
            _vhc.InitialData();
        }

        private void Mvehicle_Load(object sender, EventArgs e)
        {
            TbID.Enabled = false;

            var query = "SELECT manufacture_no as id, name FROM manufacture";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    CbManufacture.DataSource = dt;
                    CbManufacture.DisplayMember = "name";
                    CbManufacture.ValueMember = "id";
                }
                conn.Close();
            }

            if (_vhc.TypeForm == "U")
            {
                query = "SELECT id, name, manufacture_id, movers, color, police_no " +
                    "FROM vehicle WHERE id = @id";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(@query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _vhc.DfId);
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            TbID.Text = (dt.Rows[0].Field<string>(0)).ToString();
                            TbName.Text = dt.Rows[0].Field<string>(1).ToString();
                            CbManufacture.SelectedValue = dt.Rows[0].Field<string>(2);
                            CbMovers.SelectedItem = (dt.Rows[0].Field<string>(3)) == "B" ? "Belakang" : ((dt.Rows[0].Field<string>(3)) == "DB" ? "Depan Belakang" : "Depan");
                            TbColor.Text = dt.Rows[0].Field<string>(4);
                            TbPoliceNo.Text = dt.Rows[0].Field<string>(5);
                        }
                    }
                    conn.Close();
                }
            }
            else
                ClearForm();

            BtnDelete.Enabled = _vhc.TypeForm != "I";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            TbID.Clear();
            TbName.Clear();
            TbColor.Clear();
            TbPoliceNo.Clear();
            CbManufacture.Text = String.Empty;
            CbMovers.Text = String.Empty;
            BtnDelete.Enabled = false;

            TbName.Select();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Action();
        }

        private void Action()
        {
            var row = 0;
            var msg = ValidationForm();
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var id = string.Empty;
            var query = string.Empty;

            if (_vhc.TypeForm == "I")
            {
                id = "VHC" + DateTime.Now.ToString("yyyyMMddHHmmss");
                query = "INSERT INTO vehicle (id, name, manufacture_id, movers, color, "
                    + "police_no, created_date, created_time, updated_date, updated_time) "
                    + "VALUES (@id, @name, @manufacture, @movers, @color, "
                    + "@police, @chdt, @chtm, @updt, @uptm)";
            }
            else
            {
                id = TbID.Text;
                query = "UPDATE vehicle SET name = @name, manufacture_id = @manufacture, movers = @movers, " +
                    "color = @color, police_no = @police, updated_date = @updt, updated_time = @uptm " +
                    "where id = @id";
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", TbName.Text);
                    cmd.Parameters.AddWithValue("@manufacture", CbManufacture.SelectedValue);
                    cmd.Parameters.AddWithValue("@movers", (string)CbMovers.SelectedItem == "Depan" ? "D" : (string)CbMovers.SelectedItem == "Belakang" ? "B" : "DB");
                    cmd.Parameters.AddWithValue("@color", TbColor.Text);
                    cmd.Parameters.AddWithValue("@police", TbPoliceNo.Text);
                    cmd.Parameters.AddWithValue("@updt", DateTime.Now.ToString("yyyyMMdd"));
                    cmd.Parameters.AddWithValue("@uptm", DateTime.Now.ToString("HHmmss"));

                    if (_vhc.TypeForm == "I")
                    {
                        cmd.Parameters.AddWithValue("@chdt", DateTime.Now.ToString("yyyyMMdd"));
                        cmd.Parameters.AddWithValue("@chtm", DateTime.Now.ToString("HHmmss"));
                    }
                    row = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            msg = row > 0 ? "Berhasil " + (_vhc.TypeForm == "I" ? "Insert" : "Update") + " Data"
                : "Terjadi Kesalahan, Gagal " + (_vhc.TypeForm == "I" ? "Insert" : "Update") + " Data";

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
            if (_vhc.TypeForm != "I")
                if (string.IsNullOrEmpty(TbID.Text))
                    return "ID tidak boleh kosong";

            if (string.IsNullOrEmpty(TbName.Text))
            {
                TbName.Select();
                return "Nama Kendaraan tidak boleh kosong";
            }

            if (string.IsNullOrEmpty(TbColor.Text))
            {
                TbColor.Select();
                return "Warna tidak boleh kosong";
            }

            if (string.IsNullOrEmpty(TbPoliceNo.Text))
            {
                TbPoliceNo.Select();
                return "Nomor Polisi tidak boleh kosong";
            }

            if (CbMovers.SelectedIndex == -1)
            {
                CbMovers.Select();
                return "Roda Penggerak harus dipilih";
            }

            if (CbManufacture.SelectedIndex == -1)
            {
                CbManufacture.Select();
                return "Manufacture harus dipilih";
            }

            return string.Empty;
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
                        string query = "DELETE FROM vehicle WHERE id = @idData";
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
    }
}
