using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossesBilarOchBågar
{
    class Runtime
    {

        List<Vehicles> VehicleList = new List<Vehicles>();

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("1 Visa fordon");
            Console.WriteLine("2 för att lägga fordon i systemet");
            Console.WriteLine("3 för att ta bort fordon ur system");
            Console.WriteLine("4 för att ändra antal fordon i systemet");
            Console.WriteLine("5 för att avsluta");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": ShowVehicles(); break;
                case "2": AddVehicle(); break;
                case "3": Removevehicle(); break;
                case "4": BuyOrSellVehicle(); break;
                case "5":
                    Environment.Exit(0); break;
                    Console.ReadLine();
            }
        }
        public void ShowVehicles()
        {

            Console.WriteLine("Visa nya eller begangnade-? N/B");

            string input = Console.ReadLine().ToUpper();
            switch (input)
            {










                case "N":
                    Vehicles[] newCarsOnly = VehicleList.Where(NewCars => String.Equals(NewCars.NewOrUsed, "Ny")).ToArray();
                        
                    foreach (var showVehicle in newCarsOnly)
                    {
                        Console.WriteLine(showVehicle);
                    }
                    Console.ReadLine();
                    Start();
                    ; break;




                case "B":
                    Vehicles[] usedCarsOnly = VehicleList.Where(NewCars => String.Equals(NewCars.NewOrUsed, "Begangnad")).ToArray();

                    foreach (var showVehicle in usedCarsOnly)
                    {
                        Console.WriteLine(showVehicle);
                    }
                    Console.ReadLine();
                    Start();
                    ; break;




            }

        }
        public void AddVehicle()
        {            
            Vehicles newcars = new Vehicles();


            Console.WriteLine("Är fordonet nytt eller begangnat? N/B");
            
            string input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "N": newcars.NewOrUsed ="Ny"; break;
            case"B": newcars.NewOrUsed = "Begangnad";break;

            }

            Console.WriteLine("skriv in modell");
            newcars.Model = Console.ReadLine();
            Console.WriteLine("skriv in tillverkare ");
            newcars.Manufacturer = Console.ReadLine();
            Console.WriteLine("skriv in årtal ");
            newcars.YearOfMake = int.Parse(Console.ReadLine());

            newcars.AmountOfProduct = 1;

            VehicleList.Add(newcars);

            Console.ReadLine();
            Start();
        }

        public void Removevehicle()

        {
            int num2 = 0;
            Console.Clear();
           
            for (int i = 0; i < VehicleList.Count; i++)
            {
                Console.WriteLine("Rad " + (i + 1) + "   -   " + VehicleList[i]);
            }
            Console.WriteLine("Vilken rad vill du ta bort?");
            string input = Console.ReadLine();
            int.TryParse(input, out num2);
            VehicleList.RemoveAt(num2 - 1);
            
            Start();
        }
        public void BuyOrSellVehicle()
        {
            int num2 = 0;
            Console.Clear();

            for (int i = 0; i < VehicleList.Count; i++)
            {
                Console.WriteLine("Rad " + (i + 1) + "   -   " + VehicleList[i]);
            }
            Console.WriteLine("Vilken rad vill du ändra antal på?");
            string input = Console.ReadLine();
            int.TryParse(input, out num2);
            Console.WriteLine("Vad är det nya antalet?");
            int newAmountOfProduct =int.Parse( Console.ReadLine());
            VehicleList[num2-1].AmountOfProduct =newAmountOfProduct;

            Start();
        }
    }
}
