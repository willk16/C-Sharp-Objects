using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{   //This class represents a coordinate on the map
    public class Point
    {
        public readonly int X;//The width and height cannot change after they are created.
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;//This line unclear. Teacher did it in the video 'Object.Equals'

            return this.X == that.X && this.Y == that.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode(); 
        }

        public int DistanceTo( int x, int y)
        {
            int xDiff = X - x; //Here, we are subtracting the x value passed in to this method from the X value passed into the constructor of the object the method is being called on
            int yDiff = Y - y;

            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            //This line does the exact same as the line above but in just one line
            //return (int)Math.Sqrt(Math.Pow(X-x, 2)+ Math.Pow(Y-y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
