using System.Drawing;

namespace CalculatorProj_Perez
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }

        public static string Operation(string label, string txtbox, char c)
        {
            string result = "";
            char[] carr = { '+', '-', '*', '/' };
            int resn = label.IndexOfAny(carr);
            char c1 = ' ';
            int index = 0;
            string value1 = "";
            string lbl = "";
            if (!label.Contains("="))
            {
                if (label[0] == '-')
                {
                    for (int i = 1; i < label.Length; i++)
                    {
                        lbl += label[i];
                    }
                    index = lbl.IndexOfAny(carr);
                    c1 = label[index + 1];
                    for (int i = 0; i < index; i++)
                    {
                        value1 += label[i];
                    }
                }
                else
                {
                    c1 = label[resn];
                    value1 = "";
                    for (int i = 0; i < resn - 1; i++)
                    {
                        value1 += label[i];
                    }
                }
            }
            else
            {
                int len = label.IndexOf('=');
                value1 = txtbox;
                txtbox = "";
                lbl = "";
                if (label[0] == '-')
                {
                    for (int i = 1; i < label.Length; i++)
                    {
                        lbl += label[i];
                    }
                    index = lbl.IndexOfAny(carr);
                    c1 = label[index + 1];
                    for (int i = index + 1; i < len - 1; i++)
                    {
                        txtbox += lbl[i];
                    }
                }
                else
                {
                    c1 = label[resn];
                    for (int i = resn + 1; i < len - 1; i++)
                    {
                        txtbox += label[i];
                    }
                }
            }
            double val1 = Convert.ToDouble(value1);
            double val2 = Convert.ToDouble(txtbox);
            double res = 0;
            if (c == '=')
            {
                if (label == "")
                {
                    result = txtbox + " = " + txtbox;
                    return result;
                }
                else
                {
                    switch (c1)
                    {
                        case '+':
                            res = val1 + val2;
                            res = Math.Round(res, 5);
                            result = val1 + " + " + val2 + " = " + res;
                            return result;
                            break;
                        case '-':
                            res = val1 - val2;
                            res = Math.Round(res, 5);
                            result = val1 + " - " + val2 + " = " + res;
                            return result;
                            break;
                        case '*':
                            res = val1 * val2;
                            res = Math.Round(res, 5);
                            result = val1 + " * " + val2 + " = " + res;
                            return result;
                            break;
                        case '/':
                            if (txtbox == "0")
                            {
                                result = "Cannot be divided by 0";
                            }
                            else
                            {
                                res = val1 / val2;
                                res = Math.Round(res, 5);
                                result = val1 + " / " + val2 + " = " + res;
                                return result;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                switch (c1)
                {
                    case '+':
                        res = val1 + val2;
                        res = Math.Round(res, 5);
                        result = val1 + " + " + txtbox + " = " + res;
                        return result;
                        break;
                    case '-':
                        res = val1 - val2;
                        res = Math.Round(res, 5);
                        result = val1 + " - " + txtbox + " = " + res;
                        return result;
                        break;
                    case '*':
                        res = val1 * val2;
                        res = Math.Round(res, 5);
                        result = val1 + " * " + txtbox + " = " + res;
                        return result;
                        break;
                    case '/':
                        if (txtbox == "0")
                        {
                            result = "Cannot be divided by 0";
                        }
                        else
                        {
                            res = val1 / val2;
                            res = Math.Round(res, 5);
                            result = val1 + " / " + txtbox + " = " + res;
                            return result;
                        }
                        break;
                    default:
                        break;
                }
            }
            return result;
        }

        public class Keyhandle()
        {
            public List<string> keypress(KeyPressEventArgs e, string label, string txtbox, string word, string word1)
            {
                //value1 is lable
                //value is textbox
                List<string> keys = new List<string> { "", "", word, "", word1 };
                if (!char.IsControl(e.KeyChar) &&
                 !char.IsDigit(e.KeyChar) &&
                     e.KeyChar != '+' &&
                     e.KeyChar != '-' &&
                     e.KeyChar != '*' &&
                     e.KeyChar != '/' &&
                     e.KeyChar != '.' &&
                     e.KeyChar != (char)Keys.Enter &&
                     e.KeyChar != '=' &&
                     e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsDigit(e.KeyChar))
                    {
                        if (e.KeyChar == '0')
                        {
                            e.Handled = true;
                            if (txtbox[0] != '0' || txtbox.Contains("."))
                            {
                                if (word == "")
                                {
                                    word = "ok";
                                    txtbox = e.KeyChar.ToString();
                                    keys.Clear();
                                    keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                    return keys;
                                }
                                else
                                {
                                    word = "ok";
                                    txtbox += e.KeyChar.ToString();
                                    keys.Clear();
                                    keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                    return keys;
                                }
                            }
                        }
                        else
                        {
                            if (word == "")
                            {
                                word = "ok";
                                txtbox = e.KeyChar.ToString();
                                keys.Clear();
                                e.Handled = true;
                                keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                return keys;
                            }
                            else
                            {
                                e.Handled = true;
                                word = "ok";
                                txtbox += e.KeyChar.ToString();
                                keys.Clear();
                                keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                return keys;
                            }
                        }
                    } else if (e.KeyChar == '.')
                    {
                        e.Handled = true;
                        if (txtbox != "" && word1 == "")
                        {
                            word1 = "ok";
                            if (word == "")
                            {
                                word = "ok";
                                txtbox = "0" + e.KeyChar.ToString();
                                keys.Clear();
                                keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                return keys;
                            }
                            else
                            {
                                word = "ok";
                                txtbox += e.KeyChar.ToString();
                                keys.Clear();
                                keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                return keys;
                            }
                        }
                    }
                    else if (e.KeyChar == '=')
                    {
                        e.Handled = true;
                        word1 = "";
                        word = "";
                        string lbl2 = "";
                        if (label != "" && label.Contains("+") || label.Contains("-") || label.Contains("*") || label.Contains("/"))
                        {
                            string result = Program.Operation(label, txtbox, '=');
                            string value2 = result;
                            if (result.Contains('='))
                            {
                                int resn = result.IndexOf('=') + 2;
                                value2 = "";
                                for (int i = resn; i < result.Length; i++)
                                {
                                    value2 += result[i];
                                }
                            }
                            lbl2 = result;
                            keys.Clear();
                            keys.AddRange(new List<string> { lbl2, value2, word, lbl2, word1 });
                            return keys;
                        }
                        else
                        {
                            lbl2 = txtbox + e.KeyChar.ToString() + txtbox;
                            keys.Clear();
                            keys.AddRange(new List<string> { lbl2, txtbox, word, lbl2, word1 });
                            return keys;
                        }

                    }
                    else if (e.KeyChar == (char)Keys.Enter)
                    {
                        e.Handled = true;
                        word1 = "";
                        word = "";
                        string lbl2 = "";
                        if (label != "" && label.Contains("+") || label.Contains("-") || label.Contains("*") || label.Contains("/"))
                        {
                            string result = Program.Operation(label, txtbox, '=');
                            string value2 = result;
                            if (result.Contains('='))
                            {
                                int resn = result.IndexOf('=') + 2;
                                value2 = "";
                                for (int i = resn; i < result.Length; i++)
                                {
                                    value2 += result[i];
                                }
                            }
                            lbl2 = result;
                            keys.Clear();
                            keys.AddRange(new List<string> { lbl2, value2, word, lbl2, word1 });
                            return keys;
                        }
                        else
                        {
                            lbl2 = txtbox + " = " + txtbox;
                            keys.Clear();
                            keys.AddRange(new List<string> { lbl2, txtbox, word, lbl2, word1 });
                            return keys;
                        }
                    }
                    else if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = true;
                        string value1 = "";
                        string val = "";
                        if (txtbox.Length == 1)
                        {
                            word = "";
                            word1 = "";
                            value1 = "0";
                            keys.Clear();
                            keys.AddRange(new List<string> { "", value1, "", "", "" });
                            return keys;
                        }
                        else
                        {
                            int index = txtbox.Length -1;
                            val = txtbox.Remove(txtbox.Length - 1);
                            value1 = val;
                            if (txtbox.Contains('.'))
                            {
                                if (txtbox[index] == '.')
                                {
                                    
                                    keys.Clear();
                                    keys.AddRange(new List<string> { "", value1, "ok", "", "" });
                                    return keys;
                                }
                                else
                                {
                                    keys.Clear();
                                    keys.AddRange(new List<string> { "", value1, "ok", "", "ok" });
                                    return keys;
                                }
                            }
                            else
                            {
                                keys.Clear();
                                keys.AddRange(new List<string> { "", value1, "ok", "", "" });
                                return keys;
                            }
                            
                            
                        }
                    }
                    else
                    {
                        word1 = "";
                        if (!string.IsNullOrEmpty(label) && char.IsDigit(label[label.Length - 1]))
                        {
                            e.Handled = true;
                            txtbox += " " + e.KeyChar + " ";
                            word = "";
                            keys.Clear();
                            keys.AddRange(new List<string> { txtbox, "", word, "", word1 });
                            return keys;
                        }
                        else if (!string.IsNullOrEmpty(label) && !char.IsDigit(label[label.Length - 1]))
                        {
                            e.Handled = true;
                            if (word == "")
                            {
                                char oldc = label[(label.Length - 1) - 1];
                                string modchar = label.Replace(oldc.ToString(), e.KeyChar.ToString());
                                keys.Clear();
                                keys.AddRange(new List<string> { modchar, "", word, "", word1 });
                                return keys;
                            }
                            else
                            {
                                string result = Program.Operation(label, txtbox, e.KeyChar);
                                int resn = result.IndexOf('=') + 2;
                                string value2 = "";
                                for (int i = resn; i < result.Length; i++)
                                {
                                    value2 += result[i];
                                }
                                string lbl = value2 + " " + e.KeyChar + " ";
                                string lbl2 = "";
                                lbl2 = result;
                                word = "";
                                keys.Clear();
                                keys.AddRange(new List<string> { lbl, value2, word, lbl2, word1 });
                                return keys;
                                //this is where the operation class comes in where you get the data from the textbox and the label before the operation and also get the operational and then return the result
                                // value to the textbox and to the label with the new character operation which is c
                            }
                        }
                        else
                        {
                            e.Handled = true;
                            string lbl = txtbox + " " + e.KeyChar + " ";
                            word = "";
                            keys.Clear();
                            keys.AddRange(new List<string> { lbl, "", word, "", word1 });
                            return keys;
                        }
                    }
                }
                return keys;
            }

            public List<string> btnpress(string c, string label, string txtbox, string word, string word1)
            {
                List<string> keys = new List<string> { "", "", word, "", word1};
                if (char.IsDigit(c[0]))
                {
                    if (c == "0")
                    {
                        if (txtbox[0] != '0' || txtbox.Contains("."))
                        {
                            if (word == "")
                            {
                                word = "ok";
                                txtbox = c;
                                keys.Clear();
                                keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                return keys;
                            } else
                            {
                                word = "ok";
                                txtbox += c;
                                keys.Clear();
                                keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                                return keys;
                            }
                        }
                    }
                    else
                    {
                        if (word == "")
                        {
                            word = "ok";
                            txtbox = c;
                            keys.Clear(); ;
                            keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                            return keys;
                        }
                        else
                        {
                            word = "ok";
                            txtbox += c;
                            keys.Clear();
                            keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                            return keys;
                        }
                    }
                }
                else if (c == ".")
                {
                    if (txtbox != "" && word1 == "")
                    {
                        word1 = "ok";
                        if (word == "")
                        {
                            word = "ok";
                            txtbox = "0" + c;
                            keys.Clear();
                            keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                            return keys;
                        }
                        else
                        {
                            word = "ok";
                            txtbox += c;
                            keys.Clear();
                            keys.AddRange(new List<string> { "", txtbox, word, "", word1 });
                            return keys;
                        }
                    }
                }
                else if (c == "=")
                {
                    word1 = "";
                    word = "";
                    string lbl2 = "";
                    if (label != "" && label.Contains("+") || label.Contains("-") || label.Contains("*") || label.Contains("/"))
                    {
                        string result = Program.Operation(label, txtbox, '=');
                        string value2 = result;
                        if (result.Contains('='))
                        {
                            int resn = result.IndexOf('=') + 2;
                            value2 = "";
                            for (int i = resn; i < result.Length; i++)
                            {
                                value2 += result[i];
                            }
                        }
                        lbl2 = result;
                        keys.Clear();
                        keys.AddRange(new List<string> { lbl2, value2, word, lbl2, word1 });
                        return keys;
                    }
                    else
                    {
                        lbl2 = txtbox + " " + c + " " + txtbox;
                        keys.Clear();
                        keys.AddRange(new List<string> { lbl2, txtbox, word, lbl2, word1 });
                        return keys;
                    }
                } else if (c == "C")
                {
                    string value1 = "";
                    string val = "";
                    if (txtbox.Length == 1)
                    {
                        word = "";
                        word1 = "";
                        value1 = "0";
                        keys.Clear();
                        keys.AddRange(new List<string> { "", value1, "", "", "" });
                        return keys;
                    }
                    else
                    {
                        int index = txtbox.Length - 1;
                        val = txtbox.Remove(txtbox.Length - 1);
                        value1 = val;
                        if (txtbox.Contains('.'))
                        {
                            if (txtbox[index] == '.')
                            {

                                keys.Clear();
                                keys.AddRange(new List<string> { "", value1, "ok", "", "" });
                                return keys;
                            }
                            else
                            {
                                keys.Clear();
                                keys.AddRange(new List<string> { "", value1, "ok", "", "ok" });
                                return keys;
                            }
                        }
                        else
                        {
                            keys.Clear();
                            keys.AddRange(new List<string> { "", value1, "ok", "", "" });
                            return keys;
                        }


                    }
                } 
                else
                {
                    word1 = "";
                    if (!string.IsNullOrEmpty(label) && char.IsDigit(label[label.Length - 1]))
                    {
                        txtbox += " " + c + " ";
                        word = "";
                        keys.Clear();
                        keys.AddRange(new List<string> { txtbox, "", word, "", word1 });
                        return keys;
                    }
                    else if (!string.IsNullOrEmpty(label) && !char.IsDigit(label[label.Length - 1]))
                    {
                        if (word == "")
                        {
                            char oldc = label[(label.Length - 1) - 1];
                            string modchar = label.Replace(oldc.ToString(), c);
                            keys.Clear();
                            keys.AddRange(new List<string> { modchar, "", word, "", word1 });
                            return keys;
                        }
                        else
                        {
                            string result = Program.Operation(label, txtbox, c[0]);
                            int resn = result.IndexOf('=') + 2;
                            string value2 = "";
                            for (int i = resn; i < result.Length; i++)
                            {
                                value2 += result[i];
                            }
                            string lbl = value2 + " " + c + " ";
                            string lbl2 = "";
                            lbl2 = result;
                            word = "";
                            keys.Clear();
                            keys.AddRange(new List<string> { lbl, value2, word, lbl2, word1 });
                            return keys;
                            //this is where the operation class comes in where you get the data from the textbox and the label before the operation and also get the operational and then return the result
                            // value to the textbox and to the label with the new character operation which is c
                        }
                    }
                    else
                    {
                        string lbl = txtbox + " " + c + " ";
                        word = "";
                        keys.Clear();
                        keys.AddRange(new List<string> { lbl, "", word, "", word1 });
                        return keys;
                    }
                }
                return keys;
            }
        }
    }
}