using System;

namespace Git_Aula107
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Código: ");
            int Codigo = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("CPF: ");
            string cpf = Console.ReadLine();

            Cliente c;
            c = new Cliente(Codigo,nome,cpf);

            Console.WriteLine();

            Console.WriteLine(c.ToString());

            Console.WriteLine("Obrigado");
        }
    }
}
