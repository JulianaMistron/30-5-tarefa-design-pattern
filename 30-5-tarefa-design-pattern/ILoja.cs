using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_5_tarefa_design_pattern
{
    public interface ILoja
    {
        void Visit(IVisitor visitor);
    }
}
