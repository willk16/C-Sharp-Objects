using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class Level
    {
        private readonly IInvader[] _invaders;
        public Tower[] Towers { get; set; }

        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        //Returns: true if the player wins, false otherwise
        public bool Play()
        {
            //Run until all invaders are neutralised or invader reaches the end of the path. 
            int remainingInvaders = _invaders.Length;

            //While there are remaining Invaders, each of the Towers will fire on the Invaders.
            while (remainingInvaders > 0) {
                //Each Tower has the opportunity to fire on Invaders.
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //COunt and move Invaders that are still active.
                remainingInvaders = 0; //Resetting invaders to 0

                foreach (IInvader invader in _invaders)//Looping through the Invaders that are still active and if we find one we increment the 'remainingInvaders'
                {
                    if (invader.IsActive)
                    {
                        invader.Move();//Move the Invader down the path
                        if (invader.HasScored)//Check if invader has reached the end of the path
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }
                }
            }

            return true;
        }
    }
}
