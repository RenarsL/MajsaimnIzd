using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajssaimnIzd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Budzets_Click(object sender, EventArgs e)
        {
            int Alga = Convert.ToInt32(textBox1.Text);
            int Papildus_i = Convert.ToInt32(textBox5.Text);

            int ienakumi = Alga + Papildus_i;

            int Ire = Convert.ToInt32(textBox4.Text);
            int Partika = Convert.ToInt32(textBox3.Text);
            int Komunalie_m = Convert.ToInt32(textBox2.Text);

            int Izdevumi = Ire + Partika + Komunalie_m;

            double kopejais_b = ienakumi - Izdevumi;

            textBox6.Text = kopejais_b.ToString();
        }
    }
}
