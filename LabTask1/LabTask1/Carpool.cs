using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class Carpool : IRideType
    {
        public decimal CalculateFare(decimal distance) 
        {
            decimal basefare = 0.5m * distance;
            return basefare;
        }
    }
}
