//Abramov Danil 220 GeometricFigures-4 24.06.2022
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FigureTask
{
    public abstract class Figure
    {
        public string typeFigure = "";
        public int x { get; }
        public int y { get; }
        public abstract double Perimeter { get; }

        public int depthLine = 1;


        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public struct StrokeData
        {
            public int Thickness;
            public int Color;
        }

        public struct FillData
        {
            public int Color;
        }

        public virtual void Draw(PictureBox pbMain, int depth, Color colorPen)
        {
            //return Console.WriteLine("Draw : " + x + " " + y);
        }

        public virtual string getInfo()
        {
            return Convert.ToString($"{x} {y}");
        }
    }
}