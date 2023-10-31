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
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            as95 = new RadioButton();
            as94 = new RadioButton();
            euro95 = new RadioButton();
            groupBox2 = new GroupBox();
            kebab = new NumericUpDown();
            sandwich = new NumericUpDown();
            burger_rad = new RadioButton();
            sandwich_rad = new RadioButton();
            kebab_rad = new RadioButton();
            burger = new NumericUpDown();
            label4 = new Label();
            cafePrice = new TextBox();
            label1 = new Label();
            as95_price = new NumericUpDown();
            as94_price = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label3 = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kebab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sandwich).BeginInit();
            ((System.ComponentModel.ISupportInitialize)burger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)as95_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)as94_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // fuelPrice
            // 
            fuelPrice.Location = new Point(91, 173);
            fuelPrice.Name = "fuelPrice";
            fuelPrice.Size = new Size(102, 23);
            fuelPrice.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 168);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(244, 261);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 33);
            textBox3.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown3);
            groupBox1.Controls.Add(as94_price);
            groupBox1.Controls.Add(as95_price);
            groupBox1.Controls.Add(as95);
            groupBox1.Controls.Add(as94);
            groupBox1.Controls.Add(euro95);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(fuelPrice);
            groupBox1.Location = new Point(30, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 202);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fuel";
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
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(kebab);
            groupBox2.Controls.Add(sandwich);
            groupBox2.Controls.Add(burger_rad);
            groupBox2.Controls.Add(sandwich_rad);
            groupBox2.Controls.Add(kebab_rad);
            groupBox2.Controls.Add(burger);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cafePrice);
            groupBox2.Location = new Point(272, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 202);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cafe";
            // 
            // kebab
            // 
            kebab.Location = new Point(124, 110);
            kebab.Name = "kebab";
            kebab.Size = new Size(90, 23);
            kebab.TabIndex = 10;
            // 
            // sandwich
            // 
            sandwich.Location = new Point(124, 68);
            sandwich.Name = "sandwich";
            sandwich.Size = new Size(90, 23);
            sandwich.TabIndex = 9;
            // 
            // burger_rad
            // 
            burger_rad.AutoSize = true;
            burger_rad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            burger_rad.Location = new Point(21, 22);
            burger_rad.Name = "burger_rad";
            burger_rad.Size = new Size(75, 25);
            burger_rad.TabIndex = 6;
            burger_rad.TabStop = true;
            burger_rad.Text = "Burger";
            burger_rad.UseVisualStyleBackColor = true;
            // 
            // sandwich_rad
            // 
            sandwich_rad.AutoSize = true;
            sandwich_rad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sandwich_rad.Location = new Point(20, 67);
            sandwich_rad.Name = "sandwich_rad";
            sandwich_rad.Size = new Size(95, 25);
            sandwich_rad.TabIndex = 7;
            sandwich_rad.TabStop = true;
            sandwich_rad.Text = "Sandwich";
            sandwich_rad.UseVisualStyleBackColor = true;
            // 
            // kebab_rad
            // 
            kebab_rad.AutoSize = true;
            kebab_rad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kebab_rad.Location = new Point(20, 105);
            kebab_rad.Name = "kebab_rad";
            kebab_rad.Size = new Size(71, 25);
            kebab_rad.TabIndex = 8;
            kebab_rad.TabStop = true;
            kebab_rad.Text = "Kebab";
            kebab_rad.UseVisualStyleBackColor = true;
            // 
            // burger
            // 
            burger.Location = new Point(124, 22);
            burger.Name = "burger";
            burger.Size = new Size(90, 23);
            burger.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 168);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // cafePrice
            // 
            cafePrice.Location = new Point(89, 173);
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
            // as95_price
            // 
            as95_price.Location = new Point(103, 27);
            as95_price.Name = "as95_price";
            as95_price.Size = new Size(90, 23);
            as95_price.TabIndex = 11;
            // 
            // as94_price
            // 
            as94_price.Location = new Point(103, 67);
            as94_price.Name = "as94_price";
            as94_price.Size = new Size(90, 23);
            as94_price.TabIndex = 12;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(103, 110);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(90, 23);
            numericUpDown3.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 147);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 14;
            label3.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(91, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 22);
            textBox1.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(529, 327);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox3);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kebab).EndInit();
            ((System.ComponentModel.ISupportInitialize)sandwich).EndInit();
            ((System.ComponentModel.ISupportInitialize)burger).EndInit();
            ((System.ComponentModel.ISupportInitialize)as95_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)as94_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox fuelPrice;
        private Label label2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private RadioButton as95;
        private RadioButton as94;
        private RadioButton euro95;
        private GroupBox groupBox2;
        private RadioButton burger_rad;
        private RadioButton sandwich_rad;
        private RadioButton kebab_rad;
        private NumericUpDown burger;
        private Label label4;
        private TextBox cafePrice;
        private NumericUpDown kebab;
        private NumericUpDown sandwich;
        private Label label1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown as94_price;
        private NumericUpDown as95_price;
        private TextBox textBox1;
        private Label label3;
    }
}