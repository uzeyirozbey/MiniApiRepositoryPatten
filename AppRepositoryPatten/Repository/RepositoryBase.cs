using AppRepositoryPatten.Contracts;
using AppRepositoryPatten.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AppRepositoryPatten.Repository;
public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected RepositoryContext RepositoryContext { get; set; }
    public RepositoryBase(RepositoryContext repositoryContext)
    {
        RepositoryContext = repositoryContext;
    }
    public void Ekle(T entity) =>  RepositoryContext.Set<T>().Add(entity);
    public void Duzenle(T entity) => RepositoryContext.Set<T>().Update(entity);
    public void Sil(T entity) => RepositoryContext.Set<T>().Remove(entity);
    //Tümünü Listele
    public IQueryable<T> Listele() => RepositoryContext.Set<T>().AsNoTracking();
    public IQueryable<T> Listele(Expression<Func<T, bool>> expression) =>
            RepositoryContext.Set<T>().Where(expression).AsNoTracking();
}
