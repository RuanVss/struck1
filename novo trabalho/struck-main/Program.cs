using System;
using Struct;

namespace TAD{
    class Program
    {
      static void Main(string[] args)
      {
        //struct
        ClienteS cliente1 = new();

        cliente1.nome = "luke";
        cliente1.cpf = "123.456.678.89";
        cliente1.dataNasc = "01/01/2001";
        cliente1.email = "luke@gmail.com";

        System.Console.WriteLine(cliente1.imprimir());
      }
    }
    }
