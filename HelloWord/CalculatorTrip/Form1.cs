using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTrip
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Get the start value and final value
            string num1 = numericUpDown1Starting.Value.ToString();
            string num2 = numericUpDown2Ending.Value.ToString();
            //calculate total km = ending-start
            int km = int.Parse(num2) - int.Parse(num1);
            //Multiply totalKm * 0.39
            double carro = 0.39;
            double avion = 0.5;
            if (comboBox1.Text == "Carro")
            {
                double result = km * carro;
                //Asignar el valor a una etiqueta
                lblAmount.Text = "$" + result.ToString();
                
                if (int.Parse(num1) > int.Parse(num2))
                {
                    if (lblAmount.Text == lblAmount.Text)
                    {
                        lblAmount.Text = "$0.0";
                    }
                    MessageBox.Show("Starting is greater than Ending", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else
                {
                    MessageBox.Show("Total: " + lblAmount.Text, "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.Text=="Avión")
            {
                double result = km * avion;
                //Asignar el valor a una etiqueta
                lblAmount.Text = "$" + result.ToString();
                
                if (int.Parse(num1) > int.Parse(num2))
                {
                    if (lblAmount.Text == lblAmount.Text)
                    {
                        lblAmount.Text = "$0.0";
                    }
                    MessageBox.Show("Starting is greater than Ending", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result != -result)
                    {
                        lblAmount.Text = "$0.0";
                    }
                }
                else
                {
                    MessageBox.Show("Total: " + lblAmount.Text, "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDisplayKm_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Carro");
            comboBox1.Items.Add("Avión");
        }
    }
}
