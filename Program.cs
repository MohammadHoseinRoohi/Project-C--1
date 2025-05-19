using project4.Enums;

Console.WriteLine("Hello!");
var p1 = new Pirahan();
var p2 = new Pirahan();
p1.Parche.Material = Material.Plastic;
p1.Parche.Material = Material.Nakh;
p1.Dokme.Material = Material.Plastic;





public class Pirahan()
{
    public Parche? Parche { get; set; }
    public Dokme? Dokme { get; set; }

}
public class Parche()
{
    public Material Material { get; set; }
}
public class Dokme()
{
    public Material Material { get; set; }
}
