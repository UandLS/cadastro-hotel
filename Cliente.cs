using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercício_vetor_hotel;

public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Idade { get; set; }

    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public override string ToString()
    {
        return " Nome do cliente: " + Nome + "  Email: " + Email + "  Idade: " + Idade + "  \n";

    }

}