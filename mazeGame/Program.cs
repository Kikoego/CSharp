using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazeGame
{
    class Program
    {
        private static void Main(string[] args)
        {
            MazeGame mazeGame= new MazeGame();
            mazeGame.CreateGame();
            mazeGame.start();
        }
    }
}
