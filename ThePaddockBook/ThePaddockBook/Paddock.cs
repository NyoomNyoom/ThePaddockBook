using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaddockBook
{
    public class Paddock
    {
        private readonly string name;
        private readonly float[] position;

        Paddock(String nameIn, float[] positionIn)
        {
            this.name = nameIn;
            this.position = positionIn;
        }
    }
}
