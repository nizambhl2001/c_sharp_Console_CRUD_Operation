using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherInfo
{
    internal class Program
    {
        private static readonly int age;

        static void Main(string[] args)
        {
            TeacherDetais teacherDetais = new TeacherDetais(new TeacherRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Teacher> _ListTeacher = teacherDetais.Get();
                        Console.WriteLine("\t \t \t \b List of Teachers Information:");
                        Console.WriteLine("================================================================================");
                       
                        foreach (Teacher _teacher in _ListTeacher)
                        {
                            Console.WriteLine($"TeacherId : {_teacher.TeacherId} \t TeacherName :{_teacher.TeacherName} \t Age : {_teacher.Age} \t City : {_teacher.City}");
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a Teacher:");
                        string id = Console.ReadLine();
                        Teacher aTeacher = teacherDetais.Get(Convert.ToInt32(id));
                        Console.WriteLine($"TeacherId : {aTeacher.TeacherId} \t TeacherName :{aTeacher.TeacherName} \t Age : {aTeacher.Age} \t City : {aTeacher.City}");
                        
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a Teacher id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a  Teacher name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a age:");
                        string age = Console.ReadLine();
                        Console.WriteLine("Input a Home Distric:");
                        string city = Console.ReadLine();
                        Teacher aTeacher = new Teacher();
                        aTeacher.TeacherId = Convert.ToInt32(id);
                        aTeacher.TeacherName = name;
                        aTeacher.Age = Convert.ToInt32(id);
                        aTeacher.City = city;
                        bool isExecuted = teacherDetais.Add(aTeacher);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a Teacher id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a Teacher name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a Home Distric:");
                        string address = Console.ReadLine();
                        Teacher aTeacher = new Teacher();
                        aTeacher.TeacherId = Convert.ToInt32(id);
                        aTeacher.TeacherName = name;
                        aTeacher.City = address;
                        bool isExecuted = teacherDetais.Update(aTeacher);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a Teacher id:");
                        string id = Console.ReadLine();
                        bool isExecuted = teacherDetais.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
