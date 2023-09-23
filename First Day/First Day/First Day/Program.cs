using System;

namespace FirstDay
{
    class progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //C# variables
            int Interger = 2;
            Console.WriteLine("This is Integer " + Interger);
            double doubleVar = 19.99;
            Console.WriteLine("This is Double " + doubleVar);
            char charVar = 'a';
            Console.WriteLine("This is Char "  + charVar);
            string stringVar = "My Name is Hammad Abbas";
            Console.WriteLine("This is String " + stringVar);
            const int myConstInteger = 12;
            Console.WriteLine("This is Const " + myConstInteger);
            string FirstName = "Hammad";
            string LastName = "Abbas";
            Console.WriteLine("Your Name is " + FirstName + " "+ LastName);
            int x = 2, y = 3, z = 5;
            Console.WriteLine("This is MultiVar {0} , {1} , {2}" , x , y , z);
        }
    }
}