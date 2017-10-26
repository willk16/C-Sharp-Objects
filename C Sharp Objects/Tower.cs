using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{   //This class' goal is to shoot on the invaders.
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = 0.75;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        //Determines if a Tower's shot successfully hits an Invader
        public bool isSuccessfulShot()
        {
            return Random.NextDouble() < Accuracy;//If the random double is under 0.75 then this method returns true. 
        }


        //This method will need access to all invaders on the map. If the invader is in range, then the tower can shoot at it. 
        public void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))//This check if the invader is both active and in range of the tower. The '_range' represents the width of one grid square.
                {
                    if (isSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Shot at and hit invader");
                        if (invader.IsNeutralised)
                        {
                            Console.WriteLine("Invader Neutralised at " + invader.Location);
                        }
                    }else
                    {
                        Console.WriteLine("Missed the invader!");
                    }                 
                    break;
                }
            }
        }
    }
}
