using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoFacil.Models
{
    public class Funcionario
    {
        private long id { get; set; }
        private string nome { get; set; }
        private long empresaId { get; set; }
        private string cpf { get; set; }
        private string email { get; set; }
        private string senha { get; set; }
    }
}