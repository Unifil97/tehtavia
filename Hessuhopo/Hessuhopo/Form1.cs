using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hessuhopo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Point piste = new Point(0, 0);
        private void Form1_Load(object sender, EventArgs e)
        {

       

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap viidakko = new Bitmap(Properties.Resources.Hopo);
            viidakko.MakeTransparent();
            e.Graphics.DrawImage(viidakko, piste);
            DoubleBuffered = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }
        }
    }
}
