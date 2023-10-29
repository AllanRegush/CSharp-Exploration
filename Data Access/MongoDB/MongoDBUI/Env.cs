using Microsoft.Extensions.Configuration;

namespace MongoDBUI;

public static class Env
{
    public static string GetConnectionString(string connectionStringName = "Default")
    {
        string output = "";

        var builder = new ConfigurationBuilder().
            SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.Development.json");

        var config = builder.Build();

        output = config.GetConnectionString(connectionStringName) ?? "";

        return output;
    }
}