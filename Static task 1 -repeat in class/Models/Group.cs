using Static_task_1__repeat_in_class.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_task_1__repeat_in_class.Models
{
    internal class Group
    {
        public static Group[] Groups { get; set; } = new Group[10];
        public static int GroupCount = 0;
        public int GroupId { get; set; } = 1;
        public string GroupName { get; set; }
        Student[] Students { get; set; }

        public Group(string groupname)
        {
            GroupName = groupname;
            Students = new Student[GroupCount];
        }
        public void GetGroupInfo(Group group)
        {
            Console.WriteLine("Qrupun melumatlar:");
            foreach(Student student in Students)
            {
                Console.WriteLine($"{student.Id} {student.Name} {student.Surname}" );
            }
        }
        public Group GetStudent(int id)
        {
            foreach(Group student in Groups)
            {
                if(student != null && GroupId == id)
                {
                    return student;
                }
            }
            return null;
        }
        public static void AddStudent(Group group, Student student)
        {
            bool added = false;
            for (int i=0; i<GroupCount; i++)
            {
                if (group.Students[i] == null)
                {
                    group.Students[i] = student;
                    added = true;
                    Console.WriteLine("Yeni telebe ugurla yerlesdirildi.");
                    break;

                }
            }
            if (!added)
            {
                Console.WriteLine("Qruplar artiq dolub. Gozleyin, yeni qruplarimiz tezlikle acilacaq.");
            }
        }
        public void Search(string searchName, string searchSername)
        {
            foreach(var student in Students)
            {
                if(student !=null && student.Name.Contains(searchName) && student.Surname.Contains(searchSername))
                {
                    Console.WriteLine($"{student.Id} {student.Name} {student.Surname} ");
                    break;
                }
                else
                {
                    Console.WriteLine("Daxil etdiyiniz ad tapilmadi.");
                    break;
                }
            }
        }
        //1 qrupun telebelerinin sayini cixarir.ShowStudents
        public void ShowStudents(Student student)
        {
            foreach (var students in Students)
            {
                Console.WriteLine($"{students}");
                break;

            }
        }
        public override string ToString()
        {
            return $"GroupId: {GroupId}, GroupName: {GroupName}, Count of Students: {Students.Length}";
        }

        public static void AddGroup(Group group)
        {
            bool added = false;
            for(int i=0; i < Groups.Length; i++)
            {
                if (Groups[i] == null)
                {
                    Groups[i] = group;
                    added = true;
                    Console.WriteLine("Yeni qrup ugurla yerlesdirildi.");
                    break; 
                }
            }
            if (!added)
            {
                Console.WriteLine("Qrup hecmi tamdir.  Hal-hazirda elave qrup acila bilmez.");
            }
        }
        public void RemoveGroup(int id)
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i] != null && Groups[i].GroupId == id)
                {
                    Groups[i] = null;
                    Console.WriteLine($"Group with Id {id} removed successully");
                    return;
                }
            }

            Console.WriteLine($"Group with Id {id} not found.");
        }
        public Group GetGroup(int id)
        {
            foreach (var group in Groups)
            {
                if (group != null && GroupId == id)
                {
                    return group;
                }
            }
            return null;
        }

        internal void AddStudent(Student student4)
        {
            
        }
    }
}










