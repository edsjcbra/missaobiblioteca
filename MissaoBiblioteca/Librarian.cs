using System.Xml.Linq;

namespace MissaoBiblioteca
{
    public class Librarian : BusinessRole
    {
        public Librarian(string name, string librarianId) : base(name, librarianId) { }

        List<string> list = new List<string>();
        public override void RegisterRole()
        {
            list.Add(this.Name);
            list.Add(this.Role_ID);
        }
        public override void ListRoles()
        {
            foreach (var librarian in list)
            {
                Console.WriteLine(librarian);
            }
        }
    }
}