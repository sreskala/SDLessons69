﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Currency
{
    public class Penny : ICurrency
    {
        public string Name => "Penny";

        public decimal Value => 0.01m;
    }

    public class Dime : ICurrency
    {
        public string Name => "Dime";
        public decimal Value => 0.10m;
    }

    public class Nickel : ICurrency
    {
        public string Name => "Nickel";
        public decimal Value => 0.05m;
    }

    public class Quarter : ICurrency
    {
        public string Name => "Quarter";
        public decimal Value => 0.25m;
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";
        public decimal Value => 1.00m;
    }

    public class ElectronicPayment : ICurrency
    {
        public string Name => "Electronic Payment";
        public decimal Value { get; }

        public ElectronicPayment(decimal value)
        {
            Value = value;
        }
    }
}
