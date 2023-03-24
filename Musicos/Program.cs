abstract class Musico //La clase abtracta solo puede generar soluciones
{
    public string Nombre {get; set;}
    
    //Contructor
    public Musico (string n)
    {
    Nombre=n;
    }

    //Metodos
     public virtual void Saludar() => Console.WriteLine(GetSaludo()); //refactorizando el saludo para reutilizar.
    public virtual string GetSaludo () =>" Hola,soy " + Nombre;
    public virtual void Saludo() => Console.WriteLine("Hola soy (GetSaludo())");
    public /*virtual*/ abstract void Tocar();//Console.WriteLine($"{Nombre} esta tocando su instrumento");
    
    //Los metodos abstractos no tienen implementacion, deben estar en clase del mismo tipop astracto
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
    public override /*new*/ void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando bateria");
    }
    public override string GetSaludo() => base.GetSaludo() + " y soy baterista";
    public override void Saludo() => Console.WriteLine(GetSaludo());
   
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
    public override /*new*/ void Tocar()
    {
        Console.WriteLine($"{Nombre} esta tocando su bajo");
    }
    public override string GetSaludo() => base.GetSaludo() + " y soy bajista";
    public override void Saludo() => Console.WriteLine(GetSaludo());
}
class Program
{
    private static void Main(string[] args)
    {

    List<Musico> SickAndTired = new List<Musico>(); //Con la clase abstracta solo se pueded crear referencias de tipo musico


    SickAndTired.Add(new Bajista("Adri","Yamaha"));
    SickAndTired.Add(new Baterista("Ian","Pearl"));

    foreach (var Musico in SickAndTired)
    {
        Musico.Saludar();
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

//Polimorfismo: Los objetos pueden cambiar su comportamiento dependiendo
    }
}