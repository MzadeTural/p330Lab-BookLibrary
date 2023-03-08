using BookLibrary.Models;

Console.WriteLine("How many books will you enter the system?");
int Quantity =Convert.ToInt32(Console.ReadLine());
Book[] books = new Book[Quantity];
for (int i = 0; i < Quantity; i++)
{
    Console.WriteLine("\n---------------------------\n" + $"{i + 1} Book Informations" + "\n---------------------------\n");
    int no = i + 1;
    Console.WriteLine("Enter genre name:");
    string genere = Console.ReadLine();
    Console.WriteLine("Enter name:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter  count:");
    int count = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter price:");
    double price = Convert.ToInt32(Console.ReadLine());
    books[i] = new Book(no, name, price, genere);
    
}
Console.WriteLine("\n===============================" +
    "\n1.Show all book and info " +
    "\n2.Filter by price range" +              
    "\n3.Close program");

Console.WriteLine("Please Choose");
string input = Console.ReadLine().Trim();
switch (input)
{
    case "1":       
        foreach (var book in books )
        {
            Console.WriteLine(book.GetInfo());
        }
        break;
    case "2":
        Console.WriteLine("Enter min value");
        double min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter max value");
        double max = Convert.ToInt32(Console.ReadLine());

        foreach (var item in FilterBook(books, min, max))
        {
            Console.WriteLine(item.GetInfo());
        }
        break;
    case "3":
        Environment.Exit(0);
        break;

    default:
        Console.WriteLine("Invalid Input");
        break;

}

//Bu metod evvelce massivde hemin qiymet araliqinda nece element var tapriq ve ardindan hemn uzunluqda basqa bir massiv yaradb o araliqa uygun gelen kitablari o masssive yigib massivi return edirik
static Book[] FilterBook(Book[] books, double min, double max)
{
    int count = 0;
    for (int i = 0; i < books.Length; i++)
    {
        if (books[i].Price >= min && books[i].Price <= max)
        {
            count++;
        }

    }
    Book[] filtredArr = new Book[count];
    int j = 0;
    for (int i = 0; i < books.Length; i++)
    {
        if (books[i].Price >= min && books[i].Price <= max)
        {
            filtredArr[j] = books[i];
            j++;
        }
    }
    if (filtredArr.Length == 0)
        Console.WriteLine("The book is not available in this price range");
    return filtredArr;
}































