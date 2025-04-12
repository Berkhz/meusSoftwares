using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoFacil.Models
{
    public class Ponto
    {
        private long id { get; set; }
        private long funcionarioId { get; set; }
        private DateTime dataHora { get; set; }
        private string local { get; set; }
        private DateTime saldoHoras { get; set; }
    }
}
