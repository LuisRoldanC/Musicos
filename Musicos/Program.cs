class Musico
{
    public string Nombre {get; set;}
    
    //Contructor
    public Musico (string n)
    {
    Nombre=n;
    }

    //Metodos
    public void Saluda ()
    {
    Console.WriteLine($"Hola soy {Nombre}");
    }
    public virtual void Tocar()
    {
    Console.WriteLine($"{Nombre} esta tocando su instrumento");
    }
}
class Baterista: Musico
{
public string Bateria {get; set;}

    //Constructor
public Baterista (string n, string b):base (n)
{
    Bateria=b;
}
    //Metodo
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando bateria");
    }
}
class Bajista: Musico
{
    public string Bajo {get; set;}
    //Constructor
    public Bajista (string n, string b):base(n)
    {
    Bajo=b;
    }

    //Metodo
    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando su bajo");
    }
}
class Program
{
    private static void Main(string[] args)
    {

    List<Musico> SickAndTired = new List<Musico>();
    SickAndTired.Add(new Bajista("Adri","Yamaha"));
    SickAndTired.Add(new Baterista("Ian","Pearl"));

    foreach (var Musico in SickAndTired)
    {
        Musico.Saluda();
    }
    foreach (var Musico in SickAndTired)
    {
        Musico.Tocar();
    }

    /*Musico Joji = new Musico("Joji");
    Joji.Tocar();
    Joji.Saluda();
    
    Baterista Ian = new Baterista("Ian","Pearl");
    Ian.Tocar();
    Ian.Saluda();

    Bajista Adri = new Bajista("Adri","Yamaha");
    Adri.Tocar();
    Adri.Saluda();
*/
    }
}