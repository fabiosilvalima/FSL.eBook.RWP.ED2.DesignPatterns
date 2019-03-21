namespace FSL.eBook.RWP.ED2.DesignPatterns.DecoratorChapter
{
    public sealed class TomatoDecorator : 
        PizzaDecorator
    {
        public TomatoDecorator(
            Pizza pizza) : 
            base(pizza)
        {
            Description = "Tomato";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 0.25;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }
    }
}