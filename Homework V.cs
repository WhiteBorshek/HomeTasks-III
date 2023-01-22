/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int ax = Coordinate ("x", "a");
int ay = Coordinate ("y", "a");
int az = Coordinate ("z", "a");
int bx = Coordinate ("x", "b");
int by = Coordinate ("y", "b");
int bz = Coordinate ("z", "b");
int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double ax, double bx, 
                double ay, double by, 
                double az, double bz){
return Math.Sqrt(Math.Pow((bx-ax), 2) + 
                   Math.Pow((by-ay), 2) + 
                   Math.Pow((bz-az), 2));
}
double segmentLength =  Math.Round (Decision(ax, bx, ay, by, az, bz), 2 );
Console.WriteLine($"Длина отрезка  {segmentLength}");
