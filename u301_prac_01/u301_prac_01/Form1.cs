using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u301_prac_01
{
    public partial class Form1 : Form
    {
        float total;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInputs();
            lblOutput.Text = "";
        }
        private float CalculateCurrentValue(float purchasedValue, int age)
        {
            float depreciation = purchasedValue * 0.2f * age;
            if (depreciation > purchasedValue) return 0f;
            return purchasedValue - depreciation;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            float purchasedValue = (float)numOrigPrice.Value;
            int age = (int)numAge.Value;
            if(purchasedValue == 0.0 | age == 0)
            {
                lblOutput.Text = "Please enter a valid price or year";
            }
            else
            {
                float currentValue = CalculateCurrentValue(purchasedValue, age);
                total += currentValue;
                lblOutput.Text = $"The item is worth ${currentValue}\n The collection so far is worth ${total}";
            }
            resetInputs();

        }

        private void resetInputs()
        {
            txtItemName.Text = "";
            numAge.Value = 0;
            numOrigPrice.Value = 0;
            comCat.ResetText();
            
            
        }
    }
}
