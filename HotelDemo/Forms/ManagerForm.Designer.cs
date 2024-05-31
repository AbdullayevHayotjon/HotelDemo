namespace HotelDemo.Forms
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btSearch = new Button();
            txSearch = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sureNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeBindingSource = new BindingSource(components);
            btExit = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(405, 365);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 27;
            button3.Text = "Qo'shish";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(623, 365);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 26;
            button2.Text = "Yangilash";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(843, 365);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 25;
            button1.Text = "O'chirish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(707, 108);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 24;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txSearch
            // 
            txSearch.Location = new Point(478, 109);
            txSearch.Name = "txSearch";
            txSearch.Size = new Size(197, 27);
            txSearch.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, sureNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, empTypeDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeBindingSource;
            dataGridView1.Location = new Point(97, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 188);
            dataGridView1.TabIndex = 22;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sureNameDataGridViewTextBoxColumn
            // 
            sureNameDataGridViewTextBoxColumn.DataPropertyName = "SureName";
            sureNameDataGridViewTextBoxColumn.HeaderText = "SureName";
            sureNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            sureNameDataGridViewTextBoxColumn.Name = "sureNameDataGridViewTextBoxColumn";
            sureNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // empTypeDataGridViewTextBoxColumn
            // 
            empTypeDataGridViewTextBoxColumn.DataPropertyName = "EmpType";
            empTypeDataGridViewTextBoxColumn.HeaderText = "EmpType";
            empTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            empTypeDataGridViewTextBoxColumn.Name = "empTypeDataGridViewTextBoxColumn";
            empTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            loginDataGridViewTextBoxColumn.HeaderText = "Login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeBindingSource
            // 
            employeBindingSource.DataSource = typeof(EmployeControl.Employe);
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F);
            btExit.Location = new Point(1152, 59);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 28;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(405, 538);
            button4.Name = "button4";
            button4.Size = new Size(159, 29);
            button4.TabIndex = 29;
            button4.Text = "Davomat hisoboti";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(772, 538);
            button5.Name = "button5";
            button5.Size = new Size(167, 29);
            button5.TabIndex = 30;
            button5.Text = "Ishchi o'rni hisoboti";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btExit);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btSearch);
            Controls.Add(txSearch);
            Controls.Add(dataGridView1);
            Name = "ManagerForm";
            Text = "ManagerForm";
            Load += ManagerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button btSearch;
        private TextBox txSearch;
        private DataGridView dataGridView1;
        private Button btExit;
        private Button button4;
        private Button button5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sureNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource employeBindingSource;
    }
}