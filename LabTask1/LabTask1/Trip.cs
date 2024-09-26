using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Trip
    {
        public int Id { get; set; }
        public string PickupLocation { get; set; }
        public string DropOffLocation { get; set; }
        public IRideType RideType { get; set; }
        public string Status { get; set; }
        public double Fare { get; set; }
        public double Distance { get; set; }

        public void CalculateFare() { }
        public void AssignDriver(Driver driver) { }
        public void CompleteTrip() { }
    }
}
