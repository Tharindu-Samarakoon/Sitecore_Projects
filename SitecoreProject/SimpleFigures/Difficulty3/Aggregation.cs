using SitecoreProject.SimpleFigures.Difficulty1and2;
using System.Collections;

namespace SitecoreProject.SimpleFigures.Difficulty3
{
    internal class Aggregation
    {
        //List for storing the figures
        private List<IFigure> figures;

        public Aggregation()
        {
            this.figures = new List<IFigure>();
        }

        /* 
        Method for adding a new figure to the figureList
        */                              
        public void AddFigure(IFigure figure)
        {
            this.figures.Add(figure);
        }

        /* 
        Method to call rotate method of all figures in the list
        */
        public void RotateFigures()
        {
            foreach(IFigure figure in figures)
            {
                figure.Rotate();
            }
        }

        /* 
        Method to call move method of all figures in the list.
        */
        public void MoveFigures(int x, int y)
        {
            foreach (IFigure figure in figures)
            {
                figure.Move(x, y);
            }
        }
    }
}
