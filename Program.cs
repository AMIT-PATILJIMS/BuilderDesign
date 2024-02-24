namespace BuilderDesign
{
    public class Program
    {
        public static void Main()
        {
            Beverage beverage;

            BeverageDirector beverageDirector = new BeverageDirector();

            Coffee coffee = new Coffee();

            beverage = beverageDirector.MakeBeverage(coffee);

            Console.WriteLine(beverage.ShowBeverage());
        }
    }
}