using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_creating_class
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Person Ian= new Person { personId=1,firstName="Ian",lastName="Brooks",favoriteColor="red",age=30,isworking=true};
            Person Gina= new Person { personId=2,firstName="Gina",lastName="James",favoriteColor= "green",age=18, isworking = false };
            Person Mike = new Person { personId = 3, firstName = "Mike", lastName = "Briscoe", favoriteColor = "blue", age = 45, isworking = true };
            Person Mary = new Person { personId = 4, firstName = "Mary", lastName = "Beals", favoriteColor = "Yellow", age = 28, isworking = true };
            Console.WriteLine("PersonId: "+Gina.personId+" FirstName: "+Gina.firstName+" LastName: "+Gina.lastName+" ,Gina James's Favourite color is " + Gina.favoriteColor);
            Console.WriteLine("PersonId: " + Mike.personId + "\nFirstName: " + Mike.firstName+"\nLastName: "+Mike.lastName+"\nFavouriteColour: "+Mike.favoriteColor+"\nAge:"+Mike.age+"\nisWorking:"+Mike.isworking);
            Ian.ChangeFavoriteColor();
            Console.WriteLine(Ian.ToString());
            Console.WriteLine("Mary's Age after 10 years:"+Mary.GetAgeInTenYears());
            Relation p1= new Relation { Relationtype="Sisters"};
            p1.showRelationShip(Gina, Mary);
            Relation p2 = new Relation { Relationtype = "Brothers" };
            p2.showRelationShip(Ian, Mike);
            List<Person> list1 = new List<Person> { Ian, Gina, Mike, Mary };
            var av=list1.Average(per => per.age);
            Console.WriteLine("Average age is:" + list1.Average(per => per.age));
            var youngest = list1.OrderBy(per => per.age).First();
            Console.WriteLine("The youngest person is:"+youngest.firstName);
            var oldest = list1.OrderByDescending(per => per.age).First();
            Console.WriteLine("The oldest person is:" + oldest.firstName);
            foreach(var p in list1.Where(per=>per.firstName.StartsWith("M")))
            {
                Console.WriteLine(p.ToString());
            }
            foreach(var pe in list1.Where(per=>per.favoriteColor==("blue")))
            {
                Console.WriteLine(pe.ToString());
            }
            Console.ReadKey();
        }
    }
}
