using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            
            Produto p = new Produto("TV", 500.00, 10);//estanciando a classe = criano um objeto

            p.Nome = "T";// este nome não será aceito por conta da definição do if em Nome na classe

            Console.WriteLine(p.Nome);//imprime o Nome
            Console.WriteLine(p.Preco);//imprime o valor do Preco
            Console.WriteLine(p.Quantidade);//imprime a Quantidade

        }
    }
}
