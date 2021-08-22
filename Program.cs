using System;

namespace BasicDataTypes
{
    class Program
    {
        static string profession = "Programmer";
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 08, 19);
            Console.WriteLine(dt);

            dt = DateTime.Today;
            Console.WriteLine(dt);

            dt = DateTime.Now;
            Console.WriteLine(dt);

            Console.WriteLine($"Does {dt} belong to summer time zone? {dt.IsDaylightSavingTime()}");

            TimeSpan ts = new TimeSpan(4, 20, 00);
            Console.WriteLine(ts);

            Console.WriteLine(ts.TotalMinutes);
            Console.WriteLine(ts.TotalSeconds);

            Console.WriteLine($"Global variable in method Main: {profession}");

            Console.WriteLine("Local variables in Main method");
            int age = 27; //Declaration and initialization of the variable
            string name; //Declaration of the variable
            name = "Miłosz"; //Initialization of the variable

            bool b1 = true, b2 = false, b3 = b2; //Declaration and initialization of several variables in one line
            System.Boolean b4 = true; //Usage of data type System.Boolean to declare the value bool

            Console.WriteLine($"Hi {name}, I can see that you are {age} years old.");

            Console.WriteLine("LocalVarDeclarations method  call");
            LocalVarDeclarations(); //Method call
            string greetingText = PrepareGreetingText("Miłosz", 27); //Variable that contains the method call with parameters string name, int age from PrepareGreetingText method below
            Console.WriteLine(greetingText);
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine($"Global variable in method LocalVarDeclarations: {profession}");

            Console.WriteLine("Local variables in LocalVarDeclarations method");
            int age = 30;
            int myInt = 4;
            double myDouble = 2.5;
            char myChar = 'a';
            string myString = "Hello";

            Console.WriteLine($"{myInt} {myDouble} {myChar} {myString} {age}");
        }

        static string PrepareGreetingText(string name, int age)
        {
            return $"Hello {name}, your friend told me you are {age} years old.";
        }
    }
}
