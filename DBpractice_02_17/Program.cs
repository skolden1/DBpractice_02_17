using DBpractice_02_17;

Product handleProduct = new Product();
using DbAppContext context = new DbAppContext();

Console.WriteLine("Choose shoe:");
Console.WriteLine("1) Nike air");
Console.WriteLine("2) Adidas pro");

string choice = Console.ReadLine();

handleProduct.CreateProductAndOrder(context, choice);

