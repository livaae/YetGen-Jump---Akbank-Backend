using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_1.Enums;
using Week1_1.ValueObjects;

namespace Week1_1.Entities.ComputerComponents
{
    internal class Storage
    {

        public string Brand { get; set; }
        public Capacity  Capacity{ get; set; }
        public Storage()
        {

        }
        public Storage(string brand, Capacity capacity)
        {
            Brand = brand;
            Capacity = capacity;
        }

    }


}
