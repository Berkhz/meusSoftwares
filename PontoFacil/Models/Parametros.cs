using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoFacil.Models
{
    public class Parametros
    {
        private long id { get; set; }
        private DateTime totalHoras { get; set; }
        private bool ehBancoDeHoras { get; set; }
        private long calculoFolha { get; set; }
    }
}
