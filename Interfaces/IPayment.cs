﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing.Interfaces
{
    public interface IPayment
    {
        bool ProcessPayment();
    }
}