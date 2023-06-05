namespace car_dealership.Forms
{
    partial class Notifications
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
            bindingSource_notifications = new BindingSource(components);
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource_notifications).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.DataSource = bindingSource_notifications;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(507, 259);
            listBox1.TabIndex = 0;
            // 
            // Notifications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(531, 294);
            Controls.Add(listBox1);
            MaximumSize = new Size(1080, 1920);
            MinimumSize = new Size(547, 331);
            Name = "Notifications";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notifications";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)bindingSource_notifications).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource_notifications;
        private ListBox listBox1;
    }
}