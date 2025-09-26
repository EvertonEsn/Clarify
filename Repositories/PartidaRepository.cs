using Clarify.Context;
using Clarify.Models;
using Clarify.Repositories.Interfaces;

namespace Clarify.Repositories;

public class PartidaRepository :  Repository<Partida>, IPartidaRepository
{
    public PartidaRepository(AppDbContext context) : base(context)
    {
        
    }
}