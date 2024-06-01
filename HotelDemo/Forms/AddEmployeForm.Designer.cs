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
            employeBindingSource = new BindingSource(components);
            button1 = new Button();
            txLastName = new TextBox();
            txFirstName = new TextBox();
            txPassword = new TextBox();
            txPrice = new TextBox();
            txAge = new TextBox();
            txSureName = new TextBox();
            txLogin = new TextBox();
            cbEmployeType = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btAddEmploye = new Button();
            pnLogin = new Panel();
            dataGridView1 = new DataGridView();
            employeBindingSource1 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sureNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            empTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).BeginInit();
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
            btSearch.Location = new Point(751, 32);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 31;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txSearch
            // 
            txSearch.Location = new Point(522, 33);
            txSearch.Name = "txSearch";
            txSearch.Size = new Size(197, 27);
            txSearch.TabIndex = 30;
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
            // txLastName
            // 
            txLastName.Location = new Point(710, 332);
            txLastName.Name = "txLastName";
            txLastName.Size = new Size(135, 27);
            txLastName.TabIndex = 34;
            // 
            // txFirstName
            // 
            txFirstName.Location = new Point(710, 280);
            txFirstName.Name = "txFirstName";
            txFirstName.Size = new Size(135, 27);
            txFirstName.TabIndex = 35;
            // 
            // txPassword
            // 
            txPassword.Location = new Point(128, 80);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(135, 27);
            txPassword.TabIndex = 36;
            // 
            // txPrice
            // 
            txPrice.Location = new Point(710, 565);
            txPrice.Name = "txPrice";
            txPrice.Size = new Size(135, 27);
            txPrice.TabIndex = 37;
            // 
            // txAge
            // 
            txAge.Location = new Point(710, 447);
            txAge.Name = "txAge";
            txAge.Size = new Size(135, 27);
            txAge.TabIndex = 38;
            // 
            // txSureName
            // 
            txSureName.Location = new Point(710, 390);
            txSureName.Name = "txSureName";
            txSureName.Size = new Size(135, 27);
            txSureName.TabIndex = 39;
            // 
            // txLogin
            // 
            txLogin.Location = new Point(128, 20);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(135, 27);
            txLogin.TabIndex = 40;
            // 
            // cbEmployeType
            // 
            cbEmployeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployeType.FormattingEnabled = true;
            cbEmployeType.Location = new Point(710, 501);
            cbEmployeType.Name = "cbEmployeType";
            cbEmployeType.Size = new Size(135, 28);
            cbEmployeType.TabIndex = 41;
            cbEmployeType.SelectedIndexChanged += cbEmployeType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(600, 287);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 42;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(600, 335);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 43;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 397);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 44;
            label3.Text = "Sure Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 454);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 45;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 509);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 46;
            label5.Text = "Employe type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 572);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 47;
            label6.Text = "Oylik";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 27);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 48;
            label7.Text = "Login";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 83);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 49;
            label8.Text = "Parol";
            // 
            // btAddEmploye
            // 
            btAddEmploye.Location = new Point(600, 737);
            btAddEmploye.Name = "btAddEmploye";
            btAddEmploye.Size = new Size(245, 29);
            btAddEmploye.TabIndex = 50;
            btAddEmploye.Text = "Qo'shish";
            btAddEmploye.UseVisualStyleBackColor = true;
            btAddEmploye.Click += btAddEmploye_Click;
            // 
            // pnLogin
            // 
            pnLogin.Controls.Add(txLogin);
            pnLogin.Controls.Add(txPassword);
            pnLogin.Controls.Add(label8);
            pnLogin.Controls.Add(label7);
            pnLogin.Location = new Point(580, 598);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(278, 125);
            pnLogin.TabIndex = 51;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, sureNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, empTypeDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeBindingSource1;
            dataGridView1.Location = new Point(135, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 207);
            dataGridView1.TabIndex = 52;
            // 
            // employeBindingSource1
            // 
            employeBindingSource1.DataSource = typeof(EmployeControl.Employe);
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
            // AddEmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(dataGridView1);
            Controls.Add(pnLogin);
            Controls.Add(btAddEmploye);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbEmployeType);
            Controls.Add(txSureName);
            Controls.Add(txAge);
            Controls.Add(txPrice);
            Controls.Add(txFirstName);
            Controls.Add(txLastName);
            Controls.Add(button1);
            Controls.Add(btExit);
            Controls.Add(btSearch);
            Controls.Add(txSearch);
            Name = "AddEmployeForm";
            Text = "AddEmployeForm";
            Load += AddEmployeForm_Load;
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btExit;
        private Button btSearch;
        private TextBox txSearch;
        private Button button1;
        private TextBox txLastName;
        private TextBox txFirstName;
        private TextBox txPassword;
        private TextBox txPrice;
        private TextBox txAge;
        private TextBox txSureName;
        private TextBox txLogin;
        private ComboBox cbEmployeType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btAddEmploye;
        private BindingSource employeBindingSource;
        private Panel pnLogin;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sureNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource employeBindingSource1;
    }
}