﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask1
{
    public interface IPaymentSystem
    {
        void MakePayment(decimal amount);
    }
}
