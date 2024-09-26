using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Driver : User
    {
        public string VehicleType { get; set; }
        public string Location { get; set; }
        public bool Availability { get; set; }

        public void AcceptRide(Trip trip) { }
        public void RateRider(Rider rider, double rating) { }
        public void UpdateLocation(string newLocation) { }
        public void StartTrip(Trip trip) { }
    }
}
