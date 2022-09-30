using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

Console.WriteLine("");

using (EcommerceContext db = new EcommerceContext())
{
    // inizio CRUD - CREATE
    Product newProduct = new Product { Name = "Iphone" , Description = "Pro 13 Pro Max 512gb", Price = "1489 €"};
    db.Add(newProduct);

    Customer newCustomer = new Customer { Name = "William Scott", Surname = "Pro 13 Pro Max 512gb", Email = "WillScott@gmail.it"};
    db.Add(newCustomer);


    // CRUD - READ
    Console.WriteLine("Recupero lista di Products");
    List<Product> Products = db.Products.OrderBy(Product => Product.Name).ToList<Product>();

    Console.WriteLine("Recupero lista di Customers");
    List<Customer> Customers = db.Customers.OrderBy(Customer => Customer.Name).ToList<Customer>();

    //CRUD UPDATE
    newProduct.Name = "Samsung";
    db.SaveChanges();

}
public class EcommerceContext : DbContext 
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ecommerce;Integrated Security=True;Pooling=False");
    }
}
