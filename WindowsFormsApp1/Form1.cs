﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double Operand1, Operand2, Result;

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(txtOperand1.Text);
            Operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = Operand1 - Operand2;
            txtResult.Text = Result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(txtOperand1.Text);
            Operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = Operand1 * Operand2;
            txtResult.Text = Result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(txtOperand1.Text);
            Operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = Operand1 / Operand2;
            txtResult.Text = Result.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operand1 = Convert.ToDouble(txtOperand1.Text);
            Operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = Operand1 + Operand2;
            txtResult.Text = Result.ToString();
        }
    }
}
