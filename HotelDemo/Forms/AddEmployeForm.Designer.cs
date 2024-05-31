namespace HotelDemo.Forms
{
    partial class AddEmployeForm
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
            btExit = new Button();
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F);
            btExit.Location = new Point(1200, 26);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 32;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(751, 70);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 31;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txSearch
            // 
            txSearch.Location = new Point(522, 71);
            txSearch.Name = "txSearch";
            txSearch.Size = new Size(197, 27);
            txSearch.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, sureNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, empTypeDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeBindingSource;
            dataGridView1.Location = new Point(116, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1180, 188);
            dataGridView1.TabIndex = 29;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(1200, 737);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 33;
            button1.Text = "Orqaga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 347);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 27);
            textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 423);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 27);
            textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(175, 649);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 27);
            textBox4.TabIndex = 37;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(175, 547);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 27);
            textBox5.TabIndex = 38;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(175, 479);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(135, 27);
            textBox6.TabIndex = 39;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(444, 363);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(112, 27);
            textBox7.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(175, 596);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 28);
            comboBox1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 354);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 42;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 420);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 43;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 486);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 44;
            label3.Text = "Sure Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 554);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 45;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 604);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 46;
            label5.Text = "Employe type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 656);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 47;
            label6.Text = "Oylik";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 370);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 48;
            label7.Text = "Login";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 430);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 49;
            label8.Text = "Parol";
            // 
            // button2
            // 
            button2.Location = new Point(399, 500);
            button2.Name = "button2";
            button2.Size = new Size(84, 29);
            button2.TabIndex = 50;
            button2.Text = "Qo'shish";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddEmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btExit);
            Controls.Add(btSearch);
            Controls.Add(txSearch);
            Controls.Add(dataGridView1);
            Name = "AddEmployeForm";
            Text = "AddEmployeForm";
            Load += AddEmployeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btSearch;
        private TextBox txSearch;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
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