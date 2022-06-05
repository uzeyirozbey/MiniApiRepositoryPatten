using AppRepositoryPatten.Contracts;
using AppRepositoryPatten.Entities;
using AppRepositoryPatten.Entities.Models;

namespace AppRepositoryPatten.Repository
{
    public class OgrenciRepository : RepositoryBase<Ogrenci>, IOgrenciRepository
    {
        public OgrenciRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
