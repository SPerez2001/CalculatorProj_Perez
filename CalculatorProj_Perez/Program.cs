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
            char c1 = label[resn];
            string value1 = "";
            for (int i = 0; i < resn - 1; i++)
            {
                value1 += label[i];
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
                            result = val1 + " + " + txtbox + " = " + res;
                            return result;
                            break;
                        case '-':
                            res = val1 - val2;
                            result = val1 + " - " + txtbox + " = " + res;
                            return result;
                            break;
                        case '*':
                            res = val1 - val2;
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
                                result = val1 + " / " + txtbox + " = " + res;
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
                        result = val1 + " + " + txtbox + " = " + res;
                        return result;
                        break;
                    case '-':
                        res = val1 - val2;
                        result = val1 + " - " + txtbox + " = " + res;
                        return result;
                        break;
                    case '*':
                        res = val1 * val2;
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
    }
}