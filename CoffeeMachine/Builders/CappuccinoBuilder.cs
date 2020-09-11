using CoffeeMachine.Ingredients;
using CoffeeMachine.Products;
using CoffeeMachine.Recipe;
using System;

namespace CoffeeMachine.Builders
{
    public class CappuccinoBuilder : ICappuccinoBuilder
    {
        private Cappuccino _cappuccino = new Cappuccino();

        public ICappuccinoBuilder WitheMilk(Milk milk) 
        {
            _cappuccino.Milk = milk;
            Console.WriteLine("Milk added");
            return this;
        }
        public ICappuccinoBuilder WithCoffee(Coffee coffee) 
        {
            _cappuccino.Coffee = coffee;
            Console.WriteLine("Cofee added");
            return this;
        }
        public ICappuccinoBuilder WithWater(Water water) 
        {
            _cappuccino.Water = water;
            Console.WriteLine("Water added");
            return this;
        }
        public ICappuccinoBuilder WithWhiteSugar(WhiteSugar whiteSugar) 
        {
            _cappuccino.WhiteSugar = whiteSugar;
            Console.WriteLine("White sugar added");
            return this;
        }
        public Cappuccino Make() 
        {
            Console.WriteLine("Cappuccino is made");
            Console.WriteLine("****************************************");
            return _cappuccino;
        }
    }
}
