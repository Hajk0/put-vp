using System.Reflection;
using System.Configuration;

namespace CarApp;

internal class Program
{
    static void Main(string[] args)
    {
        //foreach (var arg in args) {
        //    Console.WriteLine(arg);
        //}
        string libraryName = ConfigurationManager.AppSettings["library_name"];

        Assembly assembly = Assembly.UnsafeLoadFrom(libraryName);
        Type typeToCreate = null;
        foreach (Type type in assembly.GetTypes()) {
            if ( type.IsAssignableTo(typeof(Interfaces.IDAO))) {
                typeToCreate = type;
                break;
            }
        }

        //Interfaces.IDAO dao = new DAOMock1.DAOMock1();
        Interfaces.IDAO dao = Activator.CreateInstance(typeToCreate) as Interfaces.IDAO;
        //Interfaces.IDAO dao2 = new DAOMock2.DAOMock2();

        Console.WriteLine("## Producers ##");
        foreach(Interfaces.IProducer p in dao.GetAllProducers()){
            Console.WriteLine(p);
        }

        Console.WriteLine("## Cars ##");
        foreach(Interfaces.ICar c in dao.GetAllCars()){
            Console.WriteLine(c);
        }


        /*Console.WriteLine("## Producers ##");
        foreach(Interfaces.IProducer p in dao2.GetAllProducers()){
            Console.WriteLine(p);
        }

        Console.WriteLine("## Cars ##");
        foreach(Interfaces.ICar c in dao2.GetAllCars()){
            Console.WriteLine(c);
        }*/
        
    }
}
