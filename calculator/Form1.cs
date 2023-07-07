using System.Xml.Schema;

namespace calculator
{
    public partial class Form1 : Form
    {
        private float answer; // declare all variables
        private float num1 = 0;

        private float num2 = 0;

        private string operation;

        private bool firstNumEntered = false; // used to make sure num1 exists before assigning operator

        float result; // final result

        public Form1()
        {
            InitializeComponent();
        }

        private void numButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // append text box with button text to concatenate the number, we assign this number to num1 when an operator is pressed

            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            }
            else
            {
                textBox1.Text += button.Text;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetAfterOperation(); // reset all variables if button is clicked (see below)
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out num2) && operation != string.Empty) // see if num2 even exists
            {


                switch (operation) //get result and display it
                {

                    case "+":
                        result = num1 + num2;
                        textBox1.Text = result.ToString();


                        break;

                    case "-":
                        result = num1 - num2;
                        textBox1.Text = result.ToString();

                        break;

                    case "x":
                        result = num1 * num2;

                        textBox1.Text = result.ToString();
                        break;

                    case "/":
                        result = num1 / num2;

                        if (num2 == 0)
                        {
                            textBox1.Text = "Cannot divide by zero";

                        }
                        else if (num2 != 0)
                        {
                            textBox1.Text = result.ToString();
                        }

                        break;

                    default:
                        break;
                }

            }
        }

        private void operButton_Click(object sender, EventArgs e)
        {

            if (float.TryParse(textBox1.Text, out num1)) // make sure num1 exists before assigning operator, if the user has already made a calculation, the result which was displayed
                                                         // becomes num1 and the user can continue to make calculations with the result.
            {
                Button button = (Button)sender;
                operation = button.Text;
                textBox1.Text = "";
                firstNumEntered = true;
            }
        }

        private void ResetAfterOperation() //reset all variables if button is clicked
        {
            num1 = 0;
            num2 = 0;
            textBox1.Text = "";
            firstNumEntered = false;
            operation = string.Empty;
        }

        private void btnDel_Click(object sender, EventArgs e) // this button only deletes the last number in the textbox, but we only want to do this if there are numbers in the textbox (not divide by 0 error)
        {

            if (textBox1.Text.Length > 0 && !textBox1.Text.Contains("Cannot divide by")) // if the textbox contains the error message, we don't want to delete it
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }
     
    }
}