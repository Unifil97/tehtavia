using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukko11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point piste = new Point(0, 0);



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graf = e.Graphics;
            //-pää
            Graf.FillEllipse(Brushes.IndianRed, piste.X - 4, piste.Y - 8, 49, 49);
            Graf.DrawEllipse(Pens.Black, piste.X - 4, piste.Y - 8, 49, 49);
            // - Selkä 
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 41,
            piste.X + 21, piste.Y + 131);
            // - Kädet 
            Graf.DrawLine(Pens.Black, piste.X - 30, piste.Y + 60,
            piste.X + 70, piste.Y + 60);
            // - Jalat 
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X - 30, piste.Y + 181);
            Graf.DrawLine(Pens.Black, piste.X + 21, piste.Y + 131,
            piste.X + 70, piste.Y + 181);
            DrawCordinates(Graf);
          
        }
      private void DrawCordinates(Graphics Graf)
        {
            // Piirretään piikoordinaattien arvot näytölle. 
            Graf.DrawString("(" + piste.X + " ," + piste.Y + ")",
                            new Font("Arial", 14, System.Drawing.FontStyle.Regular),
                           new SolidBrush(Color.Black), 470, 250);
           

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.A)

            {
                piste.X += 10;

                Refresh();
            }




            else if (e.KeyCode == Keys.S)


            {
                piste.X -= 1;
                Refresh();
            }



            else if (e.KeyCode == Keys.W)
            {
                piste.Y += 1;
                Refresh();

            }
            else if (e.KeyCode == Keys.D)
            {
                piste.Y -= 1;
                Refresh();

            }



        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            Invalidate();

        }
        private void Button1_Click(object sender, EventArgs e)
        {

            //piste = new Point(int.Parse(textBox1.Text));
            piste.X = int.Parse(textBox1.Text);
            piste.Y = int.Parse(textBox2.Text);
          
            Invalidate();
        }

       

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 
                // on formin työalueen vasemmassa ylä nurkassa 
                piste = e.Location;

                // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 
                // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 
                Invalidate();
            }
        }
       

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;
                Invalidate();
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left)
                {
                    // Talletetaan hiiren klikkauskohdan koordinaatit. Piste (0, 0) 
                    // on formin työalueen vasemmassa ylä nurkassa 
                    piste = e.Location;

                    // Merkitään formin työalue epäkelvoksi, jolloin saadaan aikaiseksi 
                    // paint-eventin signalointi ja tämän jälkeen Paint()-metodin kutsu. 
                    Invalidate();
                }
            
        }

       
      

       

       
    }
}
