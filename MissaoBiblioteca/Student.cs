namespace MissaoBiblioteca
{
    public class Student : BusinessRole
    {
        public Student(string name, string studentCpf) : base(name, studentCpf) { }

        List<string> list = new List<string>();
        public override void RegisterRole()
        {
            list.Add(this.Name);
            list.Add(this.Role_ID);
        }
        public override void ListRoles()
        {
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
        }
    }
}