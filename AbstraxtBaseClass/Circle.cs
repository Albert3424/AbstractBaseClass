using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstraxtBaseClass
{
    class Circle : Shape, IHaveDiameter
    {
        double radius;
        public double Radius
        {
            get => radius;
            set => radius = SizeFilter(value);
        }
        public Circle(double radius,
            int startX, int startY, int lineWidth, Color color) 
            : base (startX, startY, lineWidth, color)
        {
            Radius = radius;
        }
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public override double GetPerimetr() => 2 * Math.PI * Radius;
        public double GetDiameter() => 2 * Radius;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, (float)StartX, (float)StartY, 2 * (float)Radius, 2 * (float)Radius);
            DrawDiameter(e);
        }
        public void DrawDiameter(System.Windows.Forms.PaintEventArgs e)
        {
            int dx = (int)(Radius * (1 - 1 / Math.Sqrt(2)));
            e.Graphics.DrawLine
                (
                new Pen(Color, 1),
                StartX + dx, StartY + dx,
                StartX + (int)GetDiameter() - dx, StartY + (int)GetDiameter() - dx
                );
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine($"Радиус круга: {Radius}");
            base.Info(e);
        }
    }
}
