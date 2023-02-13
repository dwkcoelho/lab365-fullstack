using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person.Class
{
    public class Person
    {
        public string name;
        public int age;
        public float height;

        public Person() { } 
        public Person(string name) 
        {
            this.name = name; 
        }
        public Person(int age) 
        { 
            this.age = age;
        }
        public Person(float height)
        {
            this.height = height;
        }
        public Person(string name,int age) { 
            this.name = name;
            this.age = age; 
        }
        public Person(string name, float height) 
        { 
            this.name = name;
            this.height = height; 
        }
        public Person(int age, float height) { 
            this.age = age; 
            this.height = height; 
        }
        public Person(string name, int age, float height)  
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }
    }
}
