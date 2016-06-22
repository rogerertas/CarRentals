using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentalLibrary
{
    public abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public double CurrentMilage { get; set; }
        public double BaseDayPrice = 250;
        public double PriceModifier = 1;
    }
}