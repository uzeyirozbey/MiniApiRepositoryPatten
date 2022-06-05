using System.Linq.Expressions;

namespace AppRepositoryPatten.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> Listele();
        IQueryable<T> Listele(Expression<Func<T, bool>> expression);
        void Ekle(T entity);
        void Duzenle(T entity);
        void Sil(T entity);
    }
}