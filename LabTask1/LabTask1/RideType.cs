using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public abstract class RideType
    {
        public double BaseFare { get; set; }
        public int Capacity { get; set; }

        public void CalculateFareRules() { }
    }

    public class Carpool : RideType { }
    public class LuxuryRide : RideType { }
    public class BikeRide : RideType { }
}
