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
            rbtn0.Click += RoundedButton_Click;
            rbtnplus.Click += RoundedButton_Click;
            rbtnmin.Click += RoundedButton_Click;
            rbtnmul.Click += RoundedButton_Click;
            rbtndiv.Click += RoundedButton_Click;
            rbtndot.Click += RoundedButton_Click;
            rbtneq.Click += RoundedButton_Click;
        }

        public void RoundedButton_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            RoundedButton clickrbtn = sender as RoundedButton;
            string c = clickrbtn.Text;

            Program.Keyhandle keyhandle = new Program.Keyhandle();
            List<string> keys = keyhandle.btnpress(c, value1, value, word, word1);
            if (keys[0] != "")
            {
                word = keys[2];
                label1.Text = keys[0];
            }
            else if (keys[1] != "")
            {
                word = keys[2];
                textBox1.Text = keys[1];
            }
            if (keys[3] != "" && !keys[3].Contains("Cannot"))
            {
                if (check == "")
                {
                    check = "ok";
                    label2.Text = "";
                    label2.TextAlign = ContentAlignment.TopRight;
                }
                word = keys[2];
                textBox1.Text = keys[1];
                label2.Text += keys[3] + Environment.NewLine;
            }
            word = keys[2];
            word1 = keys[4];
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string value = textBox1.Text;
            string value1 = label1.Text;
            Program.Keyhandle keyhandle = new Program.Keyhandle();
            List<string> keys = keyhandle.keypress(e, value1, value, word, word1);
            if (keys[0] != "")
            {
                word = keys[2];
                label1.Text = keys[0];
            }
            else if (keys[1] != "")
            {
                word = keys[2];
                textBox1.Text = keys[1];
            }
            if (keys[3] != "" && !keys[3].Contains("Cannot"))
            {
                if (check == "")
                {
                    check = "ok";
                    label2.Text = "";
                    label2.TextAlign = ContentAlignment.TopRight;
                }
                word = keys[2];
                textBox1.Text = keys[1];
                label2.Text += keys[3] + Environment.NewLine;
            }
            word = keys[2];
            word1 = keys[4];

        }
        private void rbtn0_Click(object sender, EventArgs e)
        {
        }

        private void rbtndot_Click(object sender, EventArgs e)
        {
        }

        private void rbtneq_Click(object sender, EventArgs e)
        {
        }



        private void rbtnclear_Click(object sender, EventArgs e)
        {
            word = "";
            word1 = "";
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
                word1 = "";
                textBox1.Text = "0";
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
