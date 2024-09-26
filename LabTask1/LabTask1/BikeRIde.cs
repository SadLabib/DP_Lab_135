using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public class BikeRIde : IRideType
    {
        public decimal CalculateFare(decimal distance)
        {
            return 1.0m * distance;
        }
    }
}
