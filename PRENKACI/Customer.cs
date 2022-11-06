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
using PRENKACI.Modal;

namespace PRENKACI
{
    public partial class Customer : Form
    {
        public string DfId;
        public string TypeForm;
        string connStr = ConfigurationManager.ConnectionStrings["prenkaci"].ConnectionString;

        public Customer()
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
            Mcustomer mcustomer = new Mcustomer(this);
            mcustomer.ShowDialog();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            TbSearch.Select();
            initialData();
        }

        public void initialData(string search = "")
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT id as ID, name, " +
                    "(CONVERT(DATE, CAST(born AS VARCHAR(8)), 103)) as born, " +
                    "born_place, nik as NIK, " +
                    "(CASE WHEN gender = 'L' THEN 'Laki-laki' ELSE 'Perempuan' END) as gender, " +
                    "address FROM customer "
                    + (string.IsNullOrEmpty(search) ? string.Empty : "WHERE name LIKE '%" + search + "%' ")
                    + "ORDER BY created_date DESC, created_time DESC";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                DgvCustomer.DataSource = dt;
                DgvCustomer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvCustomer.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvCustomer.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DgvCustomer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                conn.Close();
            }
        }
    }
}
