//İBRAHİM ÇELEN
//B201200014
//BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ
using System;
using System.Windows.Forms;

namespace Kitap_Sipariş_Listesi
{
    public partial class KitapSiparişListesi : Form
    {
        public KitapSiparişListesi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("AutoCAD 14");
            checkedListBox1.Items.Add("AutoCAD 2000");
            checkedListBox1.Items.Add("AutoCAD 2002");
            checkedListBox1.Items.Add("Visual Basic.NET");
            checkedListBox1.Items.Add("Pro/ENGINEER 2001");
            checkedListBox1.Items.Add("Catia V5 R9");
            checkedListBox1.Items.Add("Visual Basic 6.0");
            checkedListBox1.Items.Add("Turbo Pascal 7.0");
            checkedListBox1.Items.Add("C# for Beginners");
            checkedListBox1.Items.Add("Python 3.0");
            checkedListBox1.Items.Add("Cyber Security");
            checkedListBox1.Items.Add("Calculus 1");
            checkedListBox1.Items.Add("Calculus 2");
            checkedListBox1.Items.Add("Time");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
