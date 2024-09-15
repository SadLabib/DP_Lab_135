using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }

        public void ManageDriver(Driver driver) { }
        public void ManageRider(Rider rider) { }
        public void ViewTripHistory(Trip trip) { }
        public void HandleDispute(Trip trip) { }
    }
}
