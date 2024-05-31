using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_5_tarefa_design_pattern
{
    public interface IVisitor//define métodos de visita para cada element- classe
    {
        void Accept(Carro carro);
    }
}
