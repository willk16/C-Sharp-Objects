using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        {
        }

        //With this ShieledInvade, the hits on an Invader will only be successful half of the time.
        public override void DecreaseHealth(int factor)
        {
            if (Random.NextDouble() < 0.5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at ShieldedInvader, but he avoided it");
            }
        }
    }
}
