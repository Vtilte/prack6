using System;
using System.Windows.Forms;

namespace ArithmeticExpressionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Введення значень x1 та x2
                double x1 = Convert.ToDouble(txtX1.Text);
                double x2 = Convert.ToDouble(txtX2.Text);

                // Обчислення f(x1, x2) = x1 * x2
                double result = x1 * x2;

                // Знаходження меншого з x1 та x2
                double minValue = Math.Min(x1, x2);

                // Відображення результатів з трьома знаками після коми
                lblResult.Text = $"f(x1, x2) = {result:F3}\nMin(x1, x2) = {minValue:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numeric values for x1 and x2.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtX1.Clear();
            txtX2.Clear();
            lblResult.Text = "";
        }
    }
}
