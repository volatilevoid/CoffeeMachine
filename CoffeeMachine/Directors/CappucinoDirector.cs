using CoffeeMachine.Builders;
using CoffeeMachine.Ingredients;
using CoffeeMachine.Products;
using CoffeeMachine.Recipe;
using System;

namespace CoffeeMachine
{
    public class CappucinoDirector
    {
        private readonly ICappuccinoBuilder _cappuccinoBuilder;
        public CappucinoDirector(ICappuccinoBuilder builder)
        {
            _cappuccinoBuilder = builder;
        }
        public Cappuccino Make()
        {
            return _cappuccinoBuilder
                .WithCoffee(new Coffee())
                .WithWater(new Water())
                .WitheMilk(new Milk())
                .WithWhiteSugar(new WhiteSugar())
                .Make();
        }
        public Cappuccino[] MakeMany(int numOfcappuccinos)
        {
            if(numOfcappuccinos < 1)
            {
                throw new System.ArgumentException("Parameter must be grater than zero", "numOfcappuccinos");
            }
            Cappuccino[] cappuccinos = new Cappuccino[numOfcappuccinos];
            for(int i = 0; i < numOfcappuccinos; i++)
            {
                cappuccinos[i] = Make();
            }
            return cappuccinos;
        }
    }
}
