using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In C#, all exceptions must inherit from System.Exception
namespace C_Sharp_Objects
{
    class TreehouseDefenseException: Exception
    {
        public TreehouseDefenseException()
        {

        }

        public TreehouseDefenseException(string message): base(message)//System.Exception already has a constructor that takes a string paramater so we can pass that in here.
        {

        }
    }

    class OutOfBoundsException: TreehouseDefenseException
    {
        public OutOfBoundsException()//We don't need to type ':base()' because a default parameterless constructor will automatically call the default parameterless constructor of its parent class.
        {

        }

        public OutOfBoundsException(string messge): base(messge)
        {

        }
    }
}
