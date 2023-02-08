using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_creating_class
{
    public class Relation
    {
        public string Relationtype { get; set; }
        public void showRelationShip(Person P1,Person P2)
        {
            Console.WriteLine(P1.firstName + " and " + P2.firstName + " are " +" "+ Relationtype);
        }
    }
}
