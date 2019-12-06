using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsSeaPlane
{
    public class Plane : Aircraft
    {
        protected const int carWidth = 100;
        protected const int carHeight = 60;

        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {               
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;              
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;              
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;            
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
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

        }
    }
}
