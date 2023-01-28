namespace MissaoBiblioteca
{
    public abstract class BusinessRole
    {
        public BusinessRole(string? name, string? role_ID)
        {
            Name = name;
            Role_ID = role_ID;
        }

        public string? Name { get; private set; }
        public string? Role_ID { get; private set; }

        public virtual void RegisterRole() { }

        public virtual void ListRoles() { }
    }
}