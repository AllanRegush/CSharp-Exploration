using ExtensionMethodsUI.Extensions;
using ExtensionMethodsUI.Models;

var person = new PersonModel();

person.FirstName = "What is your first name?".RequestString();
person.LastName = "What is your last name?".RequestString();

person.Age = "What is your age?".RequestAge(1, 100);



Console.ReadLine();
