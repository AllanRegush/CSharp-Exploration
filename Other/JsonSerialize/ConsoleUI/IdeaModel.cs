namespace ConsoleUI
{
    public class IdeaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IdeaModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
