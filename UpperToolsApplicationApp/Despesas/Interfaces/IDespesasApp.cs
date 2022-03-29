using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperToolsApplication.Interfaces.Generics;
using UpperToolsDomain.Despesas.Entities;

namespace UpperToolsApplication.Interfaces
{
    public interface IDespesasApp : IGenericApp<DespesasEntities>
    {
    }
}
