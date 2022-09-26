/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("введите 3 координаты точки А");
int ax=Convert.ToInt32(Console.ReadLine());
int ay=Convert.ToInt32(Console.ReadLine());
int az=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите 3 координаты точки B");
int bx=Convert.ToInt32(Console.ReadLine());
int by=Convert.ToInt32(Console.ReadLine());
int bz=Convert.ToInt32(Console.ReadLine());

double res=Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2));
Console.WriteLine($"расстояние между данными точками = {res}");
