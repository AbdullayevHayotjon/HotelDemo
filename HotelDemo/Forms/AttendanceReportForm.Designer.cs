namespace HotelDemo.Forms
{
    partial class AttendanceReportForm
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
            dataGridView1 = new DataGridView();
            empControlBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sureNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enterTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btExit = new Button();
            btBack = new Button();
            btSearch = new Button();
            txSearchAttendance = new TextBox();
            txId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empControlBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, sureNameDataGridViewTextBoxColumn, enterTimeDataGridViewTextBoxColumn, endTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = empControlBindingSource;
            dataGridView1.Location = new Point(224, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(805, 188);
            dataGridView1.TabIndex = 0;
            // 
            // empControlBindingSource
            // 
            empControlBindingSource.DataSource = typeof(EmployeControl.EmpControl);
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
            // enterTimeDataGridViewTextBoxColumn
            // 
            enterTimeDataGridViewTextBoxColumn.DataPropertyName = "EnterTime";
            enterTimeDataGridViewTextBoxColumn.HeaderText = "EnterTime";
            enterTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            enterTimeDataGridViewTextBoxColumn.Name = "enterTimeDataGridViewTextBoxColumn";
            enterTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F);
            btExit.Location = new Point(1213, 61);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 11;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F);
            btBack.Location = new Point(1213, 710);
            btBack.Name = "btBack";
            btBack.Size = new Size(96, 29);
            btBack.TabIndex = 12;
            btBack.Text = "Orqaga";
            btBack.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(699, 185);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 16;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // txSearchAttendance
            // 
            txSearchAttendance.Location = new Point(470, 186);
            txSearchAttendance.Name = "txSearchAttendance";
            txSearchAttendance.Size = new Size(197, 27);
            txSearchAttendance.TabIndex = 15;
            // 
            // txId
            // 
            txId.Location = new Point(651, 453);
            txId.Name = "txId";
            txId.Size = new Size(125, 27);
            txId.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 456);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 19;
            label1.Text = "Ishchi Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(514, 500);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 21;
            label2.Text = "Kun1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(514, 545);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 22;
            label3.Text = "Kun2";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(566, 495);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(566, 540);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 24;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(514, 587);
            button1.Name = "button1";
            button1.Size = new Size(302, 29);
            button1.TabIndex = 25;
            button1.Text = "Ma'lumot";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(651, 632);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 635);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 26;
            label4.Text = "Ishlagan vaqti";
            // 
            // AttendanceReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txId);
            Controls.Add(label1);
            Controls.Add(btSearch);
            Controls.Add(txSearchAttendance);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(dataGridView1);
            Name = "AttendanceReportForm";
            Text = "AttendanceReportForm";
            Load += AttendanceReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empControlBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sureNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enterTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private BindingSource empControlBindingSource;
        private Button btExit;
        private Button btBack;
        private Button btSearch;
        private TextBox txSearchAttendance;
        private TextBox txId;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private TextBox textBox1;
        private Label label4;
    }
}