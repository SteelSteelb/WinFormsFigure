//Abramov Danil 220 GeometricFigures-4 24.06.2022
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureTask
{
    public class Rectangle : Figure
    {
        private string typeFigure = "R";
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;
        private int Rwidth;
        private int Rheight;
        Graphics g;
        Color colorFig;

        public Rectangle(int newX, int newY, int width, int height) : base(newX, newY)
        {
            Rwidth = width;
            Rheight = height;
            x2 = newX + width;
            y2 = newY;
            x3 = newX + width;
            y3 = newY - height;
            x4 = newX;
            y4 = newY - height;
        }

        public override double Perimeter => Math.Round(Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2)) +
                       Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)) +
                       Math.Sqrt(Math.Pow(x3 - x, 2) + Math.Pow(y3 - y, 2)) +
                       Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)), 2);

        public void Draw(PictureBox pbMain, int depth, Color colorPen)
        {
            colorFig = colorPen;
            depthLine = depth;

            g = pbMain.CreateGraphics();
            Pen blackPen = new Pen(colorFig, depthLine);
            g.DrawRectangle(blackPen, x, y, Rwidth, Rheight);
        }

        public override string getInfo()
        {
            return Convert.ToString($"{typeFigure} {x} {y} {x3-x4} {y2-y3} {depthLine} {colorFig.ToArgb()}");
        }
    }
}