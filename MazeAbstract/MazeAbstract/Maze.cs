using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Maze
    {
        private Dictionary<int, Room> rooms = null;

        public Maze()
        {
            rooms = new();
        }

        public void AddRoom(Room room)
        {
            rooms.Add(room.RoomNumber, room);
        }

        public Room RoomNo(int num)
        {
            return rooms[num];
        }
    }
}
