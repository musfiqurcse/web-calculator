using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCalculatior.BLL;

namespace WebCalculatior
{
    public partial class FirstIndex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = CalculationLogic.Add(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();

        }

        protected void substractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = CalculationLogic.Substract(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = CalculationLogic.Divison(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = CalculationLogic.Multiply(Convert.ToDouble(firstNumberTextBox.Text),
                Convert.ToDouble(secondNumberTextBox.Text)).ToString();
        }

        protected void clearbutton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = secondNumberTextBox.Text = resultTextBox.Text = "";
        }
    }
}