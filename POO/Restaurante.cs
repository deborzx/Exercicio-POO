using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Restaurante
    {
        public string pedido;
        public decimal preco;


        public void PedidoFeito()
        {
            Console.WriteLine($"Seu pedido: {pedido} -- {preco}");
        }

    }
}
