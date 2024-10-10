namespace CarApp;

internal class Program
{
    static void Main(string[] args)
    {
        Interfaces.IDAO dao = new DAOMock1.DAOMock1();

        Console.WriteLine("## Producers ##");
        foreach(Interfaces.IProducer p in dao.GetAllProducers()){
            Console.WriteLine(p);
        }

        Console.WriteLine("## Cars ##");
        foreach(Interfaces.ICar c in dao.GetAllCars()){
            Console.WriteLine(c);
        }
        
    }
}
