using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Person
    {
        public string? name;
        public string? city;
        public string Sayhello()
        {
            return "Hello! My name is " + name +" From the " + city +"!" ; 
        }
    }
}
