using DBpractice_02_17;

using DbAppContext context = new DbAppContext();

Order newOrder = new Order()
{
    OrderDate = DateTime.Now
};
context.Orders.Add(newOrder);
context.SaveChanges();

Product nikeShoes = new Product()
{
    Name = "Nike air",
    Price = 9.99M,
    OrderId = newOrder.OrderId
};

context.Products.Add(nikeShoes);

Order secondOrder = new Order()
{
    OrderDate = DateTime.Now
};
context.Orders.Add(secondOrder);
context.SaveChanges();

Product adidasShoes = new Product()
{
    Name = "Adidas pro",
    Price = 8.99M,
    OrderId = secondOrder.OrderId
};
context.Products.Add(adidasShoes);
context.SaveChanges();