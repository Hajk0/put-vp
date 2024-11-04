using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAOMock2
{
    public class Producer : Interfaces.IProducer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"DAO2 {Id}: {Name}";
        }
    }
}