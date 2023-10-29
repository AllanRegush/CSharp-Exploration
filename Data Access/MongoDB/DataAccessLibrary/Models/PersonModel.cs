using MongoDB.Bson.Serialization.Attributes;

namespace DataAccessLibrary.Models;

public class PersonModel
{
    [BsonId]
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public List<EmployerModel> Employers { get; set; } = new List<EmployerModel>();
    public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();

}