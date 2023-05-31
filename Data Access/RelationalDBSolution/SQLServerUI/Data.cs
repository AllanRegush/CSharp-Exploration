using DataAccessLibrary;
using DataAccessLibrary.Models;

namespace SQLServerUI;

public static class Data
{
    public static void ReadAllContacts(SqlCrud sql)
    {
        var rows = sql.GetAllContacts();

        foreach(var row in rows)
        {
            Console.WriteLine($"{row.Id} {row.FirstName} {row.LastName}");
        }
    }
}