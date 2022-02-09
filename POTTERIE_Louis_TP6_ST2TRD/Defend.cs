using System;

namespace POTTERIE_Louis_TP6_ST2TRD
{
    public class Defend : PointStrategy
    {
        public override void decisionMaking(string playerName)
        {
            Console.WriteLine("Player " + playerName + " doing a chop with heavy backspin");
        }
    }
}