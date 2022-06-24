//Abramov Danil 220 GeometricFigures-4 24.06.2022
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureTask
{
    public class Triangle : Figure
    {
        private string typeFigure = "T";
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int Twidth;
        private int Theight;
        Graphics g;
        Color colorFig;

        public Triangle(int newX, int newY, int width, int height) : base(newX, newY)
        {
            Twidth = width;
            Theight = height;
            x2 = Math.Abs(newX + width);
            y2 = Math.Abs(newY - height);
            x3 = newX;
            y3 = Math.Abs(newY - height);
        }

        public override double Perimeter => Math.Round(Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2)) +
                       Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)) +
                       Math.Sqrt(Math.Pow(x3 - x, 2) + Math.Pow(y3 - y, 2)), 2);
        public void Draw(PictureBox pbMain, int depth, Color colorPen)
        {
            colorFig = colorPen;
            depthLine = depth;

            g = pbMain.CreateGraphics();
            Pen blackPen = new Pen(colorFig, depthLine);
            g.DrawLine(blackPen, x, y, x2, y2);
            g.DrawLine(blackPen, x2, y2, x3, y3);
            g.DrawLine(blackPen, x, y, x3, y3);
        }

        public override string getInfo()
        {
            return Convert.ToString($"{typeFigure} {x} {y} {x2 - x3} {y - y3} {depthLine} {colorFig.ToArgb()}");
        }
    }
}