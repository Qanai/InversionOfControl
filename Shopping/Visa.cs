using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shopping
{
    public class Visa : ICreditCard
    {
        public string Charge()
        {
            return "Charging with Visa!";
        }
    }
}
