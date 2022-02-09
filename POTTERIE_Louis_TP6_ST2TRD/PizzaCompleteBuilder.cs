namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class PizzaCompleteBuilder : PizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        
        public override void ApplyVegetables()
        {
            this._pizza.vegetables = "Tomato";
        }

        public override void ApplyCheese()
        {
            this._pizza.cheese = "Cheddar";
        }

        public override void ApplyMeat()
        {
            this._pizza.meat = "Chicken";
        }
        
        public void Reset()
        {
            this._pizza = new Pizza();
        }
        
        public Pizza GetProduct()
        {
            Pizza result = this._pizza;

            this.Reset();

            return result;
        }
    }
}