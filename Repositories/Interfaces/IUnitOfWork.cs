namespace Clarify.Repositories.Interfaces;

public interface IUnitOfWork
{
    IGrupoRepository GrupoRepository { get; }
    
    IContaRepository ContaRepository { get; }
    
    ILancamentoRepository LancamentoRepository { get; }
    
    IPartidaRepository PartidaRepository { get; }
    
    void Commit();
}