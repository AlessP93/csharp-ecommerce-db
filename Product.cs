public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }

    //inietto la lista degli ordini ( Molti a Molti )
    public List<Order> Orders { get; set; }

}