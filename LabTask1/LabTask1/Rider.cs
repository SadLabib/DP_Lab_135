using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Rider : User
    {
     
        public string Location { get; set; }

        public void RequestRide() { }
        public void RateDriver(Driver driver, double rating) { }

    }
}
