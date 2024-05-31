using HotelDemo.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelDemo.Forms
{
    public partial class UpdateEmployeForm : Form
    {
        EmployeService employeService = new EmployeService();
        public UpdateEmployeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = employeService.GetAllEmployes();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm managerForm = new ManagerForm();
            managerForm.StartPosition = FormStartPosition.CenterScreen;
            managerForm.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeService.GetSeachList(txSearch.Text);
        }

        private void UpdateEmployeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
