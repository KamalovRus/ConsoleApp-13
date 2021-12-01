using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppЗадача_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building build1 = new Building("Address", 100, 50, 250);
            build1.Print();
            MultiBuilding build2 = new MultiBuilding(5, "Address2", 110, 80, 300);
            build2.Print();
        }
    }
    public class Building
    {
        public string BuildingAddress { get; set; }
        public double BuildingLength { get; set; }
        public double BuildingWidth { get; set; }
        public double BuildingHeight { get; set; }

        public Building(string buildingAddress, double buildingLength, double buildingWidth, double buildingHeight)
        {
            BuildingAddress = buildingAddress;
            BuildingLength = buildingLength;
            BuildingWidth = buildingWidth;
            BuildingHeight = buildingHeight;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Здание по адресу: {BuildingAddress}, его размеры: " +
                $"\n длина - {BuildingLength}" +
                $"\n ширина - {BuildingWidth} " +
                $"\n высота - {BuildingHeight}\n");
        }
    }
    public sealed class MultiBuilding : Building
    {
        public int BuildingFloorAmount { get; set; }

        public MultiBuilding(int buildingFloorAmount, string buildingAddress, double buildingLength, double buildingWidth, double buildingHeight) : base(buildingAddress, buildingLength, buildingWidth, buildingHeight)
        {
            BuildingFloorAmount = buildingFloorAmount;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество этажей - {BuildingFloorAmount}");
            Console.ReadKey();
        }
    }
}
    

