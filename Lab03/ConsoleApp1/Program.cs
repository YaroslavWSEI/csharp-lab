//zad1
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


Console.WriteLine("Zadanie 1");
int n = 10;
do
{
    Console.Write(n);
    n--;
}
while (n >= 0);
{
}
Console.WriteLine("\n");


//zad2
Console.WriteLine("Zadanie 2");
string pass;
Console.WriteLine("Wpisz hasło:");
do
{

pass = Console.ReadLine();
} while (pass != "koniec");
Console.WriteLine("\n");

Console.WriteLine("Zad3");
int a = 1;
Console.WriteLine("Liczby parzyste");
while (a <= 100) 
{
    if(a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a++;
}
Console.WriteLine("\n");

Console.WriteLine("Zad4");
for(int i=0; i < 16; i++)
    Console.WriteLine(i*i);
Console.WriteLine("\n");

Console.WriteLine("Zad5");
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int element in numbers)
{
    if(element% 7 == 0)
    {
        Console.WriteLine(element);
        break;
    }
}
Console.WriteLine("\n");

Console.WriteLine("Zad7");
double[] intArray = new double[20];
for(int i=0; i < 20; i++)
{
    intArray[i] = Math.Sqrt(i);
    Console.WriteLine(intArray[i]);
}
Console.WriteLine("\n");

//Console.WriteLine("Zad8");
//int[,] matrix = new int[3, 4];
//for(int column = 0; column < 3; column++)
//{
//    for (int row = 0; row < 4;row++)
//    {
//        matrix[column,row] = column + row;
//    }
//}
//int[,] t = new int[3, 4];
//for (int column = 0; column < 3; column++)
//{
//    for (int row = 0; row < 4; row++)
//    {
//        t[row, column] = matrix[column,row];
//    }
//}
//Console.WriteLine("\n");

Console.WriteLine("Zad10");
void PrintUpper(string txt) 
{
    Console.WriteLine(txt.ToUpper());
}

Console.WriteLine("\n");

Console.WriteLine("Zad11");
string EvenOrOdd1(int toCheck)
{
    string retStr = "";
    if(toCheck%2 == 0)
    {
        retStr = "Even";
    }
    else 
    {
        retStr = "Odd";
    }
    return retStr;
}
string EvenOrOdd2(int toCheck)
{
    if (toCheck % 2 == 0)
        return "Even";
    else
        return "Odd";
}
Console.WriteLine("\n");

Console.WriteLine("Zad12");
Console.WriteLine("\n");

Console.WriteLine("Zad13");
void WczytajZKlawiatury(out int n, out int m)
{
    Console.WriteLine("Podaj liczbe n (wiersze): ");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("Podaj liczbe m (kolumny): ");
    m = int.Parse(Console.ReadLine());
}

char[,] WypelnijTablice(int n, int m)
{
    char[,] tablica = new char[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            tablica[i, j] = (i == 0 || i == n - 1 || j == 0 || j == m - 1) ? '#' : ' ';
        }
    }
    return tablica;
}

void WyswietlTabliceNaEkran(char[,] tablica, int n, int m)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(tablica[i, j]);
        }
        Console.WriteLine();
    }
}

void Main()
{
    int n, m;
    WczytajZKlawiatury(out n, out m);
    char[,] tablica = WypelnijTablice(n, m);
    WyswietlTabliceNaEkran(tablica, n, m);
}

Main();

Console.WriteLine("\n");