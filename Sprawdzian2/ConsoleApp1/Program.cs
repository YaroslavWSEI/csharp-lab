using ConsoleApp1;

//Zadanie 1 - plik Point2D
// Zadanie 2
Human Mother = new Human();
Human Father = new Human();
Adult Child1 = new Adult();
Adult Child2 = new Adult();
Adult Child3 = new Adult();
Mother.Name = "Jane";
Father.Name = "John";
Child1.Name = "Kevin";
Child2.Name = "Mike";
Child3.Name = "Wendy";
Console.WriteLine($"Dorośli {Father.Name} i {Mother.Name} mający 3 dzieci:{Child1.Name},{Child2.Name} oraz {Child3.Name}");
//Koniec zadania 2

//Zadanie 3 
Human humanAdult = new Adult();
Console.WriteLine(humanAdult.EatSnack());
Human childAdult = new Child();
Console.WriteLine(childAdult.EatSnack());
//Koniec zadania 3

//Zadanie 4 
Human[] humans = { new Adult(), new Child() };
foreach (var h in humans)
{
    if (h is ISinger singer)
    {
        Console.WriteLine(singer.Sing());
    }
}
//Koniec zadania 4

//Zadanie 5
//Koniec zadania 5

//Zadanie 6
var Book1 = new Book { Title = "Ulysses", Author = "James Joyce", YearPublished = 1922 };
var Book2 = new Book { Title = "Lolita", Author = "Vladimir Nabokov", YearPublished = 1955 };
var Book3 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 };
var Book4 = new Book { Title = "In Search of Lost Time", Author = "Marcel Proust", YearPublished = 1913 };
List<Book> books = new List<Book>{Book1,Book2,Book3,Book4};
var authors = books.Select(b => b.Author).Distinct().OrderBy(a => a).ToList();
Console.WriteLine("Autorzy w kolejności alfabetycznej:");
foreach (var author in authors)
{
    Console.WriteLine(author);
}
var favBook = new Book { Title = "1984", Author = "George Orwell", YearPublished = 1949 };books.Add(favBook);
var Booksolder100 = books.Where(b => DateTime.Now.Year - b.YearPublished > 100).Select(b => b.Title).ToList();
Console.WriteLine("\nKsiążki starsze niż 100 lat:");
foreach (var title in Booksolder100)
{
    Console.WriteLine(title);
}
var OldBook = books.OrderBy(b => b.YearPublished).First();
books.Remove(OldBook);
//Koniec zadania 6