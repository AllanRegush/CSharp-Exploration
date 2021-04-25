using System;

namespace ConsoleUI
{
    public static class ExtensionMethods
    {
        public static void WriteToConsole(this string str)
        {
            Console.WriteLine(str);
        }

        public static Person SetName(this Person person, string name)
        {
            person.Name = name;
            return person;
        }

        public static Person SetDefaultAge(this Person person)
        {
            person.Age = 18;
            return person;
        }

        public static void PrintInfo(this Person person)
        {
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }

    } 
}
