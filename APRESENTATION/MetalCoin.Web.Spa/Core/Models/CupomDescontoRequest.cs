using System.ComponentModel.DataAnnotations;

namespace MetalCoin.Web.Spa.Core.Models
{
    public class CupomDescontoRequest
    {
        [Required(ErrorMessage = "O código do Cumpom é obrigatorio")]
        public string Codigo { get; set; }


    }
}
