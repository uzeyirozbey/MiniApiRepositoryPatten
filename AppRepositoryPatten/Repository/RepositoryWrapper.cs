using AppRepositoryPatten.Contracts;
using AppRepositoryPatten.Entities;

namespace AppRepositoryPatten.Repository;

public class RepositoryWrapper : IRepositoryWrapper
{
    private RepositoryContext _repoContext;
    private IOgrenciRepository _ogrenci;
    public IOgrenciRepository Ogrenci
    {
        get
        {
            if (_ogrenci == null)
            {
                _ogrenci = new OgrenciRepository(_repoContext);
            }
            return _ogrenci;
        }
    }
    public RepositoryWrapper(RepositoryContext repositoryContext)
    {
        _repoContext = repositoryContext;
    }

    public void Save()
    {
        _repoContext.SaveChanges();
    }
}

