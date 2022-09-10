using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
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
            produtocel.modelo = "S20 FE";
            produtocel.marca = "SAMSUNG";
            produtocel.Venda();

            Console.WriteLine("---------------------------------------");

            Jogo jogo = new Jogo();
            jogo.nome = "DEAD BY DAYLIGHT";
            jogo.Game();

            Console.WriteLine("---------------------------------------");

            Restaurante restaurante = new Restaurante();
            restaurante.pedido = "Lasanha";
            restaurante.preco = 19.00m;
            restaurante.PedidoFeito();

            Console.WriteLine("---------------------------------------");

            RPG rpg = new RPG();
            rpg.personagem = "LEON";
            rpg.familia = "FOGO";
            rpg.Amostragem();


            Console.ReadLine();


        }
    }
}
