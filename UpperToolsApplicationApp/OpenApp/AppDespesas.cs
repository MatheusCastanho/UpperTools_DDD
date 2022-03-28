using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperToolsApplicationApp.Interfaces;
using UpperToolsDomain.Interfaces.InterfaceDespesas;

namespace UpperToolsApplicationApp.OpenApp
{
    class AppDespesas : IDespesasApp
    {
        IDespesas _IDespesas;

        public AppDespesas(IDespesas IDespesas)
        {
            _IDespesas = IDespesas;
        }

        public async Task Add(Despesas Objeto)
        {
            await _IDespesas.Add(Objeto);
        }

        public async Task Delete(Despesas Objeto)
        {
            await _IDespesas.Delete(Objeto);
        }

        public async Task<Despesas> GetEntityById(int Id)
        {
            return await _IDespesas.GetEntityById(Id);
        }

        public async Task<List<Despesas>> List()
        {
            return await _IDespesas.List();
        }

        public Task Update(Despesas Objeto)
        {
            await _IDespesas.Update(Objeto);
        }
    }
}
