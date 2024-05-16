using Metalcoin.Core.Abstracts;
using Metalcoin.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Domain
{
    public class CupomDesconto:Entidade
    {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal ValorDesconto { get; set; }
        public DateTime DataValidade { get; set; }
        public int CuponsLiberados { get; set; }
        public int CuponsUsados { get; set; }
        public TipoStatusCupom Status { get; set; }

    }
}
