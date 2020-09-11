using CoffeeMachine.Builders;
using CoffeeMachine.Ingredients;
using CoffeeMachine.Products;
using System;
using System.Text;

namespace CoffeeMachine.Directors
{
    class IrishCoffeeDirector
    {
        private readonly IIrishCoffeeBuilder _irishCoffeeBuilder;
        public IrishCoffeeDirector(IIrishCoffeeBuilder builder)
        {
            _irishCoffeeBuilder = builder;
        }
        public IrishCoffee Make()
        {
            return _irishCoffeeBuilder
                .WithCoffee(new Coffee())
                .WithBrownSugar(new BrownSugar())
                .WithIrishWhiskey(new IrishWhiskey())
                .WithFreshCream(new FreshCream())
                .Make();
        }
        public IrishCoffee[] MakeMany(int numOfIrishCoffees)
        {
            if (numOfIrishCoffees < 1)
            {
                throw new System.ArgumentException("Parameter must be grater than zero", "numOfIrishCoffees");
            }
            IrishCoffee[] irishCoffees = new IrishCoffee[numOfIrishCoffees];
            for(int i = 0; i < numOfIrishCoffees; i++)
            {
                irishCoffees[i] = Make();
            }
            return irishCoffees;
        }
    }
}
