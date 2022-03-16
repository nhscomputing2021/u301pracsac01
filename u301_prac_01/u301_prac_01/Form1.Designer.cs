namespace u301_prac_01
{
    partial class Form1
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblOriPrice = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.comCat = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.numOrigPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrigPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(179, 65);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(91, 20);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(445, 65);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(73, 20);
            this.lblCat.TabIndex = 1;
            this.lblCat.Text = "Category";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(179, 155);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(151, 20);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "How old is the item?";
            // 
            // lblOriPrice
            // 
            this.lblOriPrice.AutoSize = true;
            this.lblOriPrice.Location = new System.Drawing.Point(445, 155);
            this.lblOriPrice.Name = "lblOriPrice";
            this.lblOriPrice.Size = new System.Drawing.Size(211, 20);
            this.lblOriPrice.TabIndex = 3;
            this.lblOriPrice.Text = "How much did you pay for it?";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(179, 356);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 4;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(183, 104);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 26);
            this.txtItemName.TabIndex = 5;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(183, 194);
            this.numAge.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 26);
            this.numAge.TabIndex = 10;
            // 
            // comCat
            // 
            this.comCat.FormattingEnabled = true;
            this.comCat.Items.AddRange(new object[] {
            "Laptops",
            "Calculators",
            "Gaming devices",
            "Computer parts"});
            this.comCat.Location = new System.Drawing.Point(449, 104);
            this.comCat.Name = "comCat";
            this.comCat.Size = new System.Drawing.Size(121, 28);
            this.comCat.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(183, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(169, 39);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate the quote";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(449, 268);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(147, 39);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "End the quote";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numOrigPrice
            // 
            this.numOrigPrice.DecimalPlaces = 1;
            this.numOrigPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numOrigPrice.Location = new System.Drawing.Point(450, 194);
            this.numOrigPrice.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.numOrigPrice.Name = "numOrigPrice";
            this.numOrigPrice.Size = new System.Drawing.Size(120, 26);
            this.numOrigPrice.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numOrigPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.comCat);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOriPrice);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.lblItemName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrigPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblOriPrice;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox comCat;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numOrigPrice;
    }
}

