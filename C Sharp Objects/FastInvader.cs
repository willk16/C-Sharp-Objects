using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class FastInvader : Invader
    {

        protected override int StepSize { get; } = 1;

        public override int Health { get; protected set; } = 2;

        public FastInvader(Path path) : base(path)
        {

        }

    }
}
