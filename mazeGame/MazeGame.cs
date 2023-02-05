using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeGame
{
    class MazeGame
    {
        public Maze CreateGame()
        {
            Maze aMaze = new Maze();
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Door theDoor = new Door(r1,r2);

            aMaze.AddRoom(r1);
            aMaze.AddRoom(r2);

            r1.SetSite(Direction.North, new Wall());
            r1.SetSite(Direction.East, theDoor);
            r1.SetSite(Direction.South, new Wall());
            r1.SetSite(Direction.West, new Wall());

            r2.SetSite(Direction.North, new Wall());
            r2.SetSite(Direction.East, new Wall());
            r2.SetSite(Direction.South, new Wall());
            r2.SetSite(Direction.West, theDoor);

            return aMaze;
        }

        public void start()
        {
            Maze aMaze = CreateGame();
            Room current = aMaze.RoomNo(1);

            while (true)
            {
                var Ch = Console.ReadKey(false).Key;

                Direction direct;
                switch (Ch)
                {
                    case ConsoleKey.UpArrow: Console.Write("^ "); direct = Direction.North; break;
                    case ConsoleKey.DownArrow: Console.Write("v "); direct = Direction.South; break;
                    case ConsoleKey.LeftArrow: Console.Write("< "); direct = Direction.West; break;
                    case ConsoleKey.RightArrow: Console.Write("> "); direct = Direction.East; break;
                    default: return;
                }

                MapSite side = current.GetSite(direct);
                if (side is Door)
                {
                    current = ((Door)side).OtherSideFrom(current);
                    current.Enter();
                }
                else
                {
                    side.Enter();
                }
            }
        }
    }
}
