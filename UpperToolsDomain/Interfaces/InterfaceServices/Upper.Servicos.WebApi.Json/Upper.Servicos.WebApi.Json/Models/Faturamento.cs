using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Upper.Servicos.WebApi.Json.Models
{
    public class Faturamento
    {
        public int id { get; set; }

        [Required (ErrorMessage = "O nome do fornecedor é obrigatório")]
        public string NomeFornecedor { get; set; }
        public double ValorFaturamento { get; set; }
        public string DtFaturamento { get; set; }
    }
}
