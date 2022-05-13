//İBRAHİM ÇELEN
//B201200014
//BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ

using System;
using System.Windows.Forms;

namespace ResmiTatilGünleri
{
    public partial class ResmiTatilGünleri : Form
    {
        public ResmiTatilGünleri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem.ToString() +" "+ monthCalendar1.SelectionStart.ToShortDateString()+" "+monthCalendar1.SelectionEnd.ToShortDateString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
