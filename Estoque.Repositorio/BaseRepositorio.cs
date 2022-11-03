namespace Estoque.Repositorio;

using Estoque.Dominio;
using Estoque.FakeDB;

public abstract class BaseRepositorio<Tipo> where Tipo : class
{
    public abstract Tipo Create(Tipo instancia);

    public abstract Tipo ReadOne(int chave);

    public abstract List<Tipo> ReadAll();

    public abstract Tipo Update(Tipo instancia);

    public abstract Tipo Delete(Tipo instancia);
}
