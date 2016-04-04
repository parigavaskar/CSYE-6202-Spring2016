using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEntity
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            name = name;
        }

    }
}
