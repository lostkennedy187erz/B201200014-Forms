//İBRAHİM ÇELEN
//B201200014
//BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ

using System;
using System.Windows.Forms;

namespace Form1Ödev.cs
{
    public partial class İdealKiloHesabı : Form
    {
        public İdealKiloHesabı()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Boy = Convert.ToDouble(textBox1.Text);
            double Dyılı = Convert.ToDouble(textBox2.Text);
            double Kilo = Convert.ToDouble(textBox4.Text);
            double K = 0;
            double Yas = 2022 - Dyılı;
            if(comboBox1.Text == "Erkek")
            {
                K = 0.9;
            }
            else if(comboBox1.Text == "Kadın")
            {
                K = 0.8;
            }
            double i_kilo = ((Boy - 100) + (Yas / 10)) * K;
            textBox5.Text = Convert.ToString(i_kilo);
            if(Kilo == i_kilo)
            {
                textBox3.Text = "Bravo!! İdeal kilodasınız...";
            }
            else if (Kilo <= i_kilo)
            {
                textBox3.Text = "Zayıfsınız!! Kilo almalısınız...";
            }
            else
            {
                textBox3.Text = "Kilolusunuz!! Kilo vermelisiniz...";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
