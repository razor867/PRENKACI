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
using PRENKACI.Modal;
using System.Configuration;

namespace PRENKACI
{
    public partial class Manufacture : Form
    {
        public string DfId;
        public string DfNama;
        public string TypeForm;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Manufacture()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TypeForm = "I";
            Mmanufacture modalManucafure = new Mmanufacture(this);
            modalManucafure.ShowDialog();
        }

        private void Manufacture_Load(object sender, EventArgs e)
        {
            InitialData();
            TbSearch.Select();
        }

        public void InitialData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT manufacture_no as ID, name as Manufacture FROM manufacture " 
                    + "ORDER BY created_date DESC, created_time DESC";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvManufacture.DataSource = dt;
                DgvManufacture.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvManufacture.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var query = "SELECT manufacture_no as ID, name as Manufacture "
                + "FROM manufacture WHERE manufacture_no LIKE @id OR name LIKE @name";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", "%" + TbSearch.Text + "%");
                    cmd.Parameters.AddWithValue("@name", "%" + TbSearch.Text + "%");
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    DgvManufacture.DataSource = dt;
                    DgvManufacture.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    DgvManufacture.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                conn.Close();
            }
        }

        private void DgvManufacture_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DgvManufacture.SelectedRows.Count > 0)
            {
                DfId = DgvManufacture.SelectedRows[0].Cells[0].Value + string.Empty;
                DfNama = DgvManufacture.SelectedRows[0].Cells[1].Value + string.Empty;
                TypeForm = "U";
                Mmanufacture popup = new Mmanufacture(this);
                popup.ShowDialog();
            }
        }

        private void TbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox currentContainer = (TextBox)sender;
            int currentPosition = currentContainer.SelectionStart;

            currentContainer.Text = currentContainer.Text.ToUpper();
            currentContainer.SelectionStart = currentPosition++;
        }
    }
}
