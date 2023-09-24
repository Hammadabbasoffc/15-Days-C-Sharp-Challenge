using System;
namespace SecondDay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter username : ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Your Age : ");
            int Age =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Hello WelCome " + userName + " Your Age is : " +Age );*/

            Console.WriteLine(Math.Max(3, 5));
            Console.WriteLine(Math.Min(3, 5));
            Console.WriteLine(Math.Sqrt(3));
            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            Console.WriteLine(txt.ToLower());

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            string name1 = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name1);
        }
    }
}