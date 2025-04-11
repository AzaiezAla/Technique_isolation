namespace Technique_isolation
{
    public interface IAuthentification
    {
        public User User { get; }

        public bool Isauthentified();
        public void login();
    }
}