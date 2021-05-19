namespace ConsoleUI
{
    partial class Program
    {
        public class PersonModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public PersonModel()
            {
            }

            public PersonModel(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }

            public PersonModel(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }
    }
}
