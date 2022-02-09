namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class VegetablesPizzaBuilder : PizzaBuilder
    {
        private Pizza _pizza = new Pizza();
        
        public override void ApplyVegetables()
        {
            this._pizza.vegetables = "Tomato" + " Pepper";
        }

        public override void ApplyCheese()
        {
            this._pizza.cheese = "";
        }

        public override void ApplyMeat()
        {
            this._pizza.meat = "";
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