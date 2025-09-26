using Clarify.Context;
using Clarify.Models;
using Clarify.Repositories.Interfaces;

namespace Clarify.Repositories;

public class ContaRepository : Repository<Conta>, IContaRepository
{
    public ContaRepository(AppDbContext context) :  base(context)
    {
        
    }
}