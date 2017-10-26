using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMovable
    {
        //This method tells the Invader to move down the path
        void Move();
    }

    interface IInvader: IMappable, IMovable
    {
        int Health { get; } 

        bool HasScored { get;}

        bool IsNeutralised { get; }

        bool IsActive { get; }

        void DecreaseHealth(int factor);
        
    }
}
