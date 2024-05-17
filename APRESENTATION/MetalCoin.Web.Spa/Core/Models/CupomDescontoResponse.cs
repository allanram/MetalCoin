
namespace MetalCoin.Web.Spa.Core.Models
{
    public class CupomDescontoResponse
    {
        public Guid Id { get; set; }
        public string Codigo  { get; set; }
        public string Descricao { get; set; }
        public int CuponsLiberados { get; set; }
        public double ValorDesconto { get; set; }
        public int CuponsUsados { get; set; }
        public bool Status  { get; set; }


    }
}
