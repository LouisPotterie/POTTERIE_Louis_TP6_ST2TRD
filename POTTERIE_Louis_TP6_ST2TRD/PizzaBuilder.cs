namespace POTTERIE_Louis_TP6_ST2TRD
{
    public abstract class PizzaBuilder
    {
        private Pizza pizza;  
  
        public Pizza GetPizza()  
        {  
            return pizza;  
        }  
  
        public void CreateNewPizza()  
        {  
            pizza = new Pizza();  
        }  
        
        public abstract void ApplyVegetables();  
        public abstract void ApplyCheese();  
        public abstract void ApplyMeat();  
      
    }
}