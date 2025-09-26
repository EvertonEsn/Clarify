using Clarify.Context;
using Clarify.Models;
using Clarify.Repositories.Interfaces;

namespace Clarify.Repositories;

public class GrupoRepository : Repository<Grupo>, IGrupoRepository
{
    public GrupoRepository(AppDbContext context) : base(context)
    {
    }
}