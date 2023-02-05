using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeFactoryGame
{
    class MazeGame
    {
        MazeFactory factory = null;

        public Maze CreateMaze(MazeFactory factory)
        {
            this.factory = factory;
            Maze aMaze = this.factory.MakeMaze();
            Room r1 = this.factory.MakeRoom(1);
            Room r2 = this factory.MakeRoom(2);
            Door aDoor = this.factory.MakeDoor(r1, r2);

            aMaze.AddDoor(r1);
            aMaze.AddDoor(r2);
        }
    }
}
