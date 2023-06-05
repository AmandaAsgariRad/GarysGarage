using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The Midnight Blue Zero zips by you. Yeeeeeeoooowwww!");
            Console.WriteLine("The Black Zero zips by you. Yeeeeeoooooowwwww!");
        }



    }
}