using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    public class Map
    {
        public readonly int Width;//The width and height cannot change after they are created.
        private readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool onMap(Point point)
        {
            bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height; //If all of these condition are true, then 'true' will be stored in our varible.
            return inBounds;
        }
    }
}
