using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace JocDePrecizie
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            MessageBox.Show("Mergi pe planete pana la soare!","SPACE level 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SchimbareCursor();
           InitializeComponent();
            Point p = new Point();
            p.X = label1.Location.X + label1.Width/2;
            p.Y = label1.Location.Y + label1.Height / 2;
            Cursor.Position = PointToScreen(p);
        }
        void SchimbareCursor()
        {
            Bitmap bmp = new Bitmap(Image.FromFile("racheta.png"));
            Cursor c = new Cursor(bmp.GetHicon());
            this.Cursor = c;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
           
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form2());
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            
            MessageBox.Show("Ai iesit de pe planete", "Gresit", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Point p = new Point();
            p.X = label1.Location.X + label1.Width / 2;
            p.Y = label1.Location.Y + label1.Height / 2;
            Cursor.Position = PointToScreen(p);
        }
    }
}
