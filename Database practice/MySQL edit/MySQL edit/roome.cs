using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL_edit
{
    class Roome
    {
        public string Name { get; set; }
        public string Room { get; set; }
        public string Chore { get; set; }

        public Roome(string name, string room, string chore)
        {
            Name = name;
            Room = room;
            Chore = chore;
        }
    }

}
