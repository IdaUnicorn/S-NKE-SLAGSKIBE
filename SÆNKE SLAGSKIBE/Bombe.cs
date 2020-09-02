using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SÆNKE_SLAGSKIBE
{
    class Bombe
    {
        /// class variables
        private int size;
        private string name;
        private int location;

        //laver constructors 
        public Bombe (int Size, string Name, int Location)
        {
            size = Size;
            name = Name;
            location = Location;
        }
        public int Size { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
}
