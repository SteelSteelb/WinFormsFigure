//Abramov Danil 220 GeometricFigures-4 24.06.2022
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureTask
{
    public class Line : Figure
    {
        private string typeFigure = "L";
        private int x2;
        private int y2;
        Graphics g;
        Color colorFig;
        public Line(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override double Perimeter => Math.Round(Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2)), 2);
        public void Draw(PictureBox pbMain, int depth, Color colorPen)
        {
            colorFig = colorPen;
            depthLine = depth;

            g = pbMain.CreateGraphics();
            Pen blackPen = new Pen(colorFig, depthLine);
            g.DrawLine(blackPen, x, y, x2, y2);
        }

        public override string getInfo()
        {
            return Convert.ToString($"{typeFigure} {x} {y} {x2} {y2} {depthLine} {colorFig.ToArgb()}");
        }
    }
}