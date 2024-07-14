// Learning join operation in LINQ expressions

using System;

class Program
{
    public class JobSummary
    {
        public string Throughtput { get; set; } = string.Empty;
        public string Collector { get; set; }  = string.Empty;
        public double ADCInValue { get; set; } = 0;
        public double ADCOutValue { get; set;} = 0;

        public JobSummary() { 
        }

    }


    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public Customer() { }

    }

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; } = String.Empty;
        public string OrderName { get; set; } = String.Empty;

        public Order() { }
    }

    static void Main()
    {
        List<Customer> customers = new List<Customer>
       {
           new Customer { Id = 1, Name = "Rahul", Description = "Old Customer"},
           new Customer { Id = 2, Name = "Raju", Description = "Old Customer"},
           new Customer { Id = 3, Name = "Prashant", Description = "New Customer"},
           new Customer { Id = 4, Name = "Simbi", Description = "Old Customer"},
           new Customer { Id = 5, Name = "Pratibha", Description = "New Customer"}
       };

        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "Prashant", OrderName = "Butane Gas"},
            new Order { OrderId = 2, CustomerName = "Simbi", OrderName = "Lehenga"},
            new Order { OrderId = 3, CustomerName = "Pratibha", OrderName = "Laptop"},

        };

        // I want to know description of customers who all have placed the order

        var customerDescription = from cust in customers
                                  join od in orders
                                  on cust.Name equals od.CustomerName
                                  select new { cust.Name, cust.Description };


        foreach (var item in customerDescription)
        {
            Console.WriteLine($"{item.Name} is a {item.Description}");
        }


    }
}
