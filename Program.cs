Console.WriteLine("Input x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z1");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input z2");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = 0;
    distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
    return distance;
}
Console.WriteLine(GetDistance(x1, y1, z1, x2, y2, z2));
