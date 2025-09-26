using Clarify.Context;
using Clarify.Repositories.Interfaces;

namespace Clarify.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IGrupoRepository? _grupoRepository;
    
    private IContaRepository? _contaRepository;
    
    private ILancamentoRepository? _lancamentoRepository;
    
    private IPartidaRepository? _partidaRepository;
    
    public AppDbContext _context;
    private IUnitOfWork _unitOfWorkImplementation;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IGrupoRepository GrupoRepository
    {
        get
        {
            return _grupoRepository =  _grupoRepository ?? new GrupoRepository(_context);
        }
    }
    
    public IContaRepository ContaRepository
    {
        get
        {
            return _contaRepository =  _contaRepository ?? new ContaRepository(_context);
        }
    }
    
    public ILancamentoRepository LancamentoRepository
    {
        get
        {
            return _lancamentoRepository =  _lancamentoRepository ?? new LancamentoRepository(_context);
        }
    }

    public IPartidaRepository PartidaRepository
    {
        get
        {
            return _partidaRepository =  _partidaRepository ?? new PartidaRepository(_context);
        }
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}