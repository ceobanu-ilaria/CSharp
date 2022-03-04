using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocDePrecizie
{
    public partial class Form2 : Form
    {
        int a = 255, b = 204, c = 383, d=255;
        public Form2()
        {
            MessageBox.Show("Ajuta astronautul sa ajunga pe luna!", "SPACE level 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();
            SchimbareCursor();
            Point p = new Point();
            p.X = label0.Location.X + label0.Width / 2;
            p.Y = label0.Location.Y + label0.Height / 2;
            Cursor.Position = PointToScreen(p);

        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            label2.SetBounds(a,240,70, 43);
            a -= 20;
            if (a <= 1)
                a = 534;

        }
        private void Timer5_Tick(object sender, EventArgs e)
        {
           
            label5.SetBounds(130,b,40,30);
            b += 15;
            if (b >= 385)
                b = 1;
             
        }
        private void Timer6_Tick(object sender, EventArgs e)
        {
            label6.SetBounds(315, c, 80, 59);
            c -= 30;
            if (c <=30)
                c = 385;
        }
        private void Timer8_Tick(object sender, EventArgs e)
        {
            label8.SetBounds(d, 90, 40, 30);
            d -= 25;
            if (d <= 1)
                d = 534;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer5.Start();
            timer6.Start();
        }
        void SchimbareCursor()
        {
            Bitmap bmp = new Bitmap(Image.FromFile("astronaut.jpg"));
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Ai gresit!", " Incearca din nou!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Point p = new Point();
            p.X = label0.Location.X + label0.Width / 2;
            p.Y = label0.Location.Y + label0.Height / 2;
            Cursor.Position = PointToScreen(p);

        }

        

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Felicitari! Ai terminat jocul!","SPACE" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
        private void Label5_Click(object sender, EventArgs e)
        {

        }


    }
}
