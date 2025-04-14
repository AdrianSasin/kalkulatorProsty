namespace kalkulatorProsty
{
    public partial class Form1 : Form
    {
        string value = ""; // Aktualna wartoœæ wprowadzana przez u¿ytkownika
        double result = 0; // Wynik operacji
        string operation = ""; // Aktualna operacja (+, -, *, /)

        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "-";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "/";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            PerformOperation();
            operation = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppendValue(button3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppendValue(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppendValue(button2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AppendValue(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AppendValue(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AppendValue(button4.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AppendValue(button9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AppendValue(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AppendValue(button7.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AppendValue(button10.Text);
        }

        private void AppendValue(string text)
        {
            value += text;
            window.Text = value;
        }

        private void PerformOperation()
        {
            if (double.TryParse(value, out double number))
            {
                if (operation == "+")
                    result += number;
                else if (operation == "-")
                    result -= number;
                else if (operation == "*")
                    result *= number;
                else if (operation == "/")
                {
                    if (number != 0)
                        result /= number;
                    else
                    {
                        window.Text = "B³¹d: Dzielenie przez 0";
                        value = "";
                        return;
                    }
                }
                else
                {
                    result = number; // Pierwsza liczba
                }
            }

            // Wyœwietl wynik w polu tekstowym
            window.Text = result.ToString();

            // Resetuj wprowadzon¹ wartoœæ
            value = "";
        }
    }
}