
namespace SitecoreProject.SimpleFigures.Difficulty1and2
{
    internal class Point : IFigure
    {
        //Position of point on x axis
        public int x;
        //Position of point on y axis
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("Point is moving...");
            //Set the new point with the x y coordinates.
            this.x = x;
            this.y = y;
        }

        public void Rotate()
        {
            Console.WriteLine("Point is rotating...");
        }
    }
}
