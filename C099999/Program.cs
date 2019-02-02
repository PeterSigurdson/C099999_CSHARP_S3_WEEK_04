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
            c.travel();
           
        }
    }

    class LearningExperiment{
        public void run(){
        Village Toronto;
        Toronto = new Village();
        Village a, b, c ;
        Toronto.villageName = "version A";
        a = Toronto;
        Console.WriteLine(a.villageName);
        Toronto = new Village();
        Toronto.villageName = "version B";
        b = Toronto;
        Console.WriteLine(b.villageName);
        Toronto = new Village();
        Toronto.villageName = "version C";
        c = Toronto;
        Console.WriteLine(c.villageName);
        

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
            Toronto = new Village();
            Ajax = new Village();
            Ajax.isAstrilde = true;
            Maple.villageName = "Toronto";
            Maple.nextVillage = Toronto;

        }
        public void travel()
            {
              Village currentVillage = Toronto;
            while(!currentVillage.isAstrilde){
                if (currentVillage.isAstrilde)
                    Console.WriteLine("You foundn Astrilde in "+ currentVillage);
                else
                    currentVillage= currentVillage.nextVillage;

}
}         
        

    }
}
