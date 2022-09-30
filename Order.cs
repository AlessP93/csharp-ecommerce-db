public class Order
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Amount { get; set; }
    public bool Status  { get; set; }

    // ForeignKey - prendo la class Customer e la inietto in class Order
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    // ForeignKey - prendo la class Employee e la inietto in class Order
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    // Lista delgi ordini
    public List<Payment> Payment { get; set; } // LISTA (Molti a Molti )
    public List<Product> Product { get; set; }// LISTA (Molti a Molti )

}
