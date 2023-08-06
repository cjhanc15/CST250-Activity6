using System;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tutorial
{
    internal class Student : IComparable<Student>
    {
        public string name { get; set; }
        public int age { get; set; }
        public int grade { get; set; }

        public int CompareTo(Student other)
        {
            // Compare by grade
            int gradeComparison = this.grade.CompareTo(other.grade);
            if (gradeComparison != 0) return gradeComparison;

            // If grades are equal, compare by age
            int ageComparison = this.age.CompareTo(other.age);
            if (ageComparison != 0) return ageComparison;

            // If ages are also equal, compare by name
            return this.name.CompareTo(other.name);
        }
    }
}

