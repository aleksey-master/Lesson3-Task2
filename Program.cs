/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

int Ax = XYZ("x", "A");
int Ay = XYZ("y", "A");
int Az = XYZ("z", "A");
int Bx = XYZ("x", "B");
int By = XYZ("y", "B");
int Bz = XYZ("z", "B");

int XYZ(string point, string pointName)
{
    Console.Write($"Введите координату {point} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay) + (Bz - Az) * (Bz - Az));

double segmentLength = Math.Round(
    Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay) + (Bz - Az) * (Bz - Az)),
    2
);
Console.WriteLine($"Длина отрезка {segmentLength}");

