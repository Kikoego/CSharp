using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class MazeGame
    {
        public Maze CreateMaze()
        {
            Maze aMaze = new Maze(); Room r1 = new Room(1);
            Room r2 = new Room(2); Door theDoor = new Door(r1, r2);
            aMaze.AddRoom(r1); aMaze.AddRoom(r2);
            r1.SetSide(Direction.North, new Wall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, new Wall());
            r1.SetSide(Direction.West, new Wall());

            r2.SetSide(Direction.North, new Wall());
            r2.SetSide(Direction.East, new Wall());
            r2.SetSide(Direction.South, new Wall());
            r2.SetSide(Direction.West, theDoor);
            return aMaze;
        }
    }
    /*public Maze CreateGame()
    {
        public Maze aMaze = new Maze();


        this.factory = factory;
        Maze aMaze = this.factory.MakeMaze();
        Room r1 = this.factory.MakeRoom(1);
        Room r2 = this.factory.MakeRoom(2);
        Door aDoor = this.factory.MakeDoor(r1, r2);

        Room r1 = new Room(1);
        Room r2 = new Room(2);
        Room r3 = new Room(3);
        Room r4 = new Room(4);

        Door theDoor = new Door(r1, r2);
        Door theDoor2 = new Door(r2, r3);
        Door theDoor3 = new Door(r3, r4);

        aMaze.AddRoom(r1); 
        aMaze.AddRoom(r2);
        aMaze.AddRoom(r3);

        r1.SetSide(Direction.North, this.factory.MakeWall());
        r1.SetSide(Direction.East, aDoor);
        r1.SetSide(Direction.South, this.factory.MakeWall());
        r1.SetSide(Direction.West, this.factory.MakeWall());

        r2.SetSide(Direction.North, this.factory.MakeWall());
        r2.SetSide(Direction.East, this.factory.MakeWall());
        r2.SetSide(Direction.South, this.factory.MakeWall());
        r2.SetSide(Direction.West, aDoor);
            return aMaze;
    }*/


    /*public void start()
        {
            Maze aMaze = CreateMaze();
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

                MapSide side = current.GetSide(direct);
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
        }*/
    }

