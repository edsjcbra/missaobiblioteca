using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissaoBiblioteca
{
    public class Lib_App
    {
        public void InitialMenu()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("BEM VINDO A BIBLIOTECA DO EVERTAO");
            Console.WriteLine("**********************************\n");
            Console.WriteLine("O que deseja fazer:\n");
            Console.WriteLine("1. Cadastrar novo Aluno");
            Console.WriteLine("2. Cadastrar novo Bibliotecario");
            Console.WriteLine("3. Sair\n");

            Console.Write("Digite a opcao desejada: ");
            int option = int.Parse(Console.ReadLine());


            if (option == 1)
            {
                string answer = "N";
                do
                {
                    Console.Write("Digite o nome do Aluno que deseja cadastrar: ");
                    string studentName = Console.ReadLine();
                    Console.Write("Digite o cpf do Aluno que deseja cadastrar: ");
                    string studentCpf = Console.ReadLine();
                    Student student = new Student(studentName, studentCpf);

                    student.RegisterRole();
                    Console.WriteLine("Lista de Alunos cadastrados\n");
                    student.ListRoles();

                    Console.Write("Deseja cadastrar outro Aluno ? S / N = ");
                    answer = Console.ReadLine().ToUpper();

                } while (answer == "S");
            }
            else if (option == 2)
            {
                string answer = "N";
                do
                {
                    Console.Write("Digite o nome do Bibliotecario que deseja cadastrar: ");
                    string librarianName = Console.ReadLine();
                    Console.Write("Digite o ID do Bibliotecario que deseja cadastrar: ");
                    string librarianId = Console.ReadLine();
                    Librarian librarian = new Librarian(librarianName, librarianId);

                    librarian.RegisterRole();
                    Console.WriteLine("Lista de Bibliotecarios cadastrados\n");
                    librarian.ListRoles();

                    Console.Write("Deseja cadastrar outro Bibliotecario ? S / N = ");
                    answer = Console.ReadLine().ToUpper();

                } while (answer == "S");
            }
            else
            {
                Console.WriteLine("OBRIGADO POR VISITAR A BIBLIOTECA DO EVERTAO");
                Environment.Exit(0);
            }
        }
    }
}