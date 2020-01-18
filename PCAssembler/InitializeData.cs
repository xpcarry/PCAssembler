using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssembler
{
    public class InitializeData
    {
        private Composite list;
        public InitializeData()
        {
            if (list == null)
            {
                SeedData();
            }
        }

        public Composite SeedData()
        {
            list = new Composite();

            Component cpu1 = new CPU
            {
                Name = "Intel Core i5-9600KF",
                Type = "Procesor",
                Efficency = 30,
                Price = 899
            };
            Component cpu2 = new CPU
            {
                Name = "Intel Pentium G5400",
                Type = "Procesor",
                Efficency = 10,
                Price = 250
            };
            Component cpu3 = new CPU
            {
                Name = "Procesor AMD Ryzen 5",
                Type = "Procesor",
                Efficency = 20,
                Price = 600
            };
            Component gpu1 = new GraphicCard
            {
                Name = "Gigabyte GeForce RTX 2070",
                Efficency = 35,
                Type = "GPU",
                Price = 2339,
            };
            Component gpu2 = new GraphicCard
            {
                Name = "MSI GeForce GTX 1660",
                Efficency = 25,
                Type = "GPU",
                Price = 1019,
            };
            Component gpu3 = new GraphicCard
            {
                Name = "Gigabyte GeForce GTX 1050Ti",
                Efficency = 15,
                Type = "GPU",
                Price = 629,
            };
            Component ram1 = new RAM
            {
                Name = "HyperX Fury DDR4 16GB",
                Efficency = 15,
                Type = "RAM",
                Price = 292,
            };
            Component ram2 = new RAM
            {
                Name = "HyperX Fury DDR4 8GB",
                Efficency = 5,
                Type = "RAM",
                Price = 150,
            };
            Component ram3 = new RAM
            {
                Name = "Kingston DDR4 16GB",
                Efficency = 13,
                Type = "RAM",
                Price = 250,
            };
            Component mb1 = new Mainboard
            {
                Name = "MSI B450-A PRO MAX ",
                Type = "Mainboard",
                Efficency = 20,
                Price = 419,
            };
            Component mb2 = new Mainboard
            {
                Name = "Gigabyte X570 GAMING X",
                Type = "Mainboard",
                Efficency = 10,
                Price = 769
            };

            list.Add(cpu1);
            list.Add(cpu2);
            list.Add(cpu3);
            list.Add(gpu1);
            list.Add(gpu2);
            list.Add(gpu3);
            list.Add(ram1);
            list.Add(ram2);
            list.Add(ram3);
            list.Add(mb1);
            list.Add(mb2);

            return list;
        }



    }
}
