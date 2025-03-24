using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePaddockBook
{
    class User(String nameIn, String emailIn, String phoneIn)
    {
        private readonly String Name = nameIn;
        private String Level = "";
        private readonly String Email = emailIn;
        private readonly String Phone = phoneIn;
        private readonly List<String> Qualifications = new(); 

        public void SetLevel(String levelIn)
        {
            Level = levelIn;
        }
    }
}
