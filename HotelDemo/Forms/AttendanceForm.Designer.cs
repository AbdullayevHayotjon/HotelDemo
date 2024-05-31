namespace HotelDemo.Forms
{
    partial class AttendanceForm
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
            txId = new TextBox();
            label1 = new Label();
            btEmployeExit = new Button();
            btEmployeEnter = new Button();
            btSearch = new Button();
            txSearchAttendance = new TextBox();
            dgvAttendance = new DataGridView();
            btBack = new Button();
            btExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // txId
            // 
            txId.Location = new Point(655, 620);
            txId.Name = "txId";
            txId.Size = new Size(125, 27);
            txId.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 623);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 17;
            label1.Text = "Ishchi Id";
            // 
            // btEmployeExit
            // 
            btEmployeExit.Location = new Point(686, 674);
            btEmployeExit.Name = "btEmployeExit";
            btEmployeExit.Size = new Size(94, 29);
            btEmployeExit.TabIndex = 16;
            btEmployeExit.Text = "Ketdi";
            btEmployeExit.UseVisualStyleBackColor = true;
            // 
            // btEmployeEnter
            // 
            btEmployeEnter.Location = new Point(552, 674);
            btEmployeEnter.Name = "btEmployeEnter";
            btEmployeEnter.Size = new Size(94, 29);
            btEmployeEnter.TabIndex = 15;
            btEmployeEnter.Text = "Keldi";
            btEmployeEnter.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(723, 199);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 14;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // txSearchAttendance
            // 
            txSearchAttendance.Location = new Point(494, 200);
            txSearchAttendance.Name = "txSearchAttendance";
            txSearchAttendance.Size = new Size(197, 27);
            txSearchAttendance.TabIndex = 13;
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(99, 259);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.Size = new Size(1180, 335);
            dgvAttendance.TabIndex = 12;
            // 
            // btBack
            // 
            btBack.Font = new Font("Segoe UI", 9F);
            btBack.Location = new Point(1244, 781);
            btBack.Name = "btBack";
            btBack.Size = new Size(96, 29);
            btBack.TabIndex = 11;
            btBack.Text = "Orqaga";
            btBack.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            btExit.Font = new Font("Segoe UI", 9F);
            btExit.Location = new Point(1244, 51);
            btExit.Name = "btExit";
            btExit.Size = new Size(96, 29);
            btExit.TabIndex = 10;
            btExit.Text = "Chiqish";
            btExit.UseVisualStyleBackColor = true;
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 853);
            Controls.Add(txId);
            Controls.Add(label1);
            Controls.Add(btEmployeExit);
            Controls.Add(btEmployeEnter);
            Controls.Add(btSearch);
            Controls.Add(txSearchAttendance);
            Controls.Add(dgvAttendance);
            Controls.Add(btBack);
            Controls.Add(btExit);
            Name = "AttendanceForm";
            Text = "AttendanceForm";
            Load += AttendanceReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txId;
        private Label label1;
        private Button btEmployeExit;
        private Button btEmployeEnter;
        private Button btSearch;
        private TextBox txSearchAttendance;
        private DataGridView dgvAttendance;
        private Button btBack;
        private Button btExit;
    }
}