using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaddockBook
{
    class Location(String NameIn, float[] positionIn)
    {
        private readonly string name = NameIn;
        private readonly float[] position = positionIn;
        private readonly List<Paddock> paddocks = [];


        public void addPaddock(Paddock paddock)
        {
            paddocks.Add(paddock);
        }
    }
}
