using System.Linq.Expressions;

namespace CalculatorProj_Perez
{
    public partial class Form1 : Form
    {
        public string word = "";
        public string word1 = "";
        public string check = "";
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            label2.Visible = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

            }
            //string value = textBox1.Text;
            //label1.Text = value;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            //string value = label1.Text;
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true; // Reject the input
            //}
            //else
            //{

            //    if (word == "")
            //    {
            //        for (int i = 0; i < 1; i++)
            //        {
            //            textBox1.Text = "";
            //            word = "ok";
            //        }
            //    }
            //    else
            //    {
            //        if (!string.IsNullOrEmpty(value) && char.IsDigit(value[value.Length - 1]))
            //        {

            //        }
            //        else
            //        {
            //            if (word1 == "")
            //            {
            //                for (int i = 0; i < 1; i++)
            //                {
            //                    textBox1.Text = "";
            //                    word1 = "ok";
            //                }
            //            }
            //        }
            //    }

            //}

        }

        private void rbtn1_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "1";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "1";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "1";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "1";
                        textBox1.Text = value;
                    }
                }

            }

        }

        private void rbtn2_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }

                value = "2";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "2";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "2";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "2";
                        textBox1.Text = value;
                    }
                }

            }
        }

        private void rbtn3_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "3";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "3";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "3";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "3";
                        textBox1.Text = value;
                    }
                }
            }

        }

        private void rbtn4_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "4";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "4";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "4";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "4";
                        textBox1.Text = value;
                    }
                }
            }
        }

        private void rbtn5_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "5";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "5";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "5";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "5";
                        textBox1.Text = value;
                    }
                }
            }
        }

        private void rbtn6_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "6";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "6";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "6";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "6";
                        textBox1.Text = value;
                    }
                }
            }
        }

        private void rbtn7_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "7";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "7";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "7";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "7";
                        textBox1.Text = value;
                    }
                }
            }
        }

        private void rbtn8_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "8";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "8";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "8";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "8";
                        textBox1.Text = value;
                    }
                }
            }
        }

        private void rbtn9_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            if (word == "")
            {
                for (int i = 0; i < 1; i++)
                {
                    textBox1.Text = "";
                    word = "ok";
                }
                value = "9";
                textBox1.Text = value;
            }
            else
            {
                if (!string.IsNullOrEmpty(value1) && char.IsDigit(value1[value1.Length - 1]))
                {
                    value += "9";
                    textBox1.Text = value;
                }
                else
                {
                    if (word == "")
                    {
                        value = "9";
                        textBox1.Text = value;
                    }
                    else
                    {
                        value += "9";
                        textBox1.Text = value;
                    }
                }
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
                word = "ok";
                value += ".";
                textBox1.Text = value;
            }

        }

        private void rbtnplus_Click(object sender, EventArgs e)
        {
            string value = label1.Text;
            string value1 = textBox1.Text;
            if (!string.IsNullOrEmpty(value) && char.IsDigit(value[value.Length - 1]))
            {

                value1 += "+";
                label1.Text = value1;
                word = "";
            }
            else if (string.IsNullOrEmpty(value))
            {
                label1.Text = value1 + "+";
                word = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbtneq_Click(object sender, EventArgs e)
        {
            string value = label1.Text;
            string value1 = textBox1.Text;

            if (check == "")
            {
                check = "ok";
                label2.Text = "";
                label2.TextAlign = ContentAlignment.TopRight;
            }
            string value2 = label2.Text;
            if (value != "")
            {
                if (!char.IsDigit(value[value.Length - 1]))
                {
                    string num1 = "";
                    string num2 = textBox1.Text;
                    int position1 = value.IndexOf('+');
                    int position2 = value.IndexOf('-');
                    int position3 = value.IndexOf('*');
                    int position4 = value.IndexOf('/');
                    if (value[value.Length - 1] == '+')
                    {

                        for (int i = 0; i < position1; i++)
                        {
                            num1 += value[i];
                        }

                        double val1 = Convert.ToDouble(num1);
                        double val2 = Convert.ToDouble(num2);
                        double result = val1 + val2;
                        if (value.Contains("."))
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString();
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                        else
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString("0");
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }

                    }
                    else if (value[value.Length - 1] == '-')
                    {
                        for (int i = 0; i < position2; i++)
                        {
                            num1 += value[i];
                        }
                        double val1 = Convert.ToDouble(num1);
                        double val2 = Convert.ToDouble(num2);
                        double result = val1 - val2;
                        if (value.Contains("."))
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString();
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                        else
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString("0");
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                    }
                    else if (value[value.Length - 1] == '*')
                    {
                        for (int i = 0; i < position3; i++)
                        {
                            num1 += value[i];
                        }
                        double val1 = Convert.ToDouble(num1);
                        double val2 = Convert.ToDouble(num2);
                        double result = val1 * val2;
                        if (value.Contains("."))
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString();
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                        else
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString("0");
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                    }
                    else if (value[value.Length - 1] == '/')
                    {
                        for (int i = 0; i < position4; i++)
                        {
                            num1 += value[i];
                        }

                        double val1 = Convert.ToDouble(num1);
                        double val2 = Convert.ToDouble(num2);
                        double result = val1 / val2;
                        if (value.Contains("."))
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString();
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                        else
                        {
                            string res = value + num2 + "=" + result;
                            label1.Text = res;
                            textBox1.Text = result.ToString("0");
                            value2 += value + num2 + "=" + result + Environment.NewLine;
                            label2.Text = value2;
                            word = "";
                        }
                    }
                }
                else
                {
                    label1.Text = value1;
                    value2 += value1 + Environment.NewLine;
                    label2.Text = value2;
                    word = "";
                }

            }
            else
            {
                label1.Text = value1;
                value2 += value1 + Environment.NewLine;
                label2.Text = value2;
                word = "";
            }
        }

        private void rbtnmin_Click(object sender, EventArgs e)
        {
            string value = label1.Text;
            string value1 = textBox1.Text;
            if (!string.IsNullOrEmpty(value) && char.IsDigit(value[value.Length - 1]))
            {

                value1 += "-";
                label1.Text = value1;
                word = "";
            }
            else if (string.IsNullOrEmpty(value))
            {
                label1.Text = value1 + "-";
                word = "";
            }
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
            MessageBox.Show(value1.Length - 1 + "");
            int num = value1.Length - 1;

            if (value1 != "")
            {

                string val = value1.Remove(num);
                textBox1.Text = val;
                if (value1 == "")
                {
                    textBox1.Text = "0";
                    word = "";
                }
            }
        }



        private void rbtnhis_Click(object sender, EventArgs e)
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

        private void rbtnmul_Click(object sender, EventArgs e)
        {
            string value = label1.Text;
            string value1 = textBox1.Text;
            if (!string.IsNullOrEmpty(value) && char.IsDigit(value[value.Length - 1]))
            {

                value1 += "*";
                label1.Text = value1;
                word = "";
            }
            else if (string.IsNullOrEmpty(value))
            {
                label1.Text = value1 + "*";
                word = "";
            }
        }

        private void rbtndiv_Click(object sender, EventArgs e)
        {
            string value = label1.Text;
            string value1 = textBox1.Text;
            if (!string.IsNullOrEmpty(value) && char.IsDigit(value[value.Length - 1]))
            {

                value1 += "/";
                label1.Text = value1;
                word = "";
            }
            else if (string.IsNullOrEmpty(value))
            {
                label1.Text = value1 + "/";
                word = "";
            }
        }
    }
}
