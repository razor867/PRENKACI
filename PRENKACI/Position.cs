using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRENKACI.Modal;
using System.Configuration;
using System.Data.SqlClient;

namespace PRENKACI
{
    public partial class Position : Form
    {
        public string DfId;
        public string DfName;
        public string TypeForm;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Position()
        {
            InitializeComponent();
        }

        private void Position_Load(object sender, EventArgs e)
        {
            InitialData();
            TbSearch.Select();
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
            Mposition modalPosition = new Mposition(this);
            modalPosition.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var query = "SELECT id as ID, name as Position "
                + "FROM position WHERE name LIKE @name";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + TbSearch.Text + "%");
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    DgvPosition.DataSource = dt;
                    DgvPosition.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    DgvPosition.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                conn.Close();
            }
        }

        private void DgvPosition_DoubleClick(object sender, EventArgs e)
        {
            if (DgvPosition.SelectedRows.Count > 0)
            {
                DfId = DgvPosition.SelectedRows[0].Cells[0].Value + string.Empty;
                DfName = DgvPosition.SelectedRows[0].Cells[1].Value + string.Empty;
                TypeForm = "U";
                Mposition popup = new Mposition(this);
                popup.ShowDialog();
            }
        }

        public void InitialData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id as ID, name as Position FROM position "
                    + "ORDER BY created_date DESC, created_time DESC";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvPosition.DataSource = dt;
                DgvPosition.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvPosition.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
        }
    }
}
