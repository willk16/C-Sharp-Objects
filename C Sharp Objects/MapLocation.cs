using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    public class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y) //Because a Point object will also be created when this instance is, we need to pass Point its required paramters. 
        {
            if (!map.onMap(this))
            {
                throw new OutOfBoundsException(this + " is outside the boundries of the map.");//'this' is calling the ToString() method declared in the parent Point class
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
