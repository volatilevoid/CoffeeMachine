using CoffeeMachine.Ingredients;
using CoffeeMachine.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Builders
{
    class IrishCoffeeBuilder : IIrishCoffeeBuilder
    {
        private readonly IrishCoffee _irishCoffee = new IrishCoffee();

        public IIrishCoffeeBuilder WithCoffee(Coffee coffee)
        {
            _irishCoffee.Coffee = coffee;
            Console.WriteLine("Coffee added");
            return this;
        }
        public IIrishCoffeeBuilder WithBrownSugar(BrownSugar brownSugar)
        {
            _irishCoffee.BrownSugar = brownSugar;
            Console.WriteLine("Brown sugar added");
            return this;
        }
        public IIrishCoffeeBuilder WithIrishWhiskey(IrishWhiskey irishWhiskey)
        {
            _irishCoffee.IrishWhiskey = irishWhiskey;
            Console.WriteLine("Irish Whiskey added");
            return this;
        }
        public IIrishCoffeeBuilder WithFreshCream(FreshCream freshCream)
        {
            _irishCoffee.FreshCream = freshCream;
            Console.WriteLine("Fresh cream added");
            return this;
        }
        public IrishCoffee Make()
        {
            Console.WriteLine("Irish coffee is made");
            Console.WriteLine("****************************************");
            return _irishCoffee;
        }

    }
}
