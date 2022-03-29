using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperToolsDomain.Despesas.Entities;
using UpperToolsDomain.Interfaces.Generics;

namespace UpperToolsDomain.Despesas.Interfaces
{
    public interface IDespesas : IGeneric<DespesasEntities>
    {
    }
}
