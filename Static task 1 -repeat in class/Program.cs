

using Static_task_1__repeat_in_class.Models;

namespace Static_task_1__repeat_in_class
{
    internal class Program
    {
        static void Main(string[] args)
        {



            

            Group group1 = new Group("Kimya");
            Group group2 = new Group("Fizika");
            Group group3 = new Group("Riyaziyyat");


            Student student = new Student("sahil", "sahilli");
            Student student2 = new Student("asil", "asilli");

            Student student3 = new Student("Cahid", "Camalli");
            Student student4 = new Student("Cavid", "Ceferli");

            Student student5 = new Student("Fariz", "Ferrux");

            group1.AddStudent(student);
            group1.AddStudent(student2);

            group2.AddStudent(student3);
            group2.AddStudent(student4);

            group3.AddStudent(student5);



            Console.WriteLine("Group Information:");
            group1.GetGroupInfo(group1);
            student.GetInfo();
            student3.GetInfo();
            student3.GetInfo();

            group2.GetGroupInfo(group2);
            student4.GetInfo();

            group3.GetGroupInfo(group3);
            student5.GetInfo();




            Console.WriteLine($"Total number of students in the group: {group1.GroupId}");


            Console.WriteLine("\nBefore removing group:");
            group1.GetGroupInfo(group1);
            group2.GetGroupInfo(group2);
            group3.GetGroupInfo(group3);

            int groupIdToRemove = group1.GroupId;
            group2.RemoveGroup(groupIdToRemove);

            Console.WriteLine("\nAfter removing group:");





        }
    }
}
