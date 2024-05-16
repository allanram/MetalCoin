using MetalCoin.Web.Spa.Core.Models;
using System.Threading.Tasks;

namespace MetalCoin.Web.Spa.Core.Endpoint
{

    public interface ICupomEndpoint
    {
        Task Atualizar(CupomEndpoint request);
        Task<List<CupomEndpoint>> ObterTodos();
        Task Ativar(Guid Id);
        Task Cadastar(CupomEndpoint request);   

    }
    public class CupomEndpoint : ICupomEndpoint
    {
        public Task Ativar(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(CupomEndpoint request)
        {
            throw new NotImplementedException();
        }

        public Task Cadastar(CupomEndpoint request)
        {
            throw new NotImplementedException();
        }

        public Task<List<CupomEndpoint>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
