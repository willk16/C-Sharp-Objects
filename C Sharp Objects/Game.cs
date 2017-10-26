using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);

            try
            {
                //MapLocation mapLocation = new MapLocation(20,20, map);//The third 'map' parameter is the size of the map we created above.

                Path path = new Path(    //The Path constructor takes an array of MapLocations
                    new [] {
                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map),
                        new MapLocation(5,2, map),
                        new MapLocation(6,2, map),
                        new MapLocation(7,2, map)
                        }
                    );

                IInvader[] invaders =
                    {
                    new ShieldedInvader(path),
                    new FastInvader(path),
                    new StrongInvader(path),
                    new BasicInvader(path),
                    new ResurrectingInvader(path)
                    };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1,3, map)),
                    new Tower(new MapLocation(3,3, map)),
                    new Tower(new MapLocation(5,3, map)),
                };

                Level level = new Level(invaders)
                {
                    Towers = towers //Object initialisation
                };

                bool playerWon = level.Play();
                Console.WriteLine("Player " + (playerWon ? "won": "lost"));

                MapLocation location = path.GetLocationAt(0);//The 'GetLocation()' method in the Path class returns a MapLocation. That's why the variable 'location' is of type MapLocation.

            }
            catch (OutOfBoundsException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled Treehouse Defense Exception");
            }
            catch (Exception e)//Here, e will contain the new exception thrown in the 'MapLocation' class. Therefore, the writeline below will print out the string we defined for that exception.
            {

                Console.WriteLine("Unhandled Exception");
            }



            //bool isOnMap = map.onMap(point);
            //Console.WriteLine(isOnMap);

            //point = new Point(8, 5);
            //isOnMap = map.onMap(point);
            //Console.WriteLine(isOnMap);
            Console.ReadLine();
        }
    }
}
