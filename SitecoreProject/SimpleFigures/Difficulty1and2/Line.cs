namespace SitecoreProject.SimpleFigures.Difficulty1and2
{
    internal class Line : IFigure
    {

        private Point start;
        private Point end;

        public Line(int sx, int sy, int ex, int ey)
        {
            this.end = new Point(sx, sy);
            this.start = new Point(ex, ey);
        }

        public void Move(int x, int y)
        {
            Console.WriteLine("Line is moving...");
            //Move the line in the x and y directions by the specified number
            //ASSUMPTION : Points can lie in the negative X and Y plane
            this.start = new Point(this.start.x + x, this.start.y + y);
            this.end = new Point(this.end.x + x, this.end.y + y);
        }

        public void Rotate()
        {
            Console.WriteLine("Line is rotating...");
            // Swap start and end points
            Point temp = this.start;
            this.start = this.end;
            this.end = temp;

        }
    }
}
