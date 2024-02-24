using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesign
{
    public class Coffee : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            Console.WriteLine("Step 1 : Select Beverage");
            GetBeverage().Type = 1;
        }

        public override void SetWater()
        {
            Console.WriteLine("Step 2 : Adding water");
            GetBeverage().Water = 50;
        }

        public override void SetMilk()
        {
            Console.WriteLine("Step 3 : Adding Milk");
            GetBeverage().Milk = 30;
        }

        public override void SetSugar()
        {
            Console.WriteLine("Step 4 : Adding Sugar");
            GetBeverage().Sugar = 30;
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding Powerder");
            GetBeverage().PowderQuantity = 60;
        }
    }
}
