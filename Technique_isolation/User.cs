namespace Technique_isolation
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }

        public User(int id, string name, int age, string password)
        {
            Id = id;
            Name = name;
            Age = age;
            Password = password;
        }
    }
}