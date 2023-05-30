namespace car_dealership.Forms
{
    partial class CarInfo
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
            CarInfoModel = new Label();
            CarInfoBrand = new Label();
            label3 = new Label();
            CarInfoPrice = new Label();
            label4 = new Label();
            CarInfoYear = new Label();
            label6 = new Label();
            CarInfoGearbox = new Label();
            label5 = new Label();
            CarInfoCondition = new Label();
            label10 = new Label();
            CarInfoEngine = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.SizeNS;
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Model:";
            // 
            // CarInfoModel
            // 
            CarInfoModel.AutoSize = true;
            CarInfoModel.Location = new Point(65, 60);
            CarInfoModel.Name = "CarInfoModel";
            CarInfoModel.Size = new Size(0, 15);
            CarInfoModel.TabIndex = 1;
            // 
            // CarInfoBrand
            // 
            CarInfoBrand.AutoSize = true;
            CarInfoBrand.Location = new Point(65, 35);
            CarInfoBrand.Name = "CarInfoBrand";
            CarInfoBrand.Size = new Size(0, 15);
            CarInfoBrand.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.SizeNS;
            label3.Location = new Point(15, 34);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "Brand:";
            // 
            // CarInfoPrice
            // 
            CarInfoPrice.AutoSize = true;
            CarInfoPrice.Location = new Point(65, 84);
            CarInfoPrice.Name = "CarInfoPrice";
            CarInfoPrice.Size = new Size(0, 15);
            CarInfoPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.SizeNS;
            label4.Location = new Point(15, 83);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Price:";
            // 
            // CarInfoYear
            // 
            CarInfoYear.AutoSize = true;
            CarInfoYear.Location = new Point(65, 109);
            CarInfoYear.Name = "CarInfoYear";
            CarInfoYear.Size = new Size(0, 15);
            CarInfoYear.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.SizeNS;
            label6.Location = new Point(15, 108);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 4;
            label6.Text = "Year:";
            // 
            // CarInfoGearbox
            // 
            CarInfoGearbox.AutoSize = true;
            CarInfoGearbox.Location = new Point(76, 183);
            CarInfoGearbox.Name = "CarInfoGearbox";
            CarInfoGearbox.Size = new Size(0, 15);
            CarInfoGearbox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.SizeNS;
            label5.Location = new Point(15, 182);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 14;
            label5.Text = "Gearbox:";
            // 
            // CarInfoCondition
            // 
            CarInfoCondition.AutoSize = true;
            CarInfoCondition.Location = new Point(84, 134);
            CarInfoCondition.Name = "CarInfoCondition";
            CarInfoCondition.Size = new Size(0, 15);
            CarInfoCondition.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.SizeNS;
            label10.Location = new Point(15, 134);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 10;
            label10.Text = "Condition:";
            // 
            // CarInfoEngine
            // 
            CarInfoEngine.AutoSize = true;
            CarInfoEngine.Location = new Point(65, 159);
            CarInfoEngine.Name = "CarInfoEngine";
            CarInfoEngine.Size = new Size(0, 15);
            CarInfoEngine.TabIndex = 9;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Cursor = Cursors.SizeNS;
            label12.Location = new Point(15, 158);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 8;
            label12.Text = "Engine:";
            // 
            // CarInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(317, 212);
            Controls.Add(CarInfoGearbox);
            Controls.Add(label5);
            Controls.Add(CarInfoCondition);
            Controls.Add(label10);
            Controls.Add(CarInfoEngine);
            Controls.Add(label12);
            Controls.Add(CarInfoPrice);
            Controls.Add(label4);
            Controls.Add(CarInfoYear);
            Controls.Add(label6);
            Controls.Add(CarInfoBrand);
            Controls.Add(label3);
            Controls.Add(CarInfoModel);
            Controls.Add(label1);
            Name = "CarInfo";
            TopMost = true;
            Load += CarInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label CarInfoModel;
        private Label CarInfoBrand;
        private Label label3;
        private Label CarInfoPrice;
        private Label label4;
        private Label CarInfoYear;
        private Label label6;
        private Label CarInfoGearbox;
        private Label label5;
        private Label CarInfoCondition;
        private Label label10;
        private Label CarInfoEngine;
        private Label label12;
    }
}