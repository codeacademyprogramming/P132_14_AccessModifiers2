using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserName = "samirova";
            user.Password = "Salam123";
            Console.WriteLine(user.Password);

            Human human = new Human();
            //human.Name = "fdfd";
        }
    }
}
