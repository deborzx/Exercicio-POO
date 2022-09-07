using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criação de var
            Filme filme = new Filme();
            //acessar os campos do filme
            filme.nome = "Procurando Nemo";
            filme.Play();


            Filme filme2 = new Filme();
            filme2.nome = "Procurando Dory";
            filme2.Play();

            Console.WriteLine("---------------------------------------");

            ProdutoCel produtocel = new ProdutoCel();
            produtocel.modelo = "S20 Fe";
            produtocel.marca = "SAMSUNG";
            produtocel.Venda();

            Console.WriteLine("---------------------------------------");

            Jogo jogo = new Jogo();
            jogo.nome = "DEAD BY DAYLIGHT";
            jogo.Game();




            Console.ReadLine();


        }
    }
}
