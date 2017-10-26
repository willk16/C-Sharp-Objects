using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    public abstract class Invader : IInvader //Implements the IInvader interface
    {
        private readonly Path _path;   
        private int _pathStep = 0; //Keeps track of how far down the track the Invader is

        protected virtual int StepSize { get; } = 1;

        public abstract int Health { get; protected set; } //The private setter indicates that we should use the DecreaseHealth() method below if we want to change the value of this Health property. 

        //True if the Invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralised { get { return Health <= 0; } }

        public bool IsActive => !(IsNeutralised || HasScored);

        //A Computed Property
        public MapLocation Location
        {
            get
            {   //Location property is updated everytime the '_pathStep changes'.
                return _path.GetLocationAt(_pathStep);//Updating the 'Location' property to the Invader's new location (because the Move() method made him move a step)
            }
                
        }


        //This ensures that all invaders will start on the first location/step of the path
        public Invader(Path path)
        {
            _path = path;
            //Location = _path.GetLocationAt(0);// The first location in the path array is assigned to 'Location'
        }

       
        //This method tells the Invader to move down the path
        public void Move() => _pathStep += StepSize;//We can write our method like this because it only has one line in it. This is just syntactic sugar. Here, we ar just replacing the curly braces with '=>'
       
        //This method is overridden in its child classes
        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
        }
    }
}
