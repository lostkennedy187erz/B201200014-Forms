//İBRAHİM ÇELEN
//B201200014
//BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScrollBar
{
    public partial class ScrollBar : Form
    {
        public ScrollBar()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            int sayi1 = vScrollBar1.Value;
            label1.Text = sayi1.ToString();
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int sayi2 = vScrollBar2.Value;
            label2.Text = sayi2.ToString();
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int sayi3 = vScrollBar3.Value;
            label3.Text = sayi3.ToString();
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int sayi4 = hScrollBar1.Value;
            label4.Text = sayi4.ToString();
            textBox1.ForeColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int sayi5 = hScrollBar2.Value;
            label5.Text = sayi5.ToString();
            textBox1.ForeColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            int sayi6 = hScrollBar3.Value;
            label6.Text = sayi6.ToString();
            textBox1.ForeColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

    }
}
