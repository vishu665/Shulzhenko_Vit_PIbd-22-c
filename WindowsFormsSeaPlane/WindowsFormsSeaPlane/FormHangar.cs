using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsSeaplane;

namespace WindowsFormsSeaPlane
{
    public partial class FormHangar : Form
    {
        Hangar<ITransport> parking;

        public FormHangar()
        {
            InitializeComponent();
            parking = new Hangar<ITransport>(20, pictureBoxHangar.Width,
           pictureBoxHangar.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }

       

        private void ButtonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var plane = parking - Convert.ToInt32(maskedTextBox.Text);
                if (plane != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width,
                   pictureBoxTakePlane.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    plane.SetPosition(5, 5, pictureBoxTakePlane.Width,
                   pictureBoxTakePlane.Height);
                    plane.DrawPlane(gr);
                    pictureBoxTakePlane.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakePlane.Width,
                   pictureBoxTakePlane.Height);
                    pictureBoxTakePlane.Image = bmp;
                }
                Draw();
            }
        }

        private void ButtonSetPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var plane = new Plane(100, 1000, dialog.Color);
                int place = parking + plane;
                Draw();
            }
        }

        private void ButtonSetSeaPlane_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var plane = new SeaPlane(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    int place = parking + plane;
                    Draw();
                }
            }
        }
    }
}
