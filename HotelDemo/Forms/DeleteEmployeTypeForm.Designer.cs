namespace HotelDemo.Forms
{
    partial class DeleteEmployeTypeForm
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
            button4 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            txId = new TextBox();
            label1 = new Label();
            btBack = new Button();
            btExit = new Button();
            btSearch = new Button();
            txSearchAttendance = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F);
            button4.Location = new Point(821, 454);
            button4.Name = "button4";
            button4.Size = new Size(247, 29);
            button4.TabIndex = 50;
            button4.Text = "O'chirish";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(943, 398);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(821, 401);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 48;
            label2.Text = "EmployePrice";
            // 
            // txId
            // 
            txId.Location = new Point(943, 347);
            txId.Name = "txId";
            txId.Size = new Size(125, 27);
            txId.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(821, 350);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 46;
            label1.Text = "EmployeType";
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F);
            btBack.Location = new Point(1115, 691);
            btBack.Name = "btBack";
            btBack.Size = new Size(96, 29);
            btBack.TabIndex = 45;
            btBack.Text = "Orqaga";
            btBack.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F);
            btExit.Location = new Point(1115, 133);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 44;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(449, 292);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 43;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // txSearchAttendance
            // 
            txSearchAttendance.Location = new Point(220, 293);
            txSearchAttendance.Name = "txSearchAttendance";
            txSearchAttendance.Size = new Size(197, 27);
            txSearchAttendance.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(171, 337);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(430, 188);
            dataGridView1.TabIndex = 41;
            // 
            // DeleteEmployeTypeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txId);
            Controls.Add(label1);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Controls.Add(btSearch);
            Controls.Add(txSearchAttendance);
            Controls.Add(dataGridView1);
            Name = "DeleteEmployeTypeForm";
            Text = "DeleteEmployeTypeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private TextBox textBox1;
        private Label label2;
        private TextBox txId;
        private Label label1;
        private Button btBack;
        private Button btExit;
        private Button btSearch;
        private TextBox txSearchAttendance;
        private DataGridView dataGridView1;
    }
}