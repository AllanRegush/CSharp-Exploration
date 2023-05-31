// See https://aka.ms/new-console-template for more information
using DataAccessLibrary;
using DataAccessLibrary.Models;
using SQLServerUI;

Console.WriteLine("Hello, World!");
var sqlCrud = new SqlCrud(Env.GetConnectionString());

Data.ReadAllContacts(sqlCrud);
Console.ReadLine();