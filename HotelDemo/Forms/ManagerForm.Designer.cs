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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btSearch = new Button();
            txSearchAttendance = new TextBox();
            dataGridView1 = new DataGridView();
            btExit = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // 
            // btSearch
            // 
            btSearch.Location = new Point(707, 108);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(94, 29);
            btSearch.TabIndex = 24;
            btSearch.Text = "Qidirish";
            btSearch.UseVisualStyleBackColor = true;
            // 
            // txSearchAttendance
            // 
            txSearchAttendance.Location = new Point(478, 109);
            txSearchAttendance.Name = "txSearchAttendance";
            txSearchAttendance.Size = new Size(197, 27);
            txSearchAttendance.TabIndex = 23;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1122, 188);
            dataGridView1.TabIndex = 22;
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
            Controls.Add(txSearchAttendance);
            Controls.Add(dataGridView1);
            Name = "ManagerForm";
            Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button btSearch;
        private TextBox txSearchAttendance;
        private DataGridView dataGridView1;
        private Button btExit;
        private Button button4;
        private Button button5;
    }
}