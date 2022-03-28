using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperToolsEntities.Entities
{
    class Despesas : Base
    {
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Display(Name = "TipoDespesa")]
        public string TipoDespesa { get; set; }

        [Display(Name = "Data")]
        public DateTime DataAtual { get; set; }
    }
}
