public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }    
    public string Surname { get; set; }
    public string Email { get; set; }

    //inietto la lista degli ordini
    public List<Order> Orders { get; set; } // LISTA (Molti a Molti )
}
