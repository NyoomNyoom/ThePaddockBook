﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaddockBook
{
    class Location
    {
        private readonly string name;
        private readonly float[] position;

        public Location(String NameIn, float[] positionIn)
        {
            this.name = NameIn;
            this.position = positionIn;
        }
    }
}
