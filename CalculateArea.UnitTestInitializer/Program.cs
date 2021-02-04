using System;
using CalculateArea.Figures.Kind;
using CalculateArea.InputModels;

namespace CalculateArea.UnitTestInitializer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
       public  double Circle(double radius) 
            =>  new CircleService<CircleInput>(new CircleInput("Circle",radius)).GetArea();
       public  double Triangle(string kind, double firstLine,
           double secondLine, double thirdLine)
            => new TriangleService<TriangleInput>(new TriangleInput(kind, firstLine,
                                                                    secondLine, thirdLine)).GetArea();
    }
}
