using Interfaces;

namespace DAOMock2;

public class DAOMock2 : Interfaces.IDAO
{
    private List<IProducer> producerList;
    private List<ICar> carList;

    public DAOMock2()
    {
        producerList = new List<IProducer>() {
            new Producer(){ Id=1, Name="BMW" },
            new Producer(){ Id=2, Name="Kia"}
        };

        carList = new List<ICar>() {
            new Car() { Id = 1, Producer = producerList[0], Name="1", Transmission = TransmissionType.Automatic },
            new Car() { Id = 2, Producer = producerList[0], Name="3", Transmission = TransmissionType.Manual },
            new Car() { Id = 3, Producer = producerList[0], Name="5", Transmission = TransmissionType.Manual },
            new Car() { Id = 4, Producer = producerList[1], Name="Rio", Transmission = TransmissionType.Manual },
        };
    }

    public ICar CreateNewCar()
    {
        return new Car();
    }

    public IEnumerable<ICar> GetAllCars()
    {
        return carList;
    }

    public IEnumerable<IProducer> GetAllProducers()
    {
        return producerList;
    }
}
