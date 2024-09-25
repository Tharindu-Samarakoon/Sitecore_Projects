using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SitecoreProject.SimpleFigures.Difficulty1and2
{
    internal class Circle : IFigure
    {

        private Point Center { get; set; }
        private int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            this.Center = new Point(x, y);
            this.Radius = radius;
        }

        public void Move(int x, int y)
        {
            //Change the center of the circle to the new position given.
            Console.WriteLine("Circle is moving...");
            this.Center = new Point(x, y);
        }

        public void Rotate()
        {
            Console.Write("Circle is rotating...");
        }
    }
}
