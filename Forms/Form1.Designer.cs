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
            TextBoxFilterModel = new TextBox();
            TextBoxFilterBrand = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TextBoxFilterYearFrom = new TextBox();
            TextBoxFilterYearTo = new TextBox();
            label7 = new Label();
            label8 = new Label();
            TextBoxFilterPriceFrom = new TextBox();
            TextBoxFilterPriceTo = new TextBox();
            label9 = new Label();
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
            NotificationsStripButton.Click += NotificationsStripButton_Click;
            // 
            // ProfileStripButton
            // 
            ProfileStripButton.Name = "ProfileStripButton";
            ProfileStripButton.Size = new Size(89, 20);
            ProfileStripButton.Text = "Мій профіль";
            ProfileStripButton.Click += ProfileStripButton_Click;
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
            // TextBoxFilterModel
            // 
            TextBoxFilterModel.Location = new Point(54, 147);
            TextBoxFilterModel.Name = "TextBoxFilterModel";
            TextBoxFilterModel.Size = new Size(161, 23);
            TextBoxFilterModel.TabIndex = 3;
            TextBoxFilterModel.TextChanged += TextBoxFilterModel_TextChanged;
            // 
            // TextBoxFilterBrand
            // 
            TextBoxFilterBrand.Location = new Point(54, 118);
            TextBoxFilterBrand.Name = "TextBoxFilterBrand";
            TextBoxFilterBrand.Size = new Size(161, 23);
            TextBoxFilterBrand.TabIndex = 4;
            TextBoxFilterBrand.TextChanged += TextBoxFilterBrand_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 121);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Brand:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 150);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 6;
            label3.Text = "Model:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 100);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 7;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 150);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 11;
            label5.Text = "To:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 121);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "From:";
            // 
            // TextBoxFilterYearFrom
            // 
            TextBoxFilterYearFrom.Location = new Point(284, 118);
            TextBoxFilterYearFrom.MaxLength = 5;
            TextBoxFilterYearFrom.Name = "TextBoxFilterYearFrom";
            TextBoxFilterYearFrom.Size = new Size(161, 23);
            TextBoxFilterYearFrom.TabIndex = 9;
            TextBoxFilterYearFrom.TextChanged += TextBoxFilterYearFrom_TextChanged;
            // 
            // TextBoxFilterYearTo
            // 
            TextBoxFilterYearTo.Location = new Point(284, 147);
            TextBoxFilterYearTo.MaxLength = 5;
            TextBoxFilterYearTo.Name = "TextBoxFilterYearTo";
            TextBoxFilterYearTo.Size = new Size(161, 23);
            TextBoxFilterYearTo.TabIndex = 8;
            TextBoxFilterYearTo.TextChanged += TextBoxFilterYearTo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 150);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 16;
            label7.Text = "To:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(476, 121);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "From:";
            // 
            // TextBoxFilterPriceFrom
            // 
            TextBoxFilterPriceFrom.Location = new Point(516, 118);
            TextBoxFilterPriceFrom.MaxLength = 12;
            TextBoxFilterPriceFrom.Name = "TextBoxFilterPriceFrom";
            TextBoxFilterPriceFrom.Size = new Size(161, 23);
            TextBoxFilterPriceFrom.TabIndex = 14;
            TextBoxFilterPriceFrom.TextChanged += TextBoxFilterPriceFrom_TextChanged;
            // 
            // TextBoxFilterPriceTo
            // 
            TextBoxFilterPriceTo.Location = new Point(516, 147);
            TextBoxFilterPriceTo.MaxLength = 10;
            TextBoxFilterPriceTo.Name = "TextBoxFilterPriceTo";
            TextBoxFilterPriceTo.Size = new Size(161, 23);
            TextBoxFilterPriceTo.TabIndex = 13;
            TextBoxFilterPriceTo.TextChanged += TextBoxFilterPriceTo_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(576, 100);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 12;
            label9.Text = "Price";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(TextBoxFilterPriceFrom);
            Controls.Add(TextBoxFilterPriceTo);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(TextBoxFilterYearFrom);
            Controls.Add(TextBoxFilterYearTo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TextBoxFilterBrand);
            Controls.Add(TextBoxFilterModel);
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
        private TextBox TextBoxFilterModel;
        private TextBox TextBoxFilterBrand;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TextBoxFilterYearFrom;
        private TextBox TextBoxFilterYearTo;
        private Label label7;
        private Label label8;
        private TextBox TextBoxFilterPriceFrom;
        private TextBox TextBoxFilterPriceTo;
        private Label label9;
    }
}