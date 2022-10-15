using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_ortalama_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonhesapla_Click(object sender, EventArgs e)
        {
            int not1 = Convert.ToInt32(textBox1.Text);
            int not2 = Convert.ToInt32(textBox2.Text);
            int not3= Convert.ToInt32(textBox3.Text);

            int sonuç = (not1 + not2 + not3) / 3;

            ekranlabel.Text = Convert.ToString(sonuç);

        }
    }
}
