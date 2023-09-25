﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_1.Entities.ComputerComponents;
using Week1_1.Enums;

namespace Week1_1.Entities
{
    internal class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CPU { get; set; }
        public RAM RAM { get; set; }

        public Storage Storage { get; set; }
        public Computer()
        {
            Random random = new Random();
            Id = random.Next(1000, int.MaxValue);
        }

        public Computer(string brand, string model) : this()
        {

            Brand = brand.ToUpper();
            Model = model;

        }
        public Computer(string brand, string model, string cPU, RAM rAM, Storage storage) : this(brand, model)
        {
            CPU = cPU;
            RAM = rAM;
            Storage = storage;
        }
    }
}
