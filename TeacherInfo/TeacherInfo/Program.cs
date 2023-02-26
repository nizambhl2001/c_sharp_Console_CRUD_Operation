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
                        Console.WriteLine("List of Teacher:");
                        Console.WriteLine("ID   |   Name    | Age   |   City");
                        foreach (Teacher _teacher in _ListTeacher)
                        {
                            Console.WriteLine(_teacher.Id + "  |   " + _teacher.Name + "    |   " + _teacher.Age + "  |   " + _teacher.City);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a id to find a customer:");
                        string id = Console.ReadLine();
                        Teacher aTeacher = teacherDetais.Get(Convert.ToInt32(id));
                        Console.WriteLine(aTeacher.Id + ". " + aTeacher.Name + " -- " + aTeacher.Age + " --" + aTeacher.City);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a age:");
                        string age = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string city = Console.ReadLine();
                        Teacher aTeacher = new Teacher();
                        aTeacher.Id = Convert.ToInt32(id);
                        aTeacher.Name = name;
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
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Teacher aTeacher = new Teacher();
                        aTeacher.Id = Convert.ToInt32(id);
                        aTeacher.Name = name;
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
                        Console.WriteLine("Input a id:");
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
