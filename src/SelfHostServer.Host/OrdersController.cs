using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order {Id=1,Name ="Tomato Soup", Category = "groceries", Price = 1 },
            new Order {Id=2,Name ="Yo Yo", Category = "toys", Price = 3.75M}
        };



        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id=1,Name ="Tomato Soup"},
            new Product {Id=2,Name ="Yo Yo"}
        };



        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }

};

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}


