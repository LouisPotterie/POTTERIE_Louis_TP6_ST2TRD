namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class Pizzaiolo
    {
        private PizzaBuilder _builder;
        
        public PizzaBuilder Builder
        {
            set { _builder = value; } 
        }
        
        // The Director can construct several product variations using the same
        // building steps.
        public void BuildMinimalViableProduct()
        {
            this._builder.ApplyVegetables();
        }
        
        public void BuildFullFeaturedProduct()
        {
            this._builder.ApplyVegetables();
            this._builder.ApplyCheese();
            this._builder.ApplyMeat();
        }
    }
}