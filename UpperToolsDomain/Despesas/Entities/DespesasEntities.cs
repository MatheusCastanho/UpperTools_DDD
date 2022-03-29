using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperToolsDomain.Despesas.Entities
{
    public class DespesasEntities
    {
        [Display(Name = "Valor")]
        public double Id { get; set; }

        [Display(Name = "Tipo")]
        public int Tipo { get; set; }

        [Display(Name = "Vencimento")]
        public DateTime Vencimento { get; set; }
    }
}
