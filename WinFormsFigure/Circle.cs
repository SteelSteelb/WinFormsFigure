//Abramov Danil 220 GeometricFigures-4 24.06.2022
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureTask
{
    public class Circle : Figure
    {
        private string typeFigure = "C";
        private int r;
        Graphics g;
        Color colorFig;
        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }

        public void Draw(PictureBox pbMain, int depth, Color colorPen)
        {
            colorFig = colorPen;
            depthLine = depth;

            g = pbMain.CreateGraphics();
            Pen blackPen = new Pen(colorFig, depthLine);
            g.DrawEllipse(blackPen, x, y, r, r);
        }

        public override double Perimeter => Math.Round(2 * Math.PI * r, 2);

        public override string getInfo()
        {
            return Convert.ToString($"{typeFigure} {x} {y} {r} {depthLine} {colorFig.ToArgb()}");
        }
    }
}