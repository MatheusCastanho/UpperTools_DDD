using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upper.Servicos.WebApi.Json.Models;

namespace Upper.Servicos.WebApi.Json.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FornecedorController : ControllerBase
    {
        private static List<Faturamento> faturamentos = new List<Faturamento>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionarFaturamento([FromBody]Faturamento faturamento)
        {
            faturamento.id = id++;
            faturamentos.Add(faturamento);
            Console.WriteLine(faturamento.NomeFornecedor);
            return CreatedAtAction(nameof(RecuperarFaturamentoPorId), new { id = faturamento.id }, faturamento);
        }

        [HttpGet]
        public IActionResult RecuperarFaturamento()
        {
            return Ok(faturamentos);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperarFaturamentoPorId(int id)
        {
            var faturamento = faturamentos.FirstOrDefault(faturamento => faturamento.id == id);

            if (faturamento != null)
            {
                return Ok(faturamento);
            }
            return NotFound();                      
        }
    }
}
