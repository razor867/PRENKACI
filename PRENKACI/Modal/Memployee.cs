using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRENKACI.Modal
{
    public partial class Memployee : Form
    {
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;
        Employee _emp;

        public Memployee(Employee emp)
        {
            _emp = emp;
            InitializeComponent();
        }

        private void Memployee_Load(object sender, EventArgs e)
        {
            TbID.Enabled = false;
            BtnDelete.Enabled = _emp.TypeForm != "I";

            var query = "SELECT id, name FROM position";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    CbPosition.DataSource = dt;
                    CbPosition.DisplayMember = "name";
                    CbPosition.ValueMember = "id";
                }
                conn.Close();
            }

            if (_emp.TypeForm == "U")
            {
                query = "SELECT id, name, born, born_place, nik, " +
                    "(CASE WHEN gender = 'L' THEN 'Laki-laki' ELSE 'Perempuan' END) as gender, " +
                    "address, position " +
                    "FROM employee WHERE id = @id";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(@query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _emp.DfId);
                        cmd.ExecuteNonQuery();

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            var year = dt.Rows[0].Field<decimal>(2).ToString().Substring(0, 4);
                            var month = dt.Rows[0].Field<decimal>(2).ToString().Substring(4, 2);
                            var day = dt.Rows[0].Field<decimal>(2).ToString().Substring(6, 2);

                            TbID.Text = (dt.Rows[0].Field<string>(0)).ToString();
                            TbName.Text = dt.Rows[0].Field<string>(1).ToString();
                            TbBornPlace.Text = dt.Rows[0].Field<string>(3).ToString();
                            TbNIK.Text = dt.Rows[0].Field<string>(4).ToString();
                            CbGender.SelectedItem = dt.Rows[0].Field<string>(5).ToString();
                            TbAddress.Text = dt.Rows[0].Field<string>(6).ToString();
                            DtBorn.Value = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                            CbPosition.SelectedValue = dt.Rows[0].Field<string>(7);
                        }
                    }
                    conn.Close();
                }
            }
            else
                ClearForm();
        }

        private void ClearForm()
        {
            TbID.Clear();
            TbName.Clear();
            TbBornPlace.Clear();
            TbNIK.Clear();
            TbAddress.Clear();

            CbGender.SelectedIndex = 0;
            CbPosition.Text = String.Empty;
            DtBorn.Value = DateTime.Now;

            BtnDelete.Enabled = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Action();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
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
                        string query = "DELETE FROM employee WHERE id = @idData";
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
                        _emp.InitialData();
                        this.Close();
                    }

                }
            }
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

            if (_emp.TypeForm == "I")
            {
                id = "EMP" + DateTime.Now.ToString("yyyyMMddHHmmss");
                query = "INSERT INTO employee (id, name, born, born_place, nik, gender, " +
                    "address, position, created_date, created_time, updated_date, updated_time)" +
                    "VALUES (@id, @name, @born, @born_place, @nik, @gender, @address, @position, " +
                    "@created_date, @created_time, @updated_date, @updated_time) ";
            }
            else
            {
                id = TbID.Text;
                query = "UPDATE employee SET name = @name, born = @born, " +
                    "born_place = @born_place, nik = @nik, gender = @gender, address = @address, position = @position, " +
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
                    cmd.Parameters.AddWithValue("@nik", TbNIK.Text);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", TbAddress.Text);
                    cmd.Parameters.AddWithValue("@position", CbPosition.SelectedValue);

                    if (_emp.TypeForm == "I")
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

            msg = row > 0 ? "Berhasil " + (_emp.TypeForm == "I" ? "Insert" : "Update") + " Data"
                : "Terjadi Kesalahan, Gagal " + (_emp.TypeForm == "I" ? "Insert" : "Update") + " Data";

            DialogResult dr = MessageBox.Show(msg, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                if (msg.Contains("Berhasil"))
                {
                    ClearForm();
                    _emp.InitialData();
                    this.Close();
                }
            }
        }

        private string ValidationForm()
        {
            if (_emp.TypeForm == "U")
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

            if (string.IsNullOrEmpty(TbNIK.Text))
            {
                TbNIK.Select();
                return "NIK harus diisi";
            }

            if (CbGender.SelectedIndex == -1)
                return "Gender harus diisi";

            if (CbPosition.Text == String.Empty)
                return "Gender harus diisi";

            return string.Empty;
        }
    }
}
