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

    Customer newCustomer = new Customer { Name = "William", Surname = " Scott", Email = "WillScott@gmail.it"};
    db.Add(newCustomer);


    //CRUD - READ
    Console.WriteLine("Recupero lista di Products");
    List<Product> Products = db.Products.OrderBy(Product => Product.Name).ToList<Product>();

    foreach (Product product in Products)
    {
        Console.WriteLine("- " + product.Name + " " + product.Description + " - " + product.Price + "\n");
    }

    Console.WriteLine("Recupero lista di Customers");
    List<Customer> Customers = db.Customers.OrderBy(Customer => Customer.Name).ToList<Customer>();

    foreach (Customer customer in Customers)
    {
        Console.WriteLine("- " + customer.Name + " " + customer.Surname + " - " + customer.Email + "\n");
    }

    //CRUD UPDATE
    //newProduct.Name = "Samsung";
    //db.SaveChanges();
    db.removeProduct(newProduct);
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

    public void addProduct(Product item)
    {
        Product.Add(item);
    }
    public void removeProduct(Product item)
    {
        Product.Remove(item);
    }
}
