using System;
using Lesson.Classes;
using Lesson.MyClasses;
using Lesson.Classes.SubClasses;
using Task1;
using ClassLibrary;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClasses.Student student1 = new MyClasses.Student();
            Teacher teacher = new Teacher();

            Human human1 = new Human();
            //human1.Name = "Hikmet";


            Employee employee = new Employee("Tofiq");
            //Console.WriteLine(employee.Name);

            Product pr = new Product();
        }
    }
}

