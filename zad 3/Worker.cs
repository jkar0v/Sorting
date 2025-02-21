using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class Worker
    {
        string Name { get; set; }
        public int Salary { get; set; }
        public Worker(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name} - {Salary}";
        }
    }
}
