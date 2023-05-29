namespace car_dealership
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            CarsStripButton = new ToolStripMenuItem();
            SaleCarStripButton = new ToolStripMenuItem();
            BuyCarStripButton = new ToolStripMenuItem();
            NotificationsStripButton = new ToolStripMenuItem();
            ProfileStripButton = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            CarsList = new ListBox();
            GetCarInfoButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDarkDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { CarsStripButton, NotificationsStripButton, ProfileStripButton });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // CarsStripButton
            // 
            CarsStripButton.DropDownItems.AddRange(new ToolStripItem[] { SaleCarStripButton, BuyCarStripButton });
            CarsStripButton.Name = "CarsStripButton";
            CarsStripButton.Size = new Size(81, 20);
            CarsStripButton.Text = "Автомобілі";
            // 
            // SaleCarStripButton
            // 
            SaleCarStripButton.Name = "SaleCarStripButton";
            SaleCarStripButton.Size = new Size(194, 22);
            SaleCarStripButton.Text = "Продати автомобіль";
            SaleCarStripButton.Click += SaleCarStripButton_Click;
            // 
            // BuyCarStripButton
            // 
            BuyCarStripButton.Name = "BuyCarStripButton";
            BuyCarStripButton.Size = new Size(194, 22);
            BuyCarStripButton.Text = "Придбати автомобіль";
            // 
            // NotificationsStripButton
            // 
            NotificationsStripButton.Name = "NotificationsStripButton";
            NotificationsStripButton.Size = new Size(99, 20);
            NotificationsStripButton.Text = "Повідомлення";
            // 
            // ProfileStripButton
            // 
            ProfileStripButton.Name = "ProfileStripButton";
            ProfileStripButton.Size = new Size(89, 20);
            ProfileStripButton.Text = "Мій профіль";
            // 
            // CarsList
            // 
            CarsList.DataSource = bindingSource1;
            CarsList.FormattingEnabled = true;
            CarsList.ItemHeight = 15;
            CarsList.Location = new Point(12, 180);
            CarsList.Name = "CarsList";
            CarsList.Size = new Size(776, 259);
            CarsList.TabIndex = 1;
            CarsList.SelectedIndexChanged += CarsList_SelectedIndexChanged;
            // 
            // GetCarInfoButton
            // 
            GetCarInfoButton.Location = new Point(731, 142);
            GetCarInfoButton.Name = "GetCarInfoButton";
            GetCarInfoButton.Size = new Size(57, 32);
            GetCarInfoButton.TabIndex = 2;
            GetCarInfoButton.Text = "GetInfo";
            GetCarInfoButton.UseVisualStyleBackColor = true;
            GetCarInfoButton.Click += GetCarInfoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(GetCarInfoButton);
            Controls.Add(CarsList);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Car Dealership";
            TopMost = true;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem CarsStripButton;
        private ToolStripMenuItem SaleCarStripButton;
        private ToolStripMenuItem BuyCarStripButton;
        private ToolStripMenuItem NotificationsStripButton;
        private ToolStripMenuItem ProfileStripButton;
        private BindingSource bindingSource1;
        private ListBox CarsList;
        private Label label1;
        private Button GetCarInfoButton;
    }
}