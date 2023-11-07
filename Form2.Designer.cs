namespace WinFormsApp1
{
    partial class Form2
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
            fuelPrice = new TextBox();
            label2 = new Label();
            GeneralTextBox = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            Euro94Price = new Label();
            As94Price = new Label();
            As95Price = new Label();
            NumericEuro = new NumericUpDown();
            NumericAs94 = new NumericUpDown();
            NumericAs95 = new NumericUpDown();
            as95 = new RadioButton();
            as94 = new RadioButton();
            euro95 = new RadioButton();
            groupBox2 = new GroupBox();
            label5 = new Label();
            KebabPrice = new Label();
            SandwichPrice = new Label();
            BurgerPrice = new Label();
            CheckBoxBurger = new CheckBox();
            CheckBoxSandwich = new CheckBox();
            CheckBoxKebab = new CheckBox();
            kebab = new NumericUpDown();
            sandwich = new NumericUpDown();
            burger = new NumericUpDown();
            label4 = new Label();
            cafePrice = new TextBox();
            label1 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericEuro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericAs94).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericAs95).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kebab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sandwich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)burger).BeginInit();
            SuspendLayout();
            // 
            // fuelPrice
            // 
            fuelPrice.Location = new Point(91, 168);
            fuelPrice.Name = "fuelPrice";
            fuelPrice.Size = new Size(102, 23);
            fuelPrice.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 166);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // GeneralTextBox
            // 
            GeneralTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GeneralTextBox.Location = new Point(244, 261);
            GeneralTextBox.Name = "GeneralTextBox";
            GeneralTextBox.Size = new Size(316, 33);
            GeneralTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Euro94Price);
            groupBox1.Controls.Add(As94Price);
            groupBox1.Controls.Add(As95Price);
            groupBox1.Controls.Add(NumericEuro);
            groupBox1.Controls.Add(NumericAs94);
            groupBox1.Controls.Add(NumericAs95);
            groupBox1.Controls.Add(as95);
            groupBox1.Controls.Add(as94);
            groupBox1.Controls.Add(euro95);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fuelPrice);
            groupBox1.Location = new Point(30, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 202);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fuel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(189, 166);
            label3.Name = "label3";
            label3.Size = new Size(22, 25);
            label3.TabIndex = 20;
            label3.Text = "$";
            // 
            // Euro94Price
            // 
            Euro94Price.AutoSize = true;
            Euro94Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Euro94Price.Location = new Point(214, 112);
            Euro94Price.Name = "Euro94Price";
            Euro94Price.Size = new Size(49, 21);
            Euro94Price.TabIndex = 19;
            Euro94Price.Text = "1.07$";
            // 
            // As94Price
            // 
            As94Price.AutoSize = true;
            As94Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            As94Price.Location = new Point(214, 68);
            As94Price.Name = "As94Price";
            As94Price.Size = new Size(49, 21);
            As94Price.TabIndex = 18;
            As94Price.Text = "1.01$";
            // 
            // As95Price
            // 
            As95Price.AutoSize = true;
            As95Price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            As95Price.Location = new Point(214, 29);
            As95Price.Name = "As95Price";
            As95Price.Size = new Size(49, 21);
            As95Price.TabIndex = 17;
            As95Price.Text = "1.69$";
            // 
            // NumericEuro
            // 
            NumericEuro.Location = new Point(103, 110);
            NumericEuro.Name = "NumericEuro";
            NumericEuro.Size = new Size(90, 23);
            NumericEuro.TabIndex = 13;
            NumericEuro.ValueChanged += NumericEuro_ValueChanged;
            // 
            // NumericAs94
            // 
            NumericAs94.Location = new Point(103, 67);
            NumericAs94.Name = "NumericAs94";
            NumericAs94.Size = new Size(90, 23);
            NumericAs94.TabIndex = 12;
            NumericAs94.ValueChanged += NumericAs94_ValueChanged;
            // 
            // NumericAs95
            // 
            NumericAs95.Location = new Point(103, 27);
            NumericAs95.Name = "NumericAs95";
            NumericAs95.Size = new Size(90, 23);
            NumericAs95.TabIndex = 11;
            NumericAs95.ValueChanged += NumericAs95_ValueChanged;
            // 
            // as95
            // 
            as95.AutoSize = true;
            as95.Location = new Point(21, 31);
            as95.Name = "as95";
            as95.Size = new Size(54, 19);
            as95.TabIndex = 6;
            as95.TabStop = true;
            as95.Text = "AS 95";
            as95.UseVisualStyleBackColor = true;
            as95.CheckedChanged += as95_CheckedChanged;
            // 
            // as94
            // 
            as94.AutoSize = true;
            as94.Location = new Point(21, 71);
            as94.Name = "as94";
            as94.Size = new Size(54, 19);
            as94.TabIndex = 7;
            as94.TabStop = true;
            as94.Text = "AS 94";
            as94.UseVisualStyleBackColor = true;
            as94.CheckedChanged += as94_CheckedChanged;
            // 
            // euro95
            // 
            euro95.AutoSize = true;
            euro95.Location = new Point(21, 110);
            euro95.Name = "euro95";
            euro95.Size = new Size(64, 19);
            euro95.TabIndex = 8;
            euro95.TabStop = true;
            euro95.Text = "Euro 95";
            euro95.UseVisualStyleBackColor = true;
            euro95.CheckedChanged += euro95_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(KebabPrice);
            groupBox2.Controls.Add(SandwichPrice);
            groupBox2.Controls.Add(BurgerPrice);
            groupBox2.Controls.Add(CheckBoxBurger);
            groupBox2.Controls.Add(CheckBoxSandwich);
            groupBox2.Controls.Add(CheckBoxKebab);
            groupBox2.Controls.Add(kebab);
            groupBox2.Controls.Add(sandwich);
            groupBox2.Controls.Add(burger);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cafePrice);
            groupBox2.Location = new Point(353, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 202);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cafe";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(194, 166);
            label5.Name = "label5";
            label5.Size = new Size(22, 25);
            label5.TabIndex = 21;
            label5.Text = "$";
            // 
            // KebabPrice
            // 
            KebabPrice.AutoSize = true;
            KebabPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KebabPrice.Location = new Point(217, 104);
            KebabPrice.Name = "KebabPrice";
            KebabPrice.Size = new Size(58, 21);
            KebabPrice.TabIndex = 16;
            KebabPrice.Text = "99.99$";
            // 
            // SandwichPrice
            // 
            SandwichPrice.AutoSize = true;
            SandwichPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SandwichPrice.Location = new Point(217, 61);
            SandwichPrice.Name = "SandwichPrice";
            SandwichPrice.Size = new Size(49, 21);
            SandwichPrice.TabIndex = 15;
            SandwichPrice.Text = "3.00$";
            // 
            // BurgerPrice
            // 
            BurgerPrice.AutoSize = true;
            BurgerPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BurgerPrice.Location = new Point(217, 21);
            BurgerPrice.Name = "BurgerPrice";
            BurgerPrice.Size = new Size(49, 21);
            BurgerPrice.TabIndex = 14;
            BurgerPrice.Text = "4.00$";
            // 
            // CheckBoxBurger
            // 
            CheckBoxBurger.AutoSize = true;
            CheckBoxBurger.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBoxBurger.Location = new Point(8, 20);
            CheckBoxBurger.Name = "CheckBoxBurger";
            CheckBoxBurger.Size = new Size(76, 25);
            CheckBoxBurger.TabIndex = 13;
            CheckBoxBurger.Text = "Burger";
            CheckBoxBurger.UseVisualStyleBackColor = true;
            CheckBoxBurger.CheckedChanged += CheckBoxBurger_CheckedChanged;
            // 
            // CheckBoxSandwich
            // 
            CheckBoxSandwich.AutoSize = true;
            CheckBoxSandwich.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBoxSandwich.Location = new Point(8, 60);
            CheckBoxSandwich.Name = "CheckBoxSandwich";
            CheckBoxSandwich.Size = new Size(96, 25);
            CheckBoxSandwich.TabIndex = 12;
            CheckBoxSandwich.Text = "Sandwich";
            CheckBoxSandwich.UseVisualStyleBackColor = true;
            CheckBoxSandwich.CheckedChanged += CheckBoxSandwich_CheckedChanged;
            // 
            // CheckBoxKebab
            // 
            CheckBoxKebab.AutoSize = true;
            CheckBoxKebab.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckBoxKebab.Location = new Point(8, 103);
            CheckBoxKebab.Name = "CheckBoxKebab";
            CheckBoxKebab.Size = new Size(72, 25);
            CheckBoxKebab.TabIndex = 11;
            CheckBoxKebab.Text = "Kebab";
            CheckBoxKebab.UseVisualStyleBackColor = true;
            CheckBoxKebab.CheckedChanged += CheckBoxKebab_CheckedChanged;
            // 
            // kebab
            // 
            kebab.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            kebab.Location = new Point(108, 105);
            kebab.Name = "kebab";
            kebab.Size = new Size(90, 23);
            kebab.TabIndex = 10;
            kebab.ValueChanged += kebab_ValueChanged;
            // 
            // sandwich
            // 
            sandwich.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            sandwich.Location = new Point(108, 61);
            sandwich.Name = "sandwich";
            sandwich.Size = new Size(90, 23);
            sandwich.TabIndex = 9;
            sandwich.ValueChanged += sandwich_ValueChanged;
            // 
            // burger
            // 
            burger.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            burger.Location = new Point(108, 22);
            burger.Name = "burger";
            burger.Size = new Size(90, 23);
            burger.TabIndex = 4;
            burger.ValueChanged += burger_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 166);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // cafePrice
            // 
            cafePrice.Location = new Point(96, 168);
            cafePrice.Name = "cafePrice";
            cafePrice.Size = new Size(102, 23);
            cafePrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(98, 264);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 9;
            label1.Text = "General price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(566, 262);
            label6.Name = "label6";
            label6.Size = new Size(27, 32);
            label6.TabIndex = 22;
            label6.Text = "$";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(677, 391);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(GeneralTextBox);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericEuro).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericAs94).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericAs95).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kebab).EndInit();
            ((System.ComponentModel.ISupportInitialize)sandwich).EndInit();
            ((System.ComponentModel.ISupportInitialize)burger).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox fuelPrice;
        private Label label2;
        private TextBox GeneralTextBox;
        private GroupBox groupBox1;
        private RadioButton as95;
        private RadioButton as94;
        private RadioButton euro95;
        private GroupBox groupBox2;
        private NumericUpDown burger;
        private Label label4;
        private TextBox cafePrice;
        private NumericUpDown kebab;
        private NumericUpDown sandwich;
        private Label label1;
        private NumericUpDown NumericEuro;
        private NumericUpDown NumericAs94;
        private NumericUpDown NumericAs95;
        private CheckBox CheckBoxBurger;
        private CheckBox CheckBoxSandwich;
        private CheckBox CheckBoxKebab;
        private Label KebabPrice;
        private Label SandwichPrice;
        private Label BurgerPrice;
        private Label Euro94Price;
        private Label As94Price;
        private Label As95Price;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}