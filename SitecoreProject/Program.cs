// See https://aka.ms/new-console-template for more information
using SitecoreProject.SimpleFigures.Difficulty1and2;
using SitecoreProject.SimpleFigures.Difficulty3;

IFigure cir1 = new Circle(1,2,5);
IFigure cir2 = new Circle(-4, 8, 5);
IFigure point1 = new Point(1, 3);
IFigure line1 = new Line(4, 2, 6, 9);

Aggregation aggregation = new();

aggregation.AddFigure(cir1);
aggregation.AddFigure(point1);
aggregation.AddFigure(cir2);
aggregation.AddFigure(line1);


aggregation.RotateFigures();

aggregation.MoveFigures(1, 6);

