using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_creating_class
{
    public class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColor;
        public int age;
        public bool isworking;

        public void DisplayPersonInfo()
        {
            Console.WriteLine("Name:" +firstName+" "+lastName+"pearson id:"+personId+"favorite Color:"+favoriteColor);
        }
        public void ChangeFavoriteColor()
        {
            favoriteColor = "white";
        }
        public int GetAgeInTenYears()
        {
            age = age + 10;
            return age;
        }
        public override string ToString()
        {
            return ("Name:"+firstName+" "+lastName+"  person Id:"+personId+"  favorite color:"+favoriteColor+"  age:"+age+"  working:"+isworking);
        }
    }
}