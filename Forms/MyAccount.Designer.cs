namespace car_dealership.Forms
{
    partial class MyAccount
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
            label1 = new Label();
            MyAccountCurrentUser = new Label();
            MyAccountUsername = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Current user:";
            // 
            // MyAccountCurrentUser
            // 
            MyAccountCurrentUser.AutoSize = true;
            MyAccountCurrentUser.Location = new Point(93, 14);
            MyAccountCurrentUser.Name = "MyAccountCurrentUser";
            MyAccountCurrentUser.Size = new Size(38, 15);
            MyAccountCurrentUser.TabIndex = 1;
            MyAccountCurrentUser.Text = "label2";
            // 
            // MyAccountUsername
            // 
            MyAccountUsername.Location = new Point(12, 60);
            MyAccountUsername.Name = "MyAccountUsername";
            MyAccountUsername.Size = new Size(503, 23);
            MyAccountUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Set another user:";
            // 
            // button1
            // 
            button1.Location = new Point(216, 89);
            button1.Name = "button1";
            button1.Size = new Size(92, 28);
            button1.TabIndex = 4;
            button1.Text = "Set!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MyAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(527, 127);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(MyAccountUsername);
            Controls.Add(MyAccountCurrentUser);
            Controls.Add(label1);
            MaximumSize = new Size(543, 166);
            MinimumSize = new Size(543, 166);
            Name = "MyAccount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MyAccount";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label MyAccountCurrentUser;
        private TextBox MyAccountUsername;
        private Label label2;
        private Button button1;
    }
}