//İBRAHİM ÇELEN
//B201200014
//BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ


using System;
using System.Windows.Forms;

namespace BirimDönüştürme
{
    public partial class BirimDönüştürme : Form
    {
        public BirimDönüştürme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = comboBox3.SelectedItem.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = comboBox4.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox5.Text = comboBox5.SelectedItem.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox6.Text = comboBox6.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i = double.Parse(textBox7.Text);
            double j = double.Parse(textBox9.Text);
            double k = double.Parse(textBox11.Text);
            
            if(comboBox1.SelectedItem=="Metre" && comboBox2.SelectedItem == "Metre")
            {
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Metre" && comboBox2.SelectedItem == "Inch")
            {
                i = i * 39.370;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Metre" && comboBox2.SelectedItem == "Feet")
            {
                i = i * 3.280;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Metre" && comboBox2.SelectedItem == "Yarda")
            {
                i = i * 1.0936;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Metre" && comboBox2.SelectedItem == "Mil")
            {
                i = i * 0.0006213;
                textBox8.Text = Convert.ToString(i);
            }
            else if(comboBox1.SelectedItem == "Inch" && comboBox2.SelectedItem == "Inch")
            {
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Inch" && comboBox2.SelectedItem == "Metre")
            {
                i = i * 0.0254;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Inch" && comboBox2.SelectedItem == "Feet")
            {
                i = i * 0.08;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Inch" && comboBox2.SelectedItem == "Yarda")
            {
                i = i * 0.02777;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Inch" && comboBox2.SelectedItem == "Mil")
            {
                i = i * (1.5782 * Math.Pow(10,-5));
                textBox8.Text = Convert.ToString(i);
            }
            else if(comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Feet")
            {
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Metre")
            {
                i = i * 0.3048;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Inch")
            {
                i = i * 12;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Yarda")
            {
                i = i / 3;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Feet" && comboBox2.SelectedItem == "Mil")
            {
                i=i* 0.000189393;
                textBox8.Text = Convert.ToString(i);
            }
            else if(comboBox1.SelectedItem == "Yarda" && comboBox2.SelectedItem == "Yarda")
            {
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Yarda" && comboBox2.SelectedItem == "Metre")
            {
                i=i* 0.9144;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Yarda" && comboBox2.SelectedItem == "Inch")
            {
                i = i * 36;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Yarda" && comboBox2.SelectedItem == "Feet")
            {
                i = i * 3;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Yarda" && comboBox2.SelectedItem == "Mil")
            {
                i = i * 0.00056818;
                textBox8.Text = Convert.ToString(i);
            }
            else if(comboBox1.SelectedItem == "Mil" && comboBox2.SelectedItem == "Mil")
            {
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Mil" && comboBox2.SelectedItem == "Metre")
            {
                i = i * 1609.344;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Mil" && comboBox2.SelectedItem == "Inch")
            {
                i = i * 63360;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Mil" && comboBox2.SelectedItem == "Yarda")
            {
                i = i * 1760;
                textBox8.Text = Convert.ToString(i);
            }
            else if (comboBox1.SelectedItem == "Mil" && comboBox2.SelectedItem == "Feet")
            {
                i = i * 5280;
                textBox8.Text = Convert.ToString(i);
            }
            if(comboBox3.SelectedItem=="kgf.m/s" && comboBox4.SelectedItem == "Kw")
            {
                j = j * 0.0098;
                textBox10.Text = Convert.ToString(j);
            }
            else if(comboBox3.SelectedItem == "kgf.m/s" && comboBox4.SelectedItem == "kgf.m/s")
            {
                textBox10.Text = Convert.ToString(j);
            }
            else if(comboBox3.SelectedItem == "kgf.m/s" && comboBox4.SelectedItem == "Kcal/s")
            {
                j = j * 0.00234;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "kgf.m/s" && comboBox4.SelectedItem == "PS")
            {
                j = j * 0.0133;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kw" && comboBox4.SelectedItem == "Kw")
            {
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kw" && comboBox4.SelectedItem == "Kcal/s")
            {
                j = j * 859.85;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kw" && comboBox4.SelectedItem == "kgf.m/s")
            {
                j = j * 101.97;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kw" && comboBox4.SelectedItem == "PS")
            {
                j = j * 1.36;
                textBox10.Text = Convert.ToString(j);
            }
            else if(comboBox3.SelectedItem == "Kcal/s" && comboBox4.SelectedItem == "Kcal/s")
            {
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kcal/s" && comboBox4.SelectedItem == "Kw")
            {
                j = j * 0.0012;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kcal/s" && comboBox4.SelectedItem == "kgf.m/s")
            {
                j = j * 426.93;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "Kcal/s" && comboBox4.SelectedItem == "PS")
            {
                j=j* 5.69;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "PS" && comboBox4.SelectedItem == "Kcal/s")
            {
                j = j * 0.176;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "PS" && comboBox4.SelectedItem == "kgf.m/s")
            {
                j = j * 76.04;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "PS" && comboBox4.SelectedItem == "Kw")
            {
                j = j * 0.735;
                textBox10.Text = Convert.ToString(j);
            }
            else if (comboBox3.SelectedItem == "PS" && comboBox4.SelectedItem == "PS")
            {
                textBox10.Text = Convert.ToString(j);
            }
            if (comboBox5.SelectedItem == "Atm" && comboBox6.SelectedItem == "Atm")
            {
                textBox12.Text = Convert.ToString(k);
            }
            else if(comboBox5.SelectedItem == "Atm" && comboBox6.SelectedItem == "Psi")
            {
                k = k * 14.65;
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Atm" && comboBox6.SelectedItem == "Bar")
            {
                k = k * 1.01;
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Psi" && comboBox6.SelectedItem == "Psi")
            {
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Psi" && comboBox6.SelectedItem == "Atm")
            {
                k = k * 0.068;
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Psi" && comboBox6.SelectedItem == "Bar")
            {
                k = k * 0.068;
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Bar" && comboBox6.SelectedItem == "Bar")
            {
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Bar" && comboBox6.SelectedItem == "Atm")
            {
                k = k * 0.98;
                textBox12.Text = Convert.ToString(k);
            }
            else if (comboBox5.SelectedItem == "Bar" && comboBox6.SelectedItem == "Psi")
            {
                k = k * 14.5;
                textBox12.Text = Convert.ToString(k);
            }

        }
    }
}
