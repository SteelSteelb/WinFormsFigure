using FigureTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = FigureTask.Rectangle;

namespace WinFormsFigure
{
    public partial class FormFigure : Form
    {
        public string selectFig;
        Figires image = new Figires();
        public string data;
        bool isDraw = false;
        Graphics g;
        Pen blackPen = new Pen(Color.Black, 3);
        ColorDialog MyDialog;
        

        PointF point1;
        PointF point2;
        PointF point3;
        PointF point4;

        public int Xcdt;
        public int Ycdt;
        public int Width;
        public int Height;
        public int depthLine;

        public FormFigure()
        {
            InitializeComponent();
            cbFigure.Items.AddRange(new string[] { "Line", "Triangle", "Rectangle", "Circle" });
            doBtn(false);
            opFD.Filter = "Text files(*.txt)|*.txt|Picture(*.png)|*.png|All files(*.*)|*.*";
            svFD.Filter = "Text files(*.txt)|*.txt|Picture(*.png)|*.png|All files(*.*)|*.*";
            btnDraw.Visible = false;
            tbMain.ForeColor = Color.Black;
        }


        public void btnDraw_Click(object sender, EventArgs e)
        {
            if (selectFig == null)
            {
            }
            else
            {
                takeValue();
                takePen();
                if (isDraw)
                {
                    switch (selectFig[0])
                    {
                        case 'L':
                            Line figLine = new Line(Xcdt, Ycdt, Width, Height);
                            image.Add(figLine);

                            figLine.Draw(pbMain, depthLine, tbMain.ForeColor);

                            tbMain.Text += (figLine.getInfo() + "\r\n");
                            break;

                        case 'R':
                            Rectangle figRectangle = new Rectangle(Xcdt, Ycdt, Width, Height);
                            image.Add(figRectangle);

                            figRectangle.Draw(pbMain, depthLine, tbMain.ForeColor);

                            tbMain.Text += (figRectangle.getInfo() + "\r\n");
                            break;

                        case 'T':
                            Triangle figTriangle = new Triangle(Xcdt, Ycdt, Width, Height);
                            image.Add(figTriangle);

                            figTriangle.Draw(pbMain, depthLine, tbMain.ForeColor);

                            tbMain.Text += (figTriangle.getInfo() + "\r\n");
                            break;

                        case 'C':
                            Circle figCircle = new Circle(Xcdt, Ycdt, Width);
                            image.Add(figCircle);

                            figCircle.Draw(pbMain, depthLine, tbMain.ForeColor);

                            tbMain.Text += (figCircle.getInfo() + "\r\n");
                            break;

                        default:
                            break;
                    }
                }
            }
            isDraw = false;
        }

        private void takePen()
        {
            if (tbDepth.Text != "Tickness")
            {
                depthLine = Convert.ToInt32(tbDepth.Text);
                isDraw = true;
            }
            else
            {
                MessageBox.Show("ERROR. Select color");
                isDraw = false;
            }
        }

        private void takeValue()
        {
            if (tbXcdt.Text != "X"  && tbYcdt.Text != "Y"
                && tbWdh.Text != "W" && tbHght.Text != "H"
                && selectFig != "Circle" && selectFig != "Line")
            {
                Xcdt = Convert.ToInt32(tbXcdt.Text);
                Ycdt = Convert.ToInt32(tbYcdt.Text);
                Width = Convert.ToInt32(tbWdh.Text);
                Height = Convert.ToInt32(tbHght.Text);
                isDraw = true;
            }
            else if (tbXcdt.Text != "X" && tbYcdt.Text != "Y"
                && tbWdh.Text != "R" && selectFig == "Circle")
            {
                Xcdt = Convert.ToInt32(tbXcdt.Text);
                Ycdt = Convert.ToInt32(tbYcdt.Text);
                Width = Convert.ToInt32(tbWdh.Text);
                isDraw = true;
            }
            else if (tbXcdt.Text != "X" && tbYcdt.Text != "Y"
                && tbWdh.Text != "X2" && tbHght.Text != "Y2" 
                && selectFig == "Line")
            {
                Xcdt = Convert.ToInt32(tbXcdt.Text);
                Ycdt = Convert.ToInt32(tbYcdt.Text);
                Width = Convert.ToInt32(tbWdh.Text);
                Height = Convert.ToInt32(tbHght.Text);
                isDraw = true;
            }
            else
            {
                MessageBox.Show("ERROR. Select coords");
            }
        }
        
        private void clearValue()
        {
            Xcdt = 0;
            Ycdt = 0;
            Width = 0;
            Height = 0;
        }

        private void pbMain_Click(object sender, EventArgs e)
        {

        }

        private void cbFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDraw.Visible = true;
            selectFig = cbFigure.Text;
            if(selectFig == "Circle")
            {
                doBtn(true);

                tbHght.Visible = false;
                tbHght.Enabled = false;
                tbWdh.Text = "R";
            }
            else if(selectFig == "Line")
            {
                doBtn(true);
                tbWdh.Text = "X2";
                tbHght.Text = "Y2";
            }
            else if (selectFig == "")
            {

            }
            else
            {
                doBtn(true);
            }
        }

        private void FormFigure_Activated(object sender, EventArgs e)
        {      
        }

        private void tbXcdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbXcdt_TextChanged(object sender, EventArgs e)
        {

        }


        private void tbYcdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbXcdt_Click(object sender, EventArgs e)
        {
            tbXcdt.Clear();
        }

        private void tbYcdt_Click(object sender, EventArgs e)
        {
            tbYcdt.Clear();
        }

        private void tbWdh_Click(object sender, EventArgs e)
        {
            tbWdh.Clear();
        }

        private void tbHght_Click(object sender, EventArgs e)
        {
            tbHght.Clear();
        }
        private void tbDepth_Click(object sender, EventArgs e)
        {
            tbDepth.Clear();
        }

        public void doBtn(bool value)
        {
            bool log = value;


            tbHght.Visible = log;
            tbHght.Enabled = log;
            tbHght.Text = "H";

            tbWdh.Visible = log;
            tbWdh.Enabled = log;
            tbWdh.Text = "W";

            tbXcdt.Visible = log;
            tbXcdt.Enabled = log;
            tbXcdt.Text = "X";

            tbYcdt.Visible = log;
            tbYcdt.Enabled = log;
            tbYcdt.Text = "Y";

            tbStrtCdt.Visible = log;
            tbStrtCdt.Enabled = log;

            tbDepth.Text = "Tickness";
            tbDepth.Visible = log;
            tbDepth.Enabled = log;
        }

        private void tbXcdt_Leave(object sender, EventArgs e)
        {
            if (tbXcdt.Text == "")
            { 
                tbXcdt.Text = "X"; 
            }
            else { }
        }

        private void tbYcdt_Leave(object sender, EventArgs e)
        {
            if (tbYcdt.Text == "")
            {
                tbYcdt.Text = "Y";
            }
            else { }
        }

        private void tbWdh_Leave(object sender, EventArgs e)
        {
            if (tbWdh.Text == "" && selectFig == "Circle")
            {
                tbWdh.Text = "Radius";
            }
            else if (selectFig == "Line" && tbWdh.Text == "")
            {
                tbWdh.Text = "X2";
            }
            else if(tbWdh.Text != "") 
            { }
            else
            {
                tbWdh.Text = "Width";
            }
        }

        private void tbHght_Leave(object sender, EventArgs e)
        {
            if (tbHght.Text == "" && selectFig == "Line")
            {
                tbHght.Text = "Y2";
            }
            else if (tbHght.Text == "")
            {
                tbHght.Text = "H";
            }
            else { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (svFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = svFD.FileName;
            System.IO.File.WriteAllText(filename, tbMain.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (opFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = opFD.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            tbMain.Text = fileText + "\r\n";


            Pen testPen = new Pen(Color.White, 10000);
            g = pbMain.CreateGraphics();
            g.DrawLine(testPen, 1, 1, 1000, 1000);

            Figires image = new Figires();
            for (int i=0; i < System.IO.File.ReadAllLines(filename).Length; i++)
            {
                using (var reader = new StreamReader(filename))
                {
                    string s;
                    string[] data;
                    while ((s = reader.ReadLine()) != null)
                    {
                        data = s.Split();
                        selectFig = data[0];
                        switch (data[0])
                        {
                            case "L":

                                Line figLine = new Line(int.Parse(data[1]),
                                    int.Parse(data[2]),
                                    int.Parse(data[3]),
                                    int.Parse(data[4]));
                                image.Add(figLine);
                                figLine.Draw(pbMain, int.Parse(data[5]),
                                    Color.FromArgb(Convert.ToInt32((data[6]))));
                                tbMain.Text += (figLine.getInfo() + "\r\n");

                                break;

                            case "R":

                                Rectangle figRectangle = new Rectangle(int.Parse(data[1]),
                                    int.Parse(data[2]),
                                    int.Parse(data[3]),
                                    int.Parse(data[4]));
                                image.Add(figRectangle);
                                figRectangle.Draw(pbMain, int.Parse(data[5]),
                                    Color.FromArgb(Convert.ToInt32((data[6]))));
                                tbMain.Text += (figRectangle.getInfo() + "\r\n");

                                break;

                            case "T":

                                Triangle figTriangle = new Triangle(int.Parse(data[1]),
                                    int.Parse(data[2]),
                                    int.Parse(data[3]),
                                    int.Parse(data[4]));
                                image.Add(figTriangle);

                                figTriangle.Draw(pbMain, int.Parse(data[5]),
                                    Color.FromArgb(Convert.ToInt32((data[6]))));

                                tbMain.Text += (figTriangle.getInfo() + "\r\n");

                                break;

                            case "C":
                                Circle figCircle = new Circle(int.Parse(data[1]),
                                    int.Parse(data[2]),
                                    int.Parse(data[3]));
                                image.Add(figCircle);

                                figCircle.Draw(pbMain, int.Parse(data[4]), 
                                    Color.FromArgb(Convert.ToInt32((data[5]))));

                                tbMain.Text += (figCircle.getInfo() + "\r\n");

                                image.Add(new
                                    Circle(int.Parse(data[1]),
                                    int.Parse(data[2]),
                                    int.Parse(data[3])));
                                break;

                            default:
                                break;
                        }
                    }
                }
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            MyDialog = new ColorDialog();

            MyDialog.AllowFullOpen = false;

            MyDialog.ShowHelp = true;

            MyDialog.Color = tbMain.ForeColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                tbMain.ForeColor = MyDialog.Color;
        }

        private void tbDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void tbDepth_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDepth_Leave(object sender, EventArgs e)
        {
            if (tbDepth.Text == "")
            {
                tbDepth.Text = "Tickness";
            }
        }

        private void tbWdh_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbWdh_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
