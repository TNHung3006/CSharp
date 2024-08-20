using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlist_trong_c_
{
    internal class Person
    {
        private string name;
        private int age;
        private int p;
        private int p_2;
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return "Name: " + name + " - Age: " + age;
        }
    }
}
