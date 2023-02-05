using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Door : MapSide
    {
        Room room1 = null;
        Room room2 = null;
        bool isOpen;

        public Door(Room r1, Room r2)
        {
            this.room1 = r1;
            this.room2 = r2;
        }

        public override void Enter()
        {
            Console.WriteLine("Door");
        }

        public Room OtherSideFrom(Room room)
        {
            if (room == room1)
                return room2;
            else
                return room1;
        }
    }
}
