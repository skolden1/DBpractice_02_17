using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBpractice_02_17
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? Name { get; set; }  //"?" gör att denna kan vara null(inget värde)
        public decimal Price { get; set; }
        public int OrderId { get; set; }

        public void CreateProductAndOrder(DbAppContext context, string input)
        {
            Order newOrder = new Order()
            {
                OrderDate = DateTime.Now
            };
            context.Orders.Add(newOrder);
            context.SaveChanges();

            Product product = null;

            if(input == "1")
            {
                product = new Product()
                {
                    Name = "Nike air",
                    Price = 9.99M,
                    OrderId = newOrder.OrderId 
                };
                Console.WriteLine($"You just bought {product.Name}, for {product.Price} $. OrderId: {newOrder.OrderId}");
               
            }
            else
            {
                product = new Product()
                {
                    Name = "Adidas pro",
                    Price = 8.99M,
                    OrderId = newOrder.OrderId
                };
                Console.WriteLine($"You just bought {product.Name}, for {product.Price} $. OrderId: {newOrder.OrderId}");
            }

            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
