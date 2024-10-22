/* zadanie 1 */
using System.Threading.Channels;

Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a';
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";
Console.WriteLine(byteVariable + "\n" + integralVariable + "\n" + longVariable + "\n" + charVariable1 + "\n" + charVariable2 + "\n" + doubleVariable + "\n" + floatVariable + "\n" + stringVariable + "\n");
/* koniec zadania 1 */
/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";
long longNum = num;
int intNum = (int)bigNum;
int stringNewNum = int.Parse(stringNum);
Console.WriteLine(stringNum);
Console.WriteLine(longNum);
Console.WriteLine(stringNewNum);
/* koniec zadania 2 */
/* zadanie 3 */
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
int c = a + b;
int d = a - b;
int e = a * b;
int f = a / b ; 
int g = f++;
Console.WriteLine(c); Console.WriteLine(d); Console.WriteLine(e); Console.WriteLine(f); Console.WriteLine(g);
Console.WriteLine("\n"+price * price);
Console.WriteLine("\n" + doubleVal*doubleVal);
Console.WriteLine(Math.PI * radius * radius);
var hours = time / 60;
Console.WriteLine(hours);
var minutes = Math.Floor(time);
Console.WriteLine(minutes);
var seconds = Math.Floor(time);
Console.WriteLine(seconds);
/* koniec zadania 3 */
/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;
toIncrement = toIncrement++;
toDivide /= toDivide;
/* koniec zadania 4 */
/* zadanie 5 */
double degree = 45;
double sinValue;
sinValue = Math.Sin(degree);
/* koniec zadania 5 */
/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
var date1 = new DateTime(year, month, day, hour, minute,0);
Console.WriteLine(date1);
date1.AddMonths(3);
date1.AddHours(-1);
Console.WriteLine(date1.DayOfWeek);
/* koniec zadania 6 */
/* zadanie 7 */
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
string fPart = "";
fPart += firstPart + " " + secondPart + " " + thirdPart+" ";

Console.WriteLine(fPart.ToUpper());
Console.WriteLine(fPart.Length);
/* koniec zadania 7 */

/* zadanie 8 */
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool isTriangle = (lengthB + lengthC) > lengthA;
Console.WriteLine($"Trójkąt? - {isTriangle}");
// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
if (isTriangle)
{
    bool isTrg = (lengthC * lengthC + lengthB * lengthB)== lengthB * lengthB;
    Console.WriteLine($"Prostokatny - {isTrg}");
}
/* koniec zadania 8 */
/* zadanie 9 */
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if(conditionalString.Length > 10)
{
    Console.WriteLine(conditionalString);
}
/* koniec zadania 9 */
/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if(temperature > 20)
{
    Console.WriteLine("cieplo");
}
else if(temperature < 20)   
{
    Console.WriteLine("zimno");
}
/* koniec zadania 10 */
/* zadanie 11 */
int temperature11 = 20;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
Console.WriteLine($"{(temperature11 > 20 ? "Cieplo" : "Zimno")}");
/* koniec zadania 11 */
/* zadanie 12 */
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;
if(code < 10)
{
    productPrice = 3.5m;
}
else if(code <= 15)
{
    sellPrice = (decimal)0.95 * productPrice;
}
else
{
    if(quantity < 10)
    {
        sellPrice = (decimal)1.05 * productPrice;
    }
    else if(quantity < 20) 
    {

    }
    else if (quantity < 100)
    {
        int res =  quantity / 10;
        sellPrice = (100 - res) / 100 * productPrice;
    }
    else 
    {
        sellPrice = (decimal)0.90 * productPrice;
    }
}
Console.WriteLine($"Price: {sellPrice}");
/* koniec zadania 12 */
/* zadanie 13 */
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;
    case '2':
        Console.WriteLine($"Decimal number: 2");
        break;
    case '3':
        Console.WriteLine($"Decimal number: 3");
        break;
    case '4':
        Console.WriteLine($"Decimal number: 4");
        break;
    case '5':
        Console.WriteLine($"Decimal number: 5");
        break;
    case '6':
        Console.WriteLine($"Decimal number: 6");
        break;
    case '7':
        Console.WriteLine($"Decimal number: 7");
        break;
    case '8':
        Console.WriteLine($"Decimal number: 8");
        break;
    case '9':
        Console.WriteLine($"Decimal number: 9");
        break;
    case 'A':
        Console.WriteLine($"Decimal number: 10");
        break;
    case 'B':
        Console.WriteLine($"Decimal number: 11");
        break;
    case 'C':
        Console.WriteLine($"Decimal number: 12");
        break;
    case 'D':
        Console.WriteLine($"Decimal number: 13");
        break;
    case 'E':
        Console.WriteLine($"Decimal number: 14");
        break;
    case 'F':
        Console.WriteLine($"Decimal number: 15");
        break;

    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

/* koniec zadania 13 */
