using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _30_5_tarefa_design_pattern
{
    public class Carro : ILoja
    {
        public string Nome { get; set; }
        public int Preco { get; set; }
        public string Modelo { get; set; }

        public void Visit(IVisitor visitor)
        {
           visitor.Accept(this);
        }

    }
}
