using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesign
{
    public class Beverage
    {
        public int Type { get; set; }
        public int Water { get; set; }

        public int Milk { get; set; }

        public int Sugar { get; set; }

        public int PowderQuantity { get; set; }

        public string BeverageName { get; set; }

        public string ShowBeverage()
        {
            return "Hot " + BeverageName + " [" + Water + " ml of Water";
        }
    }
}
