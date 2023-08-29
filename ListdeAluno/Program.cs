using System;
using System.Threading.Channels;

class Programa
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        while (true)
        {
            Console.WriteLine("Digite 1 caso queira inserir o nome na lista, caso não queria digite 2");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 1) 
            {
                Aluno a = new Aluno();
                Console.WriteLine("Irforme o nome, matricula, CPF e data de nascimento do aluno");
                a.Nome = Console.ReadLine();
                a.Matricula = Convert.ToInt32(Console.ReadLine());
                a.Cpf = Convert.ToInt32(Console.ReadLine());
                a.Datanasc = DateOnly.Parse(Console.ReadLine());

                alunos.Add(a);


            }
            else if(opcao == 2) 
            {
                break;
            }

          

        }

        Console.Clear(); // limpa o console
        alunos.Sort();    // especificamente para ordenar em ordem alfabetica
       
        foreach (Aluno a in alunos)
        {
            Console.WriteLine("O nome é " + a.Nome + "o cpf é " + a.Cpf);
        }
    }
}
