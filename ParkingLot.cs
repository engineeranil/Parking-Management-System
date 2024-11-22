using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class ParkingLot
    {
        Car[] cars = new Car[20];
        int currentlyParked = 0;
        const int hourlyRate = 5;

        public bool AddCars(Car newCar) 
        {
           
            if (currentlyParked < cars.Length) 
            {
               
                cars[currentlyParked] = newCar;
               
                currentlyParked++;
                
                Console.WriteLine("The car is parked successfully : "+ newCar.GetLicencePlate());
                return true;
            }
            else
            {
                Console.WriteLine("This parking lot is full so unfortunatelly you can not parking here");
            }
            return false;
        }

        public bool RemoveCar(string licencePlate)
        {
           
            for (int i = 0; i < currentlyParked; i++)
            {
                
                if (cars[i] != null && cars[i].GetLicencePlate() == licencePlate)  
                {
                   
                    Console.WriteLine("Car is removing : "+cars[i].GetLicencePlate());

                   
                    CalculateParkingFee(cars[i]);

                    
                    cars[i] = null;

                    
                    for (int j = i; j < currentlyParked - 1; j++)
                    {
                        cars[j] = cars[j + 1];
                    }
                   
                    cars[currentlyParked - 1] = null;
                   
                    currentlyParked--;
                  
                    return true;
                }
            }
           
            Console.WriteLine("Car not found.");
            return false;
        }


        public int CalculateParkingFee(Car car)
        {
           
            DateTime entryTime = car.GetEntryTime();
            
            DateTime currentlyTime = DateTime.Now;
            
            int days = (currentlyTime.Date - entryTime.Date).Days;
           
            int hours = currentlyTime.Hour - entryTime.Hour;
            
            if (days > 0)
            {
                hours += days * 24;
            }
           
            
            if (currentlyTime.Minute < entryTime.Minute)
            {
                hours -= 1;
            }
           
            int fee = (int)Math.Ceiling(hours / 1.0)*hourlyRate;
            
            Console.WriteLine("Car : "+car.GetLicencePlate()+" Duration : " +hours+" Hours "+" Fee : "+fee+" $");
           
            return fee;
        }
        public void ViewCars()
        {
            if (currentlyParked == 0)
            {
                Console.WriteLine("Currently parking lot is empty");
            }
            else
            {
                Console.WriteLine("Parked cars : ");
                for (int i = 0; i < currentlyParked; i++)
                {
                    Console.WriteLine("Plate : " + cars[i].GetLicencePlate());
                    Console.WriteLine("Entry time : " + cars[i].GetEntryTime());
                }
            }
        }

    }
}
