using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

    public class Filme
    {
        //atributos
        public string nome;
        public string descricao;
        public int ano;
        public string studio;
        public List<string> atores = new List<string>();

        //metodos
        public void Play()
        {
            Console.WriteLine($"Rodando o filme: {nome}");
        }

        public void Pause()
        {
            Console.WriteLine("|pause|");
        }

    }
}
