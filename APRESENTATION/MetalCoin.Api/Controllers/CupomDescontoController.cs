using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    public class CupomDescontoController
    {


        [HttpGet]
        [Route("cupom/desconto")]
        public AlunoResponse GetDescontos(string codigo)
        {

            var desconto = new CupomDesconto
            {
                Codigo = "07b13631",
                Descricao = "Desconto especial de Natal",
                ValorDesconto = 208.00,
                DataValidade = DateTime.Now,
                CuponsLiberados = 300,
                CuponsUsados = 200,
                Status = TipoStatusCupom.Ativo

            };
            return desconto;
        }
    }   
}
