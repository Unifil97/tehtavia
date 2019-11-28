using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> kirja = new Dictionary<string, string>();
        private void Button1_Click(object sender, EventArgs e)
        {
            kirja = new Dictionary<string, string>();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            kirja.Add(textBox1.Text,textBox2.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (kirja.ContainsKey(textBox3.Text))
            {
                string jutska = kirja[(textBox3.Text)];
                label5.Text = jutska;
            }
        }
    }
}
