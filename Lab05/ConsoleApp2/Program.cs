using ConsoleApp1;

Coords point1 = new Coords(2.0, 5.0);
Console.WriteLine(point1);

Coords point2 = new Coords(3.0, 2.0); ;

if (point1.Equals(point2))
    Console.WriteLine("Equal structs");
else
    Console.WriteLine("Different structs");

//zadanie1
Console.WriteLine(LenghtOfTheLine());
static double LenghtOfTheLine()
{
    Coords point3 = new Coords(2.0, 5.0);
    Coords point4 = new Coords(3.0, 2.0);
    return Math.Sqrt((point3.X - point4.X) * (point3.X - point4.X) + (point3.Y - point4.Y) * (point3.Y - point4.Y));
}

 
static (int Min, int Max) FindMinMax(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        Console.WriteLine("Tablica nie może być pusta.");

    int min = numbers[0], max = numbers[0];
    foreach (var num in numbers)
    {
        if (num < min) min = num;
        if (num > max) max = num;
    }

    return (min, max);
}
Console.WriteLine(FindMinMax);