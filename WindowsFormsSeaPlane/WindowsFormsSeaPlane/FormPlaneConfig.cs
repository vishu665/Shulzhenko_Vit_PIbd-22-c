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
    public partial class FormPlaneConfig : Form
    {
        ITransport plane = null;        private event planeDelegate eventAddplane;
        public FormPlaneConfig()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawPlane(gr);
                pictureBoxPlane.Image = bmp;
            }
        }
        public void AddEvent(planeDelegate ev)
        {
            if (eventAddplane == null)
            {
                eventAddplane = new planeDelegate(ev);
            }
            else
            {
                eventAddplane += ev;
            }
        }

        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelSeaPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelSeaPlane.DoDragDrop(labelSeaPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Самолёт":
                    plane = new Plane(100, 500, Color.Black);
                    break;
                case "Гидросамолёт":
                    plane = new SeaPlane(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawPlane();
        }

        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LabelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void LabelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                if (plane is SeaPlane)
                {
                    (plane as SeaPlane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawPlane();
                }                
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddplane?.Invoke(plane);
            Close();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}



