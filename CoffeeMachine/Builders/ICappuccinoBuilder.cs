using CoffeeMachine.Ingredients;
using CoffeeMachine.Products;

namespace CoffeeMachine.Recipe
{
    public interface ICappuccinoBuilder
    {
        ICappuccinoBuilder WitheMilk(Milk milk);
        ICappuccinoBuilder WithCoffee(Coffee coffee);
        ICappuccinoBuilder WithWater(Water water);
        ICappuccinoBuilder WithWhiteSugar(WhiteSugar whiteSugar);
        Cappuccino Make();
    }
}
