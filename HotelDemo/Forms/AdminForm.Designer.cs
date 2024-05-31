namespace HotelDemo.Forms
{
    partial class AdminForm
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
            employeBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F);
            button1.Location = new Point(1274, 778);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 0;
            button1.Text = "Davomat";
            button1.UseVisualStyleBackColor = true;
            // 
            // employeBindingSource
            // 
            employeBindingSource.DataSource = typeof(EmployeControl.Employe);
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F);
            button3.Location = new Point(1274, 49);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 1;
            button3.Text = "Chiqish";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 861);
            Controls.Add(button1);
            Controls.Add(button3);
            Name = "AdminForm";
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)employeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private BindingSource employeBindingSource;
    }
}