using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors_Basic
{
    public partial class Form1 : Form
    {
        int i = 0;
        int j = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Random r = new Random();
                int sayi = r.Next(3);
                if (sayi == 2)
                {
                    MessageBox.Show("Arrgh! You Win 1 Point.");
                    i++;
                    label3.Text = i.ToString();
                    listBox1.Items.Add("Rock----------Scissors");
                }
                else if (sayi == 1)
                {
                    MessageBox.Show("He he I Win 1 Point.");
                    j++;
                    label4.Text = j.ToString();
                    listBox1.Items.Add("Rock----------Paper");
                }
                else
                {
                    MessageBox.Show("We both chose Rock. It's Draw.");
                    listBox1.Items.Add("Rock----------Rock");
                }
            }
            else if (radioButton2.Checked)
            {
                Random r = new Random();
                int sayi = r.Next(3);
                if (sayi == 0)
                {
                    MessageBox.Show("Arrgh! You Win 1 Point.");
                    i++;
                    label3.Text = i.ToString();
                    listBox1.Items.Add("Paper-----Rock");
                }
                else if (sayi == 2)
                {
                    MessageBox.Show("He he I Win 1 Point.");
                    j++;
                    label4.Text = j.ToString();
                    listBox1.Items.Add("Paper-----Scissors");
                }
                else
                {
                    MessageBox.Show("We both chose Paper. It's Draw.");
                    listBox1.Items.Add("Paper-----Paper");
                }
            }
            else
            {
                Random r = new Random();
                int sayi = r.Next(3);
                if (sayi == 1)
                {
                    MessageBox.Show("Arrgh! You Win 1 Point.");
                    i++;
                    label3.Text = i.ToString();
                    listBox1.Items.Add("Scissors-----Paper");
                }
                else if (sayi == 0)
                {
                    MessageBox.Show("He he I Win 1 Point.");
                    j++;
                    label4.Text = j.ToString();
                    listBox1.Items.Add("Scissors-----Rock");
                }
                else
                {
                    MessageBox.Show("We both chose Scissors. It's Draw.");
                    listBox1.Items.Add("Scissors-----Scissors");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
            listBox1.Items.Clear();
        }
    }
}
