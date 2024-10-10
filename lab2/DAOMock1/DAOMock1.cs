using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace DAOMock1
{
    public class DAOMock1 : Interfaces.IDAO
    {
        private List<IProducer> producerList;
        private List<ICar> carList;

        public DAOMock1()
        {
            producerList = new List<IProducer>() {
                new Producer(){ Id=1, Name="VW" },
                new Producer(){ Id=2, Name="Kia"}
            };

            carList = new List<ICar>() {
                new Car() { Id = 1, Producer = producerList[0], Name="Passat", Transmission = TransmissionType.Automatic },
                new Car() { Id = 2, Producer = producerList[0], Name="Golf", Transmission = TransmissionType.Manual },
                new Car() { Id = 3, Producer = producerList[0], Name="Polo", Transmission = TransmissionType.Manual },
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
}