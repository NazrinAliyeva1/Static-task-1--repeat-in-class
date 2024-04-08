using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task_1__repeat_in_class.Models
{
    internal class Student
    {
        public static int Count = 0;
        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Count++;
            Id = Count;

        }
        public void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname} {Id}");
        }
       
    }
}
