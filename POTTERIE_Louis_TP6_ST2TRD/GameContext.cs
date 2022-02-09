namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class GameContext
    {
        private PointStrategy Strategy;
        
        public GameContext(PointStrategy Strategy)
        {
            this.Strategy = Strategy;
        }
        public void SetStrategy(PointStrategy Strategy)
        {
            this.Strategy = Strategy;
        }
        public void CreatePoint(string playerName)
        {
            Strategy.decisionMaking(playerName);
        }
    }
}