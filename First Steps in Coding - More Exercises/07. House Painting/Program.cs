using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double xHouse = double.Parse(Console.ReadLine());
            double yWall = double.Parse(Console.ReadLine());
            double hRoof = double.Parse(Console.ReadLine());

            //walls
            double sideWallArea = xHouse * yWall;
            double windowArea = 1.5 * 1.5;
            double twoSide = 2 * sideWallArea - 2 * windowArea;
            double behindWall = xHouse * xHouse;
            double entrance = 1.2 * 2;
            double totalFrontBehind = 2 * behindWall - entrance;
            double totalAreaWalls = twoSide + totalFrontBehind;

            double greenPaint = totalAreaWalls / 3.4;

            //roof
            double twoRectanglesRoof = 2 * (xHouse * yWall);
            double twoTriangles = 2 * (xHouse * hRoof / 2);
            double totalAreaRoof = twoRectanglesRoof + twoTriangles;

            double redPaint = totalAreaRoof / 4.3;

            //total liters
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
