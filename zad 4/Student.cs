using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    class Student
    {
        public string Name { get; set; }
        public double AverageMark { get; set; }
        public Student(string name, double averageMark)
        {
            Name = name;
            AverageMark = averageMark;
        }
    }
}
