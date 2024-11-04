using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace DAOMock2
{
    public class Car : Interfaces.ICar
    {
        public int Id { get; set; }
        public IProducer Producer { get; set; }
        public string Name { get; set; }
        public TransmissionType Transmission { get; set; }

        public override string ToString()
        {
            return $"DAO2 {Id}: {Producer.Name} {Name} {Transmission}";
        }
    }
}