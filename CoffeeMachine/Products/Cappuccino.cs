using CoffeeMachine.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeMachine.Products
{
    public class Cappuccino
    {
        public Water Water { get; set; }
        public Coffee Coffee { get; set; }
        public WhiteSugar WhiteSugar { get; set; }
        public Milk Milk { get; set; }
    }
}
