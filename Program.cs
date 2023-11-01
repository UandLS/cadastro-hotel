using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;

namespace Exercício_vetor_hotel
{

    public static class Program
    {
        public static void Main()
        {
            int fn;
            do
            {

                Console.WriteLine("Bem vindo(a) ao hotel 3 estrelas");
                Cliente[] v = new Cliente[10];
                Console.WriteLine();

                Console.Write("Digite quantos quartos serao alugados: ");
                int palugar = int.Parse(Console.ReadLine());
                for (int i = 1; i <= palugar; i++)
                {
                    Console.WriteLine();

                    Console.Write("Nome do cliente: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine();

                    MailAddress EMAIL = null;
                    string email;

                    Console.Write("Email do cliente: ");
                    email = Console.ReadLine();

                    while (EMAIL == null)
                    {
                        try
                        {

                            if (!string.IsNullOrEmpty(email))
                            {
                                EMAIL = new MailAddress(email);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Email invalido, porfavor, inserir um email valido: ");
                            email = Console.ReadLine();

                        }
                    }
                    Console.WriteLine();

                    Console.Write("Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    while (idade < 18)
                    {

                        Console.WriteLine("Reserva não permitida\nCliente menor de idade: ");
                        idade = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine();

                    Console.Write("Número do quarto: ");
                    int quarto = int.Parse(Console.ReadLine());
                    if (quarto != null)
                        v[quarto] = new Cliente(nome, email, idade);

                    Console.WriteLine();
                    Console.WriteLine("cadastro Realizado");

                }


                Console.WriteLine();


                for (int i = 0; i < 3; i++)
                {
                    if (v[i] != null)
                    {
                        Console.WriteLine("Quarto " + i + " " + v[i]);
                    }
                }
                Console.WriteLine();


                Console.WriteLine("Digite 1 para continuar ou 2 para terminar: ");
                fn = int.Parse(Console.ReadLine());


                if (fn != 1 || fn != 2) ;


            }
            while (fn == 1);



            Console.WriteLine();
            Console.WriteLine("Programa finalizado!");



        }
    }
}