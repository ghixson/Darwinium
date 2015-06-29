using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Darwinium
{
    class World
    {
        public static World CurrentWorld { get; private set; }

        // World Values
        public int Oxygen;
        public int Nitrogen;
        public int Carbon;
        public int Water;

        public World(int O2, int N, int C, int H2O)
        {
            Oxygen = O2;
            Nitrogen = N;
            Carbon = C;
            Water = H2O;

            World.CurrentWorld = this;
        }
    }
}
