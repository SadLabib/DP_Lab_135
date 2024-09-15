using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Rider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }

        public void RequestRide() { }
        public void RateDriver(Driver driver, double rating) { }
        public void MakePayment(PaymentMethod paymentMethod) { }

    }
}
