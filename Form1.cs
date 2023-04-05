namespace _0404_дроби
{
    public partial class Form1 : Form
    {
        public int NOD (int a, int b)
        {
            int res = 0;
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
                res = a + b;
            }
            return res;
        }
        public int NSK(int a, int b)
        {
            int res = (a*b)/NOD(a,b);
            
            return res;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            if (comboBox1.Text == "Виберіть дію")
            {
                label10.Text = "Виберіть дію.";
            } else { 
            if (comboBox1.Text == "Додавання")
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення першого дробу.";
                }
                else if (textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення другого дробу.";
                }
                else
                {
                    int numerator1 = Convert.ToInt32(textBox1.Text);
                    int denominator1 = Convert.ToInt32(textBox2.Text);
                    int numerator2 = Convert.ToInt32(textBox3.Text);
                    int denominator2 = Convert.ToInt32(textBox4.Text);
                    int nsk = NSK(denominator1, denominator2);
                    numerator1 = nsk / denominator1 * numerator1;
                    numerator2 = nsk / denominator2 * numerator2;
                    int res_numerator = numerator1 + numerator2;
                    int res_denominator = nsk;
                    label11.Text = Convert.ToString(res_numerator);
                    label12.Text = Convert.ToString(res_denominator);
                    label9.Text = "_______";
                    int a = Convert.ToInt32(label11.Text);
                    int b = Convert.ToInt32(label12.Text);
                    if (a > b)
                    {
                        int resInt = a / b;
                        int resNumerator = a - (resInt * b);
                        label16.Text = "_______";
                        label17.Text = "_______";
                        label15.Text = "_______";
                        label18.Text = Convert.ToString(resInt);
                        label13.Text = Convert.ToString(b);
                        label14.Text = Convert.ToString(resNumerator);
                    }
                }

            } else if (comboBox1.Text == "Віднімання")
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення першого дробу.";
                }
                else if (textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення другого дробу.";
                }
                else
                {
                    int numerator1 = Convert.ToInt32(textBox1.Text);
                    int denominator1 = Convert.ToInt32(textBox2.Text);
                    int numerator2 = Convert.ToInt32(textBox3.Text);
                    int denominator2 = Convert.ToInt32(textBox4.Text);
                    int nsk = NSK(denominator1, denominator2);
                    numerator1 = nsk / denominator1 * numerator1;
                    numerator2 = nsk / denominator2 * numerator2;
                    int res_numerator = numerator1 - numerator2;
                    int res_denominator = nsk;
                    label11.Text = Convert.ToString(res_numerator);
                    label12.Text = Convert.ToString(res_denominator);
                    label9.Text = "_______";

                    int a = Convert.ToInt32(label11.Text);
                    int b = Convert.ToInt32(label12.Text);
                    if (a > b)
                    {
                        int resInt = a / b;
                        int resNumerator = a - (resInt * b);
                        label16.Text = "_______";
                        label17.Text = "_______";
                        label15.Text = "_______";
                        label18.Text = Convert.ToString(resInt);
                        label13.Text = Convert.ToString(b);
                        label14.Text = Convert.ToString(resNumerator);
                    }
                }
            } else if (comboBox1.Text == "Ділення")
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення першого дробу.";
                }
                else if (textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення другого дробу.";
                }
                else
                {
                    int numerator1 = Convert.ToInt32(textBox1.Text);
                    int denominator1 = Convert.ToInt32(textBox2.Text);
                    int numerator2 = Convert.ToInt32(textBox3.Text);
                    int denominator2 = Convert.ToInt32(textBox4.Text);
                    int res_numerator = numerator1 * denominator2;
                    int res_denominator = denominator1 * numerator2;
                    int nod = NOD(res_numerator, res_denominator);
                    res_numerator = res_numerator / nod;
                    res_denominator = res_denominator / nod;
                    label11.Text = Convert.ToString(res_numerator);
                    label12.Text = Convert.ToString(res_denominator);
                    label9.Text = "_______";
                    int a = Convert.ToInt32(label11.Text);
                    int b = Convert.ToInt32(label12.Text);
                    if (a > b)
                    {
                        int resInt = a / b;
                        int resNumerator = a - (resInt * b);
                        label16.Text = "_______";
                        label17.Text = "_______";
                        label15.Text = "_______";
                        label18.Text = Convert.ToString(resInt);
                        label13.Text = Convert.ToString(b);
                        label14.Text = Convert.ToString(resNumerator);
                    }
                }
            } else if (comboBox1.Text == "Множення")
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення першого дробу.";
                } else if (textBox3.Text.Length == 0 || textBox4.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення другого дробу.";
                } else
                {
                    int numerator1 = Convert.ToInt32(textBox1.Text);
                    int denominator1 = Convert.ToInt32(textBox2.Text);
                    int numerator2 = Convert.ToInt32(textBox3.Text);
                    int denominator2 = Convert.ToInt32(textBox4.Text);
                    int res_numerator = numerator1*numerator2;
                    int res_denominator = denominator1* denominator2;
                    int nod = NOD(res_numerator, res_denominator);
                    res_numerator = res_numerator / nod;
                    res_denominator = res_denominator / nod;
                    label11.Text = Convert.ToString(res_numerator);
                    label12.Text = Convert.ToString(res_denominator);
                    label9.Text = "_______";
                    int a = Convert.ToInt32(label11.Text);
                    int b = Convert.ToInt32(label12.Text);
                    if (a > b)
                    {
                        int resInt = a / b;
                        int resNumerator = a - (resInt * b);
                        label16.Text = "_______";
                        label17.Text = "_______";
                        label15.Text = "_______";
                        label18.Text = Convert.ToString(resInt);
                        label13.Text = Convert.ToString(b);
                        label14.Text = Convert.ToString(resNumerator);
                    }
                }

            } else if (comboBox1.Text == "Скорочення дробу")
            {   if (textBox1.Text.Length == 0)
                {
                    label10.Text = "Заповніть чисельник.";
                } else if (textBox2.Text.Length == 0)
                {
                    label10.Text = "Заповніть знаменник.";
                } else
                {
                    int numerator1 = Convert.ToInt32(textBox1.Text);
                    int denominator1 = Convert.ToInt32(textBox2.Text);
                    int nod = NOD(numerator1, denominator1);
                    numerator1 = numerator1 / nod;
                    denominator1 = denominator1 / nod;
                    label11.Text = Convert.ToString(numerator1);
                    label12.Text = Convert.ToString(denominator1);
                    label9.Text = "_______";
                    label19.Text = " ";
                }



            } else if (comboBox1.Text == "Виокремлення цілої частини")
            {
                int k = Convert.ToInt32(textBox1.Text);
                int j = Convert.ToInt32(textBox2.Text);
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    label10.Text = "Перевірте правильність заповнення першого дробу.";
                }
                else if (k<j)
                {
                    label10.Text = "Чисельник менший за знаменник. Виокремлювати немає чого.";
                }
                else
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    int b = Convert.ToInt32(textBox2.Text);
                    if (a > b)
                    {
                        if (a%b != 0)
                        {
                            int resInt = a / b;
                            int resNumerator = a - (resInt * b);
                            label19.Text = Convert.ToString(resInt);
                            label11.Text = Convert.ToString(resNumerator);
                            label12.Text = Convert.ToString(b);
                            label9.Text = " ";
                        } else
                        {
                            int resInt = a / b;
                            int resNumerator = a - (resInt * b);
                            label19.Text = Convert.ToString(resInt);
                            label11.Text = " ";
                            label12.Text = " ";
                            label9.Text = " ";
                        }
                      }

                    }
                }
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            comboBox1.Text = "Виберіть дію";
        }
    }
}
