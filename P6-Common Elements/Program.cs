using System.ComponentModel.Design;
using System.Xml.Schema;

string currency = Console.ReadLine();
int sum = int.Parse(Console.ReadLine());
double itemPrice = 1000; // You can set the item price here

if (currency == "EUR")
{
    double total = (sum * 1.955830);
    Console.WriteLine($"Total money for exchange is {total:F2} BGN");

    if (total < itemPrice)
    {
        double remaining = itemPrice - total;
        Console.WriteLine($"You need to pay {remaining:F2} BGN more for the item.");
    }
}
else if (currency == "BGN")
{
    double total = sum / 1.955830;
    Console.WriteLine($"Total money for exchange is {total:F2} EUR");
}








