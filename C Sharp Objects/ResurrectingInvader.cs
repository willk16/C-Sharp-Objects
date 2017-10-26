using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class ResurrectingInvader: IInvader
    {
        private BasicInvader _incarnation1;
        private StrongInvader _incarnation2;

        public ResurrectingInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new StrongInvader(path);
        }

        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;
        

        public int Health => _incarnation1.IsNeutralised ? _incarnation2.Health : _incarnation1.Health;


        public bool IsActive => !(IsNeutralised || HasScored);

        public bool IsNeutralised => _incarnation1.IsNeutralised && _incarnation2.IsNeutralised;

        //The Location will be the location of the second incarnation if the first incarnation has been neutralised, otherwise it will be the location of the first incarnation.
        public MapLocation Location => _incarnation1.IsNeutralised ? _incarnation2.Location : _incarnation1.Location;
      

        public void DecreaseHealth(int factor)
        {
            if (!_incarnation1.IsNeutralised)
            {
                _incarnation1.DecreaseHealth(factor);
            }
            else
            {
                _incarnation2.DecreaseHealth(factor);
            }
        }

        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }
    }
}
