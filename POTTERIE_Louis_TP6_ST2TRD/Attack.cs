using System;

namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class Attack : PointStrategy
    {
       
        public override void decisionMaking(string playerName)
        {
            Console.WriteLine("Player " + playerName + " doing a forehand topspin");
        }
    }
}