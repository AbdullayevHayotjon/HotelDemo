namespace HotelDemo.Forms
{
    partial class DeleteEmployeForm
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
            lbId = new Label();
            txId = new TextBox();
            pnLogin = new Panel();
            txLogin = new TextBox();
            txPassword = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btAddEmploye = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbEmployeType = new ComboBox();
            txSureName = new TextBox();
            txAge = new TextBox();
            txPrice = new TextBox();
            txFirstName = new TextBox();
            txLastName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            pnLogin.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(1210, 716);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 54;
            button1.Text = "Orqaga";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(758, 65);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 53;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // txSearch
            // 
            txSearch.Location = new Point(530, 66);
            txSearch.Name = "txSearch";
            txSearch.Size = new Size(197, 27);
            txSearch.TabIndex = 52;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, sureNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, empTypeDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeBindingSource;
            dataGridView1.Location = new Point(111, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1179, 188);
            dataGridView1.TabIndex = 51;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            btExit.Location = new Point(1210, 39);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 72;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            btExit.Click += btExit_Click;
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(322, 326);
            lbId.Name = "lbId";
            lbId.Size = new Size(22, 20);
            lbId.TabIndex = 104;
            lbId.Text = "Id";
            // 
            // txId
            // 
            txId.Location = new Point(370, 323);
            txId.Name = "txId";
            txId.Size = new Size(95, 27);
            txId.TabIndex = 103;
            // 
            // pnLogin
            // 
            pnLogin.Controls.Add(txLogin);
            pnLogin.Controls.Add(txPassword);
            pnLogin.Controls.Add(label8);
            pnLogin.Controls.Add(label7);
            pnLogin.Location = new Point(587, 633);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(278, 125);
            pnLogin.TabIndex = 102;
            // 
            // txLogin
            // 
            txLogin.Location = new Point(128, 20);
            txLogin.Name = "txLogin";
            txLogin.Size = new Size(135, 27);
            txLogin.TabIndex = 40;
            // 
            // txPassword
            // 
            txPassword.Location = new Point(128, 80);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(135, 27);
            txPassword.TabIndex = 36;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 27);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 48;
            label7.Text = "Login";
            // 
            // btAddEmploye
            // 
            btAddEmploye.Location = new Point(607, 772);
            btAddEmploye.Name = "btAddEmploye";
            btAddEmploye.Size = new Size(245, 29);
            btAddEmploye.TabIndex = 101;
            btAddEmploye.Text = "O'chirish";
            btAddEmploye.UseVisualStyleBackColor = true;
            btAddEmploye.Click += btAddEmploye_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(607, 607);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 100;
            label6.Text = "Oylik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(607, 544);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 99;
            label5.Text = "Employe type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(607, 489);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 98;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(607, 432);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 97;
            label3.Text = "Sure Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(607, 370);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 96;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(607, 322);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 95;
            label1.Text = "First Name";
            // 
            // cbEmployeType
            // 
            cbEmployeType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployeType.FormattingEnabled = true;
            cbEmployeType.Location = new Point(717, 536);
            cbEmployeType.Name = "cbEmployeType";
            cbEmployeType.Size = new Size(135, 28);
            cbEmployeType.TabIndex = 94;
            cbEmployeType.SelectedIndexChanged += cbEmployeType_SelectedIndexChanged;
            // 
            // txSureName
            // 
            txSureName.Location = new Point(717, 425);
            txSureName.Name = "txSureName";
            txSureName.Size = new Size(135, 27);
            txSureName.TabIndex = 93;
            // 
            // txAge
            // 
            txAge.Location = new Point(717, 482);
            txAge.Name = "txAge";
            txAge.Size = new Size(135, 27);
            txAge.TabIndex = 92;
            // 
            // txPrice
            // 
            txPrice.Location = new Point(717, 600);
            txPrice.Name = "txPrice";
            txPrice.Size = new Size(135, 27);
            txPrice.TabIndex = 91;
            // 
            // txFirstName
            // 
            txFirstName.Location = new Point(717, 315);
            txFirstName.Name = "txFirstName";
            txFirstName.Size = new Size(135, 27);
            txFirstName.TabIndex = 90;
            // 
            // txLastName
            // 
            txLastName.Location = new Point(717, 367);
            txLastName.Name = "txLastName";
            txLastName.Size = new Size(135, 27);
            txLastName.TabIndex = 89;
            // 
            // DeleteEmployeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(lbId);
            Controls.Add(txId);
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
            Controls.Add(btExit);
            Controls.Add(button1);
            Controls.Add(btSearch);
            Controls.Add(txSearch);
            Controls.Add(dataGridView1);
            Name = "DeleteEmployeForm";
            Text = "DeleteEmployeForm";
            Load += DeleteEmployeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            pnLogin.ResumeLayout(false);
            pnLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btSearch;
        private TextBox txSearch;
        private DataGridView dataGridView1;
        private Button btExit;
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
        private Label lbId;
        private TextBox txId;
        private Panel pnLogin;
        private TextBox txLogin;
        private TextBox txPassword;
        private Label label8;
        private Label label7;
        private Button btAddEmploye;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbEmployeType;
        private TextBox txSureName;
        private TextBox txAge;
        private TextBox txPrice;
        private TextBox txFirstName;
        private TextBox txLastName;
    }
}