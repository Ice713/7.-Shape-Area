using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Shape_Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double length = 0;
            double width = 0;

            if (double.TryParse(numericUpDownLength.Text, out length) && double.TryParse(numericUpDownWidth.Text, out width))
            {
                Rectangle rectangle = new Rectangle(length, width);
                double area = rectangle.Area();
                labelResult.Text = $"Area: {area}";
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for length and width.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelResult.Text = "Error calculating area.";
            }
        }
    }
}
