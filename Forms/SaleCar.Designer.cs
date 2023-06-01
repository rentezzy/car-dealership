namespace car_dealership.Forms
{
    partial class SaleCar
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
            label5 = new Label();
            label10 = new Label();
            label12 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            SaleCarBrand = new TextBox();
            SaleCarModel = new TextBox();
            SaleCarPrice = new TextBox();
            SaleCarYear = new TextBox();
            SaleCarEngine = new TextBox();
            SaleCarCondition = new ComboBox();
            SaleCarGearbox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeNS;
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 23;
            label5.Text = "Gearbox:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.SizeNS;
            label10.Location = new Point(12, 115);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 22;
            label10.Text = "Condition:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.SizeNS;
            label12.Location = new Point(12, 141);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 21;
            label12.Text = "Engine:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNS;
            label4.Location = new Point(12, 65);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 20;
            label4.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.SizeNS;
            label6.Location = new Point(12, 90);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 19;
            label6.Text = "Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNS;
            label3.Location = new Point(12, 16);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 18;
            label3.Text = "Brand:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNS;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 17;
            label1.Text = "Model:";
            // 
            // SaleCarBrand
            // 
            SaleCarBrand.Location = new Point(82, 12);
            SaleCarBrand.Name = "SaleCarBrand";
            SaleCarBrand.Size = new Size(210, 23);
            SaleCarBrand.TabIndex = 24;
            // 
            // SaleCarModel
            // 
            SaleCarModel.Location = new Point(82, 37);
            SaleCarModel.Name = "SaleCarModel";
            SaleCarModel.Size = new Size(210, 23);
            SaleCarModel.TabIndex = 25;
            // 
            // SaleCarPrice
            // 
            SaleCarPrice.Location = new Point(82, 62);
            SaleCarPrice.MaxLength = 10;
            SaleCarPrice.Name = "SaleCarPrice";
            SaleCarPrice.Size = new Size(210, 23);
            SaleCarPrice.TabIndex = 26;
            SaleCarPrice.TextChanged += SaleCarPrice_TextChanged;
            // 
            // SaleCarYear
            // 
            SaleCarYear.Location = new Point(82, 87);
            SaleCarYear.MaxLength = 4;
            SaleCarYear.Name = "SaleCarYear";
            SaleCarYear.Size = new Size(210, 23);
            SaleCarYear.TabIndex = 27;
            SaleCarYear.TextChanged += SaleCarYear_TextChanged;
            // 
            // SaleCarEngine
            // 
            SaleCarEngine.Location = new Point(82, 137);
            SaleCarEngine.MaxLength = 5;
            SaleCarEngine.Name = "SaleCarEngine";
            SaleCarEngine.Size = new Size(210, 23);
            SaleCarEngine.TabIndex = 28;
            SaleCarEngine.TextChanged += SaleCarEngine_TextChanged;
            // 
            // SaleCarCondition
            // 
            SaleCarCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            SaleCarCondition.FormattingEnabled = true;
            SaleCarCondition.Items.AddRange(new object[] { "Used", "New" });
            SaleCarCondition.Location = new Point(82, 112);
            SaleCarCondition.Name = "SaleCarCondition";
            SaleCarCondition.Size = new Size(210, 23);
            SaleCarCondition.TabIndex = 29;
            // 
            // SaleCarGearbox
            // 
            SaleCarGearbox.BackColor = SystemColors.Window;
            SaleCarGearbox.DropDownStyle = ComboBoxStyle.DropDownList;
            SaleCarGearbox.ForeColor = SystemColors.MenuText;
            SaleCarGearbox.FormattingEnabled = true;
            SaleCarGearbox.Items.AddRange(new object[] { "Mechanical", "Automatic" });
            SaleCarGearbox.Location = new Point(82, 162);
            SaleCarGearbox.Name = "SaleCarGearbox";
            SaleCarGearbox.Size = new Size(210, 23);
            SaleCarGearbox.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(112, 213);
            button1.Name = "button1";
            button1.Size = new Size(100, 27);
            button1.TabIndex = 31;
            button1.Text = "Sale";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SaleCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(317, 252);
            Controls.Add(button1);
            Controls.Add(SaleCarGearbox);
            Controls.Add(SaleCarCondition);
            Controls.Add(SaleCarEngine);
            Controls.Add(SaleCarYear);
            Controls.Add(SaleCarPrice);
            Controls.Add(SaleCarModel);
            Controls.Add(SaleCarBrand);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "SaleCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SaleCar";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label10;
        private Label label12;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label1;
        private TextBox SaleCarBrand;
        private TextBox SaleCarModel;
        private TextBox SaleCarPrice;
        private TextBox SaleCarYear;
        private TextBox SaleCarEngine;
        private ComboBox SaleCarCondition;
        private ComboBox SaleCarGearbox;
        private Button button1;
    }
}