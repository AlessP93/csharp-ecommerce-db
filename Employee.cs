public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Level { get; set; }

    //inietto la lista degli ordini
    public List<Order> Orders { get; set; }
}
