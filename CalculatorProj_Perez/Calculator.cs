using System.Globalization;
using System.Linq.Expressions;

namespace CalculatorProj_Perez
{
    public partial class Calculator : Form
    {
        public string word = "";
        public string word1 = "";
        public string check = "";
        public Calculator()
        {
            InitializeComponent();
            textBox1.Text = "0";
            label2.Visible = false;
            rbtn1.Click += RoundedButton_Click;
            rbtn2.Click += RoundedButton_Click;
            rbtn3.Click += RoundedButton_Click;
            rbtn4.Click += RoundedButton_Click;
            rbtn5.Click += RoundedButton_Click;
            rbtn6.Click += RoundedButton_Click;
            rbtn7.Click += RoundedButton_Click;
            rbtn8.Click += RoundedButton_Click;
            rbtn9.Click += RoundedButton_Click;
            rbtnplus.Click += RoundedButton_Click;
            rbtnmin.Click += RoundedButton_Click;
            rbtnmul.Click += RoundedButton_Click;
            rbtndiv.Click += RoundedButton_Click;
        }

        public void RoundedButton_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            RoundedButton clickrbtn = sender as RoundedButton;
            string c = clickrbtn.Text;
            if (char.IsDigit(c[0]))
            {
                if (word == "")
                {
                    textBox1.Text = "";
                    word = "ok";
                    value = c;
                    textBox1.Text = value;
                }
                else
                {
                    value += c;
                    textBox1.Text = value;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {

                    value += " " + c + " ";
                    label1.Text = value;
                    word = "";
                }
                else if (!string.IsNullOrEmpty(value1) && !char.IsDigit(value1[value1.Length - 1]))
                {
                    if (word == "")
                    {
                        char oldc = value1[(value1.Length - 1) - 1];
                        string modchar = value1.Replace(oldc.ToString(), c.ToString());
                        label1.Text = modchar;
                        word = "";
                    }
                    else
                    {
                        if (check == "")
                        {
                            check = "ok";
                            label2.Text = "";
                            label2.TextAlign = ContentAlignment.TopRight;
                        }
                        string result = Program.Operation(value1, value, c[0]);
                        int resn = result.IndexOf('=') + 2;
                        string value2 = "";
                        for (int i = resn; i < result.Length; i++)
                        {
                            value2 += result[i];
                        }
                        label1.Text = value2 + " " + c[0] + " ";
                        textBox1.Text = value2;
                        label2.Text += result + Environment.NewLine;
                        word = "";
                        //this is where the operation class comes in where you get the data from the textbox and the label before the operation and also get the operational and then return the result
                        // value to the textbox and to the label with the new character operation which is c
                    }
                }
                else
                {
                    label1.Text = value + " " + c + " ";
                    word = "";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            } else if (e.KeyChar != '+')
            {
                e.Handled = true;
            } else if (e.KeyChar != '+')
            {
                e.Handled = true;
            } else if (e.KeyChar != '*')
            {
                e.Handled = true;
            } else if (e.KeyChar != '/')
            {
                e.Handled = true;
            } else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
        private void rbtn0_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (value[0] != '0' || value.Contains("."))
            {
                if (word == "")
                {
                    word = "ok";
                    value = "0";
                    textBox1.Text = value;
                }
                else
                {
                    word = "ok";
                    value += "0";
                    textBox1.Text = value;
                }
            }
        }

        private void rbtndot_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            if (value != "" && !value.Contains("."))
            {
                if (word == "")
                {
                    word = "ok";
                    value = "0.";
                    textBox1.Text = value;
                }
                else
                {
                    word = "ok";
                    value += ".";
                    textBox1.Text = value;
                }
            }
        }

        private void rbtneq_Click(object sender, EventArgs e)
        {
            // if clicking the button will give the value from label and textbox and the character appropriate for the button example 1 + 1 then u click the button + then that another
            // plus will then be put as the new character to be shown sa label like 2(result nani siya) + pero kung equal gani then ang mugawas kay 1 + 1 = 2 then the 2 we will 
            // we wil extract by using the value.lenght - 1 to get the final result.
            // also try kung same lang ba ang result kung decimal sa plus 
            // condition if for if ang c value kay = or any other thing then i add niya ang value1 and value && the = sign then the result if not then result angg ihatag && the new operational
            if (check == "")
            {
                check = "ok";
                label2.Text = "";
                label2.TextAlign = ContentAlignment.TopRight;
            }
            string value = label1.Text;
            string value1 = textBox1.Text;
            char c = '=';
            string result = Program.Operation(value, value1, c);
            word = "";
            label1.Text = result;
            int resn = result.IndexOf('=') + 2;
            string value2 = "";
            for (int i = resn; i < result.Length; i++)
            {
                value2 += result[i];
            }
            textBox1.Text = value2;
            label2.Text += result + Environment.NewLine;

        }



        private void rbtnclear_Click(object sender, EventArgs e)
        {
            word = "";
            label1.Text = "";
            textBox1.Text = "0";
        }

        private void rbtnex_Click(object sender, EventArgs e)
        {
            string value = label1.Text;
            string value1 = textBox1.Text;
            if (value1.Length == 1)
            {
                word = "";
                MessageBox.Show("bruh");
            }
            else
            {
                string val = value1.Remove(value1.Length - 1);
                textBox1.Text = val;
            }
        }

        private void lnklblhis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (label2.Visible)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_MouseClick(object sender, MouseEventArgs e)
        {
            if (label2.Visible)
            {
                label2.Visible = false;
            }
            else
            {
                label2.Visible = true;
            }
        }
    }
}
