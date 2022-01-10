using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building();
            building.Adress = "ул. Ленина 1";
            building.Length = 60;
            Console.WriteLine(building.Adress);
            building.Width = 21;
            building.Height = 27;
            building.Print();
            Console.WriteLine();
            MultiBuilding multiBuilding= new MultiBuilding("ул. Ленина 2", 48, 24, 48, 16);
            multiBuilding.Print();
            Console.WriteLine(multiBuilding.Floor);
            Console.ReadKey();
        }
    }

    class Building
    {
        public string Adress { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building ()
        {

        }
        public Building (string adress = "Адрес не введен", double length = 0, double width = 0, double height = 0)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.Write("Адрес {0}, длина {1:F2}, ширина {2:F2}, высота {3:F2}", Adress, Length, Width, Height);
        }
    }

    sealed class MultiBuilding:Building
    {
        public byte Floor { get; set; }
        public MultiBuilding(string adress = "Адрес не введен", double length = 0, double width = 0, double height = 0, byte floor = 0)
        {
            Adress = adress;
            Length = length;
            Width = width;
            Height = height;
            Floor = floor;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine(", этажность {0}", Floor);
        }
    }
}
