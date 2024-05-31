using HotelDemo.EmployeControl;
using HotelDemo.Forms;
using HotelDemo.Services;
using System.Windows.Forms;

namespace HotelDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.StartPosition = FormStartPosition.CenterScreen;
            adminForm.Show();
        }
        private void btManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }
    }
}
