using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C099999
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside c = new Countryside();
            c.run();
        }
    }

    class Village
    {
        public bool isAstrilde;
        public Village nextVillage;
        public Village prevVillage;
        public string villageName;
    }
    class Countryside
    {
        Village Toronto, Maple, Ajax;

        public void run()
        {
            Maple = new Village();
            Maple.villageName = "Toronto";
            Maple.nextVillage = Toronto;

        }
    }
}
