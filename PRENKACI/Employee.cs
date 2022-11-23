using PRENKACI.Modal;
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

namespace PRENKACI
{
    public partial class Employee : Form
    {
        public string DfId;
        public string TypeForm;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            TbSearch.Select();
            InitialData();
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
            Memployee memployee = new Memployee(this);
            memployee.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            InitialData(TbSearch.Text);
        }

        private void DgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            if (DgvEmployee.SelectedRows.Count > 0)
            {
                DfId = DgvEmployee.SelectedRows[0].Cells[0].Value + string.Empty;
                TypeForm = "U";
                Memployee popup = new Memployee(this);
                popup.ShowDialog();
            }
        }

        public void InitialData(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT a.id as ID, a.name, " +
                    "(CONVERT(DATE, CAST(a.born AS VARCHAR(8)), 103)) as born, " +
                    "a.born_place, a.nik as NIK, " +
                    "(CASE WHEN a.gender = 'L' THEN 'Laki-laki' ELSE 'Perempuan' END) as gender, " +
                    "a.address, b.name as position FROM employee as a " +
                    "JOIN position as b ON " +
                    "a.position = b.id "
                    + (string.IsNullOrEmpty(search) ? string.Empty : "WHERE a.name LIKE '%" + search + "%' ")
                    + "ORDER BY a.created_date DESC, a.created_time DESC";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvEmployee.DataSource = dt;
                DgvEmployee.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvEmployee.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvEmployee.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvEmployee.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvEmployee.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvEmployee.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvEmployee.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvEmployee.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                conn.Close();
            }
        }
    }
}
