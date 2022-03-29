using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperToolsDomain.Despesas.Entities;
using UpperToolsDomain.Despesas.Interfaces;

namespace UpperToolsApplication.Interfaces.Generics
{
    public class AppDespesas : IDespesasApp
    {
        IDespesas _IDespesas;
        public AppDespesas(IDespesas IDespesas)
        {
            _IDespesas = IDespesas;
        }
        public async Task Add(DespesasEntities Objeto)
        {
            await _IDespesas.Add(Objeto);
        }

        public async Task Delete(DespesasEntities Objeto)
        {
            await _IDespesas.Delete(Objeto);
        }

        public async Task<DespesasEntities> GetEntityById(int Id)
        {
            return await _IDespesas.GetEntityById(Id);
        }

        public async Task<List<DespesasEntities>> List()
        {
            return await _IDespesas.List();
        }

        public async Task Update(DespesasEntities Objeto)
        {
            await _IDespesas.Update(Objeto);
        }
    }
}
