using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class ProdutoCel
    {
        public string modelo;
        public string marca;
        public decimal preco;

        public void Venda()
        {
            Console.WriteLine($"Parabéns pela sua compra do {modelo} - {marca}");
        }

    }
}
