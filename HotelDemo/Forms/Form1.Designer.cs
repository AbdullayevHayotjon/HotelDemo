namespace HotelDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btAdmin = new Button();
            btManager = new Button();
            SuspendLayout();
            // 
            // btAdmin
            // 
            btAdmin.Font = new Font("Segoe UI", 14F);
            btAdmin.Location = new Point(201, 136);
            btAdmin.Name = "btAdmin";
            btAdmin.Size = new Size(394, 48);
            btAdmin.TabIndex = 0;
            btAdmin.Text = "Admin";
            btAdmin.UseVisualStyleBackColor = true;
            btAdmin.Click += this.btAdmin_Click;
            // 
            // btManager
            // 
            btManager.Font = new Font("Segoe UI", 14F);
            btManager.Location = new Point(201, 216);
            btManager.Name = "btManager";
            btManager.Size = new Size(394, 48);
            btManager.TabIndex = 1;
            btManager.Text = "Manager";
            btManager.UseVisualStyleBackColor = true;
            btManager.Click += this.btManager_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btManager);
            Controls.Add(btAdmin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btAdmin;
        private Button btManager;
    }
}
