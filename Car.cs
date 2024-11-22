using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm2
{
    internal class Car
    {
        private string LicencePlate; 
        DateTime EntryTime;

        public Car(string aLicencePlate,DateTime aEntryTime)
        {
            LicencePlate = aLicencePlate;
            EntryTime = aEntryTime;
        }
        
        public string GetLicencePlate()
        {
            return LicencePlate;    
        }
        
        public DateTime GetEntryTime()
        {
            return EntryTime;
        }
    }
}
