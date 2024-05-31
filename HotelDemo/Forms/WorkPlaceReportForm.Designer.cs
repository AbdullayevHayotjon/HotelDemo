namespace HotelDemo.Forms
{
    partial class WorkPlaceReportForm
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
            workPlaceBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            btSearch = new Button();
            txSearchAttendance = new TextBox();
            btExit = new Button();
            btBack = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txId = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)workPlaceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = workPlaceBindingSource;
            dataGridView1.Location = new Point(183, 282);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 188);
            dataGridView1.TabIndex = 0;
            // 
            // workPlaceBindingSource
            // 
            workPlaceBindingSource.DataSource = typeof(EmployeControl.WorkPlace);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(461, 237);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 16;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // txSearchAttendance
            // 
            txSearchAttendance.Location = new Point(232, 238);
            txSearchAttendance.Name = "txSearchAttendance";
            txSearchAttendance.Size = new Size(197, 27);
            txSearchAttendance.TabIndex = 15;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F);
            btExit.Location = new Point(1227, 42);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 17;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F);
            btBack.Location = new Point(1227, 762);
            btBack.Name = "btBack";
            btBack.Size = new Size(96, 29);
            btBack.TabIndex = 18;
            btBack.Text = "Orqaga";
            btBack.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(517, 503);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 19;
            button1.Text = "O'chirish";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F);
            button2.Location = new Point(350, 503);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 20;
            button2.Text = "Yangilash";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(183, 503);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 21;
            button3.Text = "Qo'shish";
            button3.UseVisualStyleBackColor = true;
            // 
            // txId
            // 
            txId.Location = new Point(955, 292);
            txId.Name = "txId";
            txId.Size = new Size(125, 27);
            txId.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(912, 295);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 22;
            label1.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(955, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(912, 346);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 24;
            label2.Text = "Foiz";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(895, 395);
            button4.Name = "button4";
            button4.Size = new Size(96, 29);
            button4.TabIndex = 26;
            button4.Text = "Ko'tarish";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F);
            button5.Location = new Point(1023, 395);
            button5.Name = "button5";
            button5.Size = new Size(96, 29);
            button5.TabIndex = 27;
            button5.Text = "Kamaytirish";
            button5.UseVisualStyleBackColor = true;
            // 
            // WorkPlaceReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txId);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(btSearch);
            Controls.Add(txSearchAttendance);
            Controls.Add(dataGridView1);
            Name = "WorkPlaceReportForm";
            Text = "WorkPlaceReportForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)workPlaceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource workPlaceBindingSource;
        private Button btSearch;
        private TextBox txSearchAttendance;
        private Button btExit;
        private Button btBack;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txId;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button4;
        private Button button5;
    }
}