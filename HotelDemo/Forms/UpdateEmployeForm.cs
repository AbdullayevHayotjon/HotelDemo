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

namespace HotelDemo.Forms
{
    public partial class UpdateEmployeForm : Form
    {
        EmployeService employeService = new EmployeService();
        WorkPlaceService workPlaceService = new WorkPlaceService();
        public UpdateEmployeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = employeService.GetAllEmployes();
            workPlaceService.GetAllWorkPlace();
            cbEmployeType.DataSource = workPlaceService.GetAllType();
            cbEmployeType.SelectedIndex = -1;
            pnLogin.Visible = false;
            txPrice.ReadOnly = true;
            txPrice.Text = null;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            Employe employe = dataGridView.Rows[e.RowIndex].DataBoundItem as Employe;
            txId.Text = employe.Id.ToString();
            txFirstName.Text = employe.FirstName;
            txLastName.Text = employe.LastName;
            txSureName.Text = employe.SureName;
            txAge.Text = employe.Age.ToString();
            cbEmployeType.Text = employe.EmpType;
            txPrice.Text = employe.Salary.ToString();
            txLogin.Text = employe.Login;
            txPassword.Text = employe.Password;
        }

        private void cbEmployeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployeType.Text == "Admin" || cbEmployeType.Text == "Manager")
            {
                pnLogin.Visible = true;
            }
            else
            {
                pnLogin.Visible = false;
            }
            txPrice.Text = workPlaceService.GetPrice(cbEmployeType.Text).ToString();
            txPrice.ReadOnly = true;
        }

        private void btAddEmploye_Click(object sender, EventArgs e)
        {
            if (employeService.CheckNumber(txId.Text))
            {
                if(employeService.CheckId(int.Parse(txId.Text)))
                {
                    if (employeService.CheckNumber(txAge.Text) && int.Parse(txAge.Text) >= 18)
                    {
                        if (employeService.CheckProbel(cbEmployeType.Text))
                        {
                            if (cbEmployeType.Text == "Admin" || cbEmployeType.Text == "Manager")
                            {
                                if (employeService.CheckProbel(txLogin.Text) && txLogin.Text.Length >= 4)
                                {
                                    if (employeService.CheckLogin1(int.Parse(txId.Text), txLogin.Text))
                                    {
                                        if (employeService.CheckProbel(txPassword.Text) && txPassword.Text.Length >= 4)
                                        {
                                            Employe employe = new Employe()
                                            {
                                                Id = int.Parse(txId.Text),
                                                FirstName = txFirstName.Text,
                                                LastName = txLastName.Text,
                                                SureName = txSureName.Text,
                                                Age = int.Parse(txAge.Text),
                                                EmpType = cbEmployeType.Text,
                                                Salary = int.Parse(txPrice.Text),
                                                Login = txLogin.Text,
                                                Password = txPassword.Text
                                            };
                                            employeService.EmployeUpdate(employe);
                                            MessageBox.Show("O'zgartirildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            dataGridView1.DataSource = null;
                                            dataGridView1.DataSource = employeService.GetAllEmployes();
                                            txId.Clear();
                                            txFirstName.Clear();
                                            txLastName.Clear();
                                            txSureName.Clear();
                                            txAge.Clear();
                                            cbEmployeType.SelectedIndex = -1;
                                            txPrice.Clear();
                                            txLogin.Clear();
                                            txPassword.Clear();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Parol bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bu login oldindan mavjud", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Login bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                Employe employe = new Employe()
                                {
                                    Id = int.Parse(txId.Text),
                                    FirstName = txFirstName.Text,
                                    LastName = txLastName.Text,
                                    SureName = txSureName.Text, 
                                    Age = int.Parse(txAge.Text),
                                    EmpType = cbEmployeType.Text,
                                    Salary = int.Parse(txPrice.Text)
                                };
                                employeService.EmployeUpdate(employe);
                                MessageBox.Show("O'zgartirildi", "Muvaffaqqiyatli!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = employeService.GetAllEmployes();
                                txId.Clear();
                                txFirstName.Clear();
                                txLastName.Clear();
                                txSureName.Clear();
                                txAge.Clear();
                                cbEmployeType.SelectedIndex = -1;
                                txPrice.Clear();
                                txLogin.Clear();
                                txPassword.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ishchi turini tanlamadingiz", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yosh bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Bunday id mavjud emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Id bunday bo'lishi mumkin emas", "Xatolik!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
