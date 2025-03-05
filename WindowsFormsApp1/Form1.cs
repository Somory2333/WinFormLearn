using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender,System.EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }



        private void label1_Click (object sender,System.EventArgs e)
        {

        }

        private void textBox1_TextChanged (object sender,System.EventArgs e)
        {

        }

        private void button1_Click_1 (object sender,System.EventArgs e)
        {

        }

        private void button1_Click (object sender,System.EventArgs e)
        {
            try
            {
                double value1 = double.Parse(textBox1.Text);
                double value2 = double.Parse(textBox2.Text);
                string operation = comboBox1.Text;
                double result = 0;
                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        if (value2 != 0)
                            result = value1 / value2;
                        else
                        {
                            MessageBox.Show("除数不能为零！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                        break;


                }

                label2.Text = result.ToString("F2");
                label2.BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入错误，请输入有效的数字！\n" + ex.Message,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void label2_Click (object sender,EventArgs e)
        {

        }
    }
}
