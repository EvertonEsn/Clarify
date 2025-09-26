using Clarify.Context;
using Clarify.Models;
using Clarify.Repositories.Interfaces;

namespace Clarify.Repositories;

public class LancamentoRepository : Repository<Lancamento>,  ILancamentoRepository
{
    public LancamentoRepository(AppDbContext context) : base(context)
    {
        
    }
}