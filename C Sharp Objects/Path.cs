using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{   //This class represents a list of adjacent map locations
    public class Path
    {
        private readonly MapLocation[] _path;

        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null; //If the index is out of range we return null
        }

        //Check to see if a location is on the path
        public bool IsOnPath(MapLocation location)
        {
            foreach (var pathLocation in _path)
            {
                if(location.Equals(pathLocation))//Cycles through the path array and if the location passed in as a paramter matches any of the locations in the array then we return true.
                {
                    return true;
                }
            }
            return false;
        }
    }
}
