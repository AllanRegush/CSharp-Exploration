using System.Linq;
using DataAccessLibrary.Models;

namespace DataAccessLibrary;

public class SqlCrud
{
    private readonly string _connectionString;
    private SqlDataAccess db = new SqlDataAccess();

    public SqlCrud(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<BasicContactModel> GetAllContacts()
    {
        string sql = "select FirstName, LastName from dbo.Contacts";
        var output = db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        return output;
    }

    public FullContactModel? GetFullContactById(int id)
    {
        string sql = "select Id, FirstName, LastName from dbo.Contacts where Id = @Id";
        FullContactModel output = new();

        output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault();

        if (output.BasicInfo is null)
        {
            return null;
        }

        sql = @"select e.*
                from dbo.EmailAddresses e
                inner
                join dbo.ContactEmail ce on ce.EmailAddressId = e.Id
                where ce.ContactId = @Id";

        output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

        sql = @"select p.*
                from dbo.PhoneNumbers p
                inner
                join dbo.ContactPhoneNumbers cp on cp.PhoneNumberId = p.Id
                where cp.ContactId = @Id";

        output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

        return output;
    }
}