using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WindowsFormsSeaPlane;

namespace WindowsFormsSeaplane
{
    public class SeaPlane : Plane
    {
        public Color DopColor { private set; get; }        
        public bool LowerThelegs { private set; get; }        
        public bool Backwings { private set; get; }

        public SeaPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool lowerthelegs, bool wings) : base(maxSpeed, weight, mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            LowerThelegs = lowerthelegs;
            Backwings = wings;
        }

        public override void DrawPlane(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawLine(pen, _startPosX + 90, _startPosY + 20, _startPosX + 100, _startPosY + 20);
            g.DrawLine(pen, _startPosX + 100, _startPosY + 15, _startPosX + 100, _startPosY + 25);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 20, _startPosX + 55, _startPosY - 10);
            g.DrawLine(pen, _startPosX + 55, _startPosY + 20, _startPosX + 40, _startPosY - 10);
            Brush br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX, _startPosY + 10, 90, 20);
            g.FillRectangle(br, _startPosX + 40, _startPosY - 15, 17, 16);
            g.FillRectangle(br, _startPosX + 70, _startPosY + 5, 13, 15);
            g.FillRectangle(br, _startPosX - 10, _startPosY + 7, 10, 15);
            if (LowerThelegs)
            {
                Brush br1 = new SolidBrush(DopColor);
                g.FillRectangle(br1, _startPosX + 65, _startPosY + 45, 25, 10);
                g.FillRectangle(br1, _startPosX + 25, _startPosY + 45, 25, 10);

                g.DrawLine(pen, _startPosX + 75, _startPosY + 45, _startPosX + 65, _startPosY + 30);
                g.DrawLine(pen, _startPosX + 35, _startPosY + 45, _startPosX + 45, _startPosY + 30);

            }
            
            if (Backwings)
            {
                Brush wings = new SolidBrush(DopColor);
                g.FillRectangle(wings, _startPosX - 10, _startPosY - 10, 15, 15);
                g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 10, _startPosY + 10);
                g.DrawLine(pen, _startPosX - 8, _startPosY, _startPosX, _startPosY + 10);

            }
            base.DrawPlane(g);
        }
    }
}

