using System;

namespace POTTERIE_Louis_TP6_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var director = new Pizzaiolo();
            var builder = new PizzaCompleteBuilder();
            director.Builder = builder;
            
            Console.WriteLine("------- Builder design pattern -------");
            
            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListElement());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListElement());

            // Remember, the Builder pattern can be used without a Director
            // class.
            Console.WriteLine("Custom pizza without vegetables:");
            builder.ApplyCheese();
            builder.ApplyMeat();
            Console.WriteLine(builder.GetProduct().ListElement());
            
            Console.WriteLine("------- Behavioral design pattern Table tennis strategy -------");
            
            GameContext game = new GameContext(new Attack());

            game.CreatePoint("Louis");
            game.SetStrategy(new Defend());
            game.CreatePoint("Louis");
            Console.Read();
            
        }
    }
}