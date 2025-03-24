using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaddockBook
{
    class Farm(String nameIn)
    {
        private readonly String farmName = nameIn;
        private readonly List<Location> locations = new();
        private readonly List<User> employees = new();

        public void AddLocation(Location LocoIn)
        {
            locations.Add(LocoIn);
        }

        public void AddEmployee(User employee)
        {
            employees.Add(employee);
        }
    }
}
