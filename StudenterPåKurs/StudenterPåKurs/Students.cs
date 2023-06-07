using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenterPåKurs
{
    public class Students
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Students(string name, int age, string course)
        {
            Name = name;
            Age = age;
            Course = course;
        }
        public Students()
        {
            
        }
    }
}
