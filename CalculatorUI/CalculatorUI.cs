﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double secoundNumber = Convert.ToDouble(secoundNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(firstNumber + secoundNumber);
        }

       

       

       
    }
}
