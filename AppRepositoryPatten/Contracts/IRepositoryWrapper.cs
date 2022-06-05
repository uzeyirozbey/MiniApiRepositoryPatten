namespace AppRepositoryPatten.Contracts;
public interface IRepositoryWrapper
{
    IOgrenciRepository Ogrenci { get; }
    void Save();
}
