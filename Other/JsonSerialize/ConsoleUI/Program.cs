using System.IO;
using System.Text.Json;

namespace ConsoleUI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ideaList = new List<IdeaModel>();
            ideaList.Add(new IdeaModel(1, "Make this App"));
            ideaList.Add(new IdeaModel(2, "Make a great App"));

            var json = JsonSerializer.Serialize(ideaList);
            Console.WriteLine(json);
            const string jsonFileName = "idealist.json";
            Console.WriteLine("Writing to File");
            File.WriteAllText(jsonFileName, json);

            string jsonRead = File.ReadAllText(jsonFileName);
            var ideaListFromJson = JsonSerializer.Deserialize<List<IdeaModel>>(jsonRead);
            if (ideaListFromJson is not null)
            {
                foreach (var idea in ideaListFromJson)
                {
                    Console.WriteLine($"Id: {idea.Id}, Name: {idea.Name}");
                }
            }
            Console.ReadLine();
        }
    }
}
