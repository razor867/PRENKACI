using PRENKACI.Modal;
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

namespace PRENKACI
{
    public partial class Vehicle : Form
    {
        public string DfId;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;
        public string TypeForm;

        public Vehicle()
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
            Mvehicle mvehicle = new Mvehicle(this);
            mvehicle.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            InitialData(TbSearch.Text);
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            InitialData();
            TbSearch.Select();
        }

        public void InitialData(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT a.id as ID, a.name as Name, b.name as Manufacture, "
                    + "(CASE WHEN a.movers = 'B' THEN 'Belakang' " +
                    " WHEN a.movers = 'DB' THEN 'Depan Belakang' ELSE 'Depan' END) as Movers, " 
                    + "a.color as Color, a.police_no as PoliceNo "
                    + "FROM vehicle as a "
                    + "LEFT JOIN manufacture as b "
                    + "ON a.manufacture_id = b.manufacture_no "
                    + (string.IsNullOrEmpty(search) ? string.Empty : "WHERE a.name LIKE '%" + search + "%' ")
                    + "ORDER BY a.created_date DESC, a.created_time DESC";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvVehicle.DataSource = dt;
                DgvVehicle.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvVehicle.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvVehicle.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvVehicle.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvVehicle.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvVehicle.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                conn.Close();
            }
        }

        private void DgvVehicle_DoubleClick(object sender, EventArgs e)
        {
            if (DgvVehicle.SelectedRows.Count > 0)
            {
                DfId = DgvVehicle.SelectedRows[0].Cells[0].Value + string.Empty;
                TypeForm = "U";
                Mvehicle popup = new Mvehicle(this);
                popup.ShowDialog();
            }
        }
    }
}
