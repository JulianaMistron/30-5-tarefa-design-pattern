using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_5_tarefa_design_pattern
{
    public class PrecoVisitor : IVisitor//herda a interface visitor
    {
        private const int carroDesconto = 30;

        public void Accept(Carro carro)//aceita tipo do objeto e objeto
        {
            int precoCarroAposDesconto = carro.Preco - ((carro.Preco / 100) * carroDesconto);

            Console.WriteLine($"{carro.Modelo} {carro.Nome}: R$ {precoCarroAposDesconto}");
        }
    }
}
