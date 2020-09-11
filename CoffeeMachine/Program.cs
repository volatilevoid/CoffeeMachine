using CoffeeMachine.Builders;
using CoffeeMachine.Directors;
using System;

namespace CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CappucinoDirector cappuccinoMachine = new CappucinoDirector(new CappuccinoBuilder());
            IrishCoffeeDirector irishCoffeeMachine = new IrishCoffeeDirector(new IrishCoffeeBuilder());

            cappuccinoMachine.MakeMany(3);
            irishCoffeeMachine.MakeMany(2);
        }
    }
}
