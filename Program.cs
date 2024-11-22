using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ParkingLot park = new ParkingLot();
            bool exit = true;
            
            while (exit) {
                Console.WriteLine("Welcome to parking lot management system");
                Console.WriteLine("If you want to add your car to parking lot,please enter 1");
                Console.WriteLine("If you want to remove your car from parking lot,please enter 2");
                Console.WriteLine("If you want to view your cars in parking lot,please enter 3");
                Console.WriteLine("If you want to exit,please enter 4");
                Console.WriteLine("Please,enter your choice(1-4)");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Please,enter the license plate: ");
                        string licencePlate = Console.ReadLine();
                        Console.Write("Please,enter the entry time (yyyy-MM-dd HH:mm): ");
                        string dateInput = Console.ReadLine();
                        
                        DateTime entryTime;
                        
                        if (DateTime.TryParse(dateInput, out entryTime))
                        {
                      
                            Car newCar = new Car(licencePlate, entryTime);
                        
                            park.AddCars(newCar);
                        }
                        else
                        {
                           
                            Console.WriteLine("Invalid date format.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Please,enter the licence plate of the car to remove : ");
                        string plateRemove = Console.ReadLine();
                        park.RemoveCar(plateRemove);
                        break;
                    case "3":
                        park.ViewCars();
                        break;
                    case "4":
                        Console.WriteLine("Exiting the system, see you :)");
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice,please try again.");
                        break;
                }
                if (exit)
                {
                    Console.WriteLine("Please,enter any key to continue...");
                    Console.ReadLine();
                }


            }
        }
    }
}
