using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list_trong_c_
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //tạo 1 constructor có tham số để tiện cho việc khởi tạo nhanh đối tượng person với các giá trị cho sẵn.
        public Person(string Name, int Age) 
        {
            this.Name = Name;
            this.Age = Age;
        }

        //Override phương thức ToString để khi cần có thể in thông tin của opject ra cho nhanh.

        public override string ToString()
        {
            return "Name: " + name + " | Age:" + age;
        }
    }
}
