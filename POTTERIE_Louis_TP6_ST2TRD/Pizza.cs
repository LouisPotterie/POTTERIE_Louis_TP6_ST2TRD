namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class Pizza
    {
        public string name { get; set; }
        public string meat { get; set; }
        public string cheese { get; set; }
        public string vegetables { get; set; }
        
        public string ListElement()
        {
            return "Vegetables : " + vegetables + " / Meat : " + meat + " /  Cheese : " + cheese;
        }

    }
}