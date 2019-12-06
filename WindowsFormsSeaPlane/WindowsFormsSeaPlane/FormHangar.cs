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
        private const int countLevel = 5;
        MultiLevelHangar parking;

        public FormHangar()
        {
            InitializeComponent();
            parking = new MultiLevelHangar(countLevel, pictureBoxHangar.Width,
           pictureBoxHangar.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width,
                   pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }

        private void ButtonSetPlane_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var plane = new Plane(100, 1000, dialog.Color);
                    int place = parking[listBoxLevels.SelectedIndex] + plane;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void ButtonSetSeaPlane_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {

                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var plane = new SeaPlane(100, 1000, dialog.Color,
                       dialogDop.Color, true, true);
                        int place = parking[listBoxLevels.SelectedIndex] + plane;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }

            }
        }
        private void ButtonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    var plane = parking[listBoxLevels.SelectedIndex] -
                   Convert.ToInt32(maskedTextBox.Text);
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
        }

        private void ListBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
    }
}

