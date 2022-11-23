using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRENKACI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void PcManufacture_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manufacture manufacture = new Manufacture();
            manufacture.ShowDialog();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PcVehicle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vehicle vehicle = new Vehicle();
            vehicle.ShowDialog();
            this.Close();
        }

        private void PcCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.ShowDialog();
            this.Close();
        }

        private void PcRentData_Click(object sender, EventArgs e)
        {

        }

        private void PcEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Close();
        }

        private void PcPosition_Click(object sender, EventArgs e)
        {
            this.Hide();
            Position position = new Position();
            position.ShowDialog();
            this.Close();
        }
    }
}
