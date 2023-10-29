using System.Data.Common;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using MongoDB.Driver;

namespace MongoDBUI;

public class Program
{
    private static MongoDBDataAccess? _db;
    private static readonly string tableName = "Contacts";
    public static void Main(string[] args)
    {
        _db = new MongoDBDataAccess("MongoDBPeople", Env.GetConnectionString());
        PersonModel person = new PersonModel
        {
            FirstName = "Bob",
            LastName = "Frank"
        };
        person.Employers.Add(new EmployerModel { EmployerName = "Frank's Building and Loan"});
        person.Addresses.Add(new AddressModel { Street = "123 Fake St."});
        //CreateContact(person);
        //DeleteContact(new Guid());
        GetAllPeople();
        UpdatePersonLastName("d24763d2-8127-407d-95cb-e702b4a158fb", "Bobby");
        Console.WriteLine("Done Processing");
    }

    public static void CreateContact(PersonModel person)
    {
        _db!.UpsertRecord(tableName, person.Id, person);
    }

    public static void GetAllPeople()
    {
        var contacts = _db!.LoadRecords<PersonModel>(tableName);

        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id}: {contact.FirstName} {contact.LastName}");
        }
    }

    public static void UpdatePersonLastName(string id, string LastName)
    {
        Guid guid = new Guid(id);
        var person = _db!.LoadRecordById<PersonModel>(tableName, guid);
        person.LastName = LastName;

        _db.UpsertRecord<PersonModel>(tableName, guid, person);
    }

    public static void DeleteContact(Guid id)
    {
        _db!.DeleteRecord<PersonModel>(tableName, id);
    }
}