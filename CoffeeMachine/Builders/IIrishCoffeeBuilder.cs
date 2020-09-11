using CoffeeMachine.Ingredients;
using CoffeeMachine.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Builders
{
    public interface IIrishCoffeeBuilder
    {
        public IIrishCoffeeBuilder WithCoffee(Coffee coffee);
        public IIrishCoffeeBuilder WithBrownSugar(BrownSugar brownSugar);
        public IIrishCoffeeBuilder WithIrishWhiskey(IrishWhiskey irishWhiskey);
        public IIrishCoffeeBuilder WithFreshCream(FreshCream freshCream);
        public IrishCoffee Make();
    }
}
