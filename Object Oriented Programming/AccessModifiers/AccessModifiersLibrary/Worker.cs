namespace AccessModifiersLibrary
{
    public class Worker : Person
    {
        public string GetMiddleName()
        {
            return _middleName;
        }

        public int AskAgeOfBoss()
        {
            var boss = new Boss();
            return boss.getAge();
        }
    }
}
