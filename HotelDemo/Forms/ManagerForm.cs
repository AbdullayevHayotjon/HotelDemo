using HotelDemo.EmployeControl;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelDemo.Forms
{
    public partial class ManagerForm : Form
    {
        EmployeService employeService = new EmployeService();
        public ManagerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = employeService.GetAllEmployes();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendanceReportForm attendanceReportForm = new AttendanceReportForm();
            attendanceReportForm.StartPosition = FormStartPosition.CenterScreen;
            attendanceReportForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkPlaceReportForm workPlaceReportForm = new WorkPlaceReportForm();
            workPlaceReportForm.StartPosition = FormStartPosition.CenterScreen;
            workPlaceReportForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeForm addEmployeForm = new AddEmployeForm();
            addEmployeForm.StartPosition = FormStartPosition.CenterScreen;
            addEmployeForm.Show();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployeForm updateEmployeForm = new UpdateEmployeForm();
            updateEmployeForm.StartPosition = FormStartPosition.CenterScreen;
            updateEmployeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteEmployeForm deleteEmployeForm = new DeleteEmployeForm();
            deleteEmployeForm.StartPosition = FormStartPosition.CenterScreen;
            deleteEmployeForm.Show();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employeService.GetSeachList(txSearch.Text);
        }
    }
}
