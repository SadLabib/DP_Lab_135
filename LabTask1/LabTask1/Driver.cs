using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string VehicleType { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public bool Availability { get; set; }

        public void AcceptRide(Trip trip) { }
        public void RateRider(Rider rider, double rating) { }
        public void UpdateLocation(string newLocation) { }
        public void StartTrip(Trip trip) { }
    }
}
