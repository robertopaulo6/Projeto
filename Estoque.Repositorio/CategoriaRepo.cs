namespace Estoque.Repositorio;

using System.Collections.Generic;
using Estoque.Dominio;
using Estoque.FakeDB;

public class CategoriaRepo : BaseRepositorio<Categoria>
{
    public override Categoria Create(Categoria instancia)
    {
        int codigo = CategoriaFakeDB.Categorias.Last().Codigo + 1;
        instancia.Codigo = codigo;
        CategoriaFakeDB.Categorias.Add(instancia);
        return instancia;
    }

    public override Categoria ReadOne(int chave)
    {
        return CategoriaFakeDB.Categorias.
            SingleOrDefault(cat => cat.Codigo == chave);
    }

    public override List<Categoria> ReadAll()
    {
        return CategoriaFakeDB.Categorias;
    }

    public override Categoria Update(Categoria instancia)
    {
        Categoria original = this.ReadOne(instancia.Codigo);
        if (original == null)
        {
            return null;
        }
        else
        {
            original.Descricao = instancia.Descricao;
            original.Nome = instancia.Nome;
            return original;
        }
    }

    public override Categoria Delete(Categoria instancia)
    {
        Categoria original = this.ReadOne(instancia.Codigo);
        if (original == null)
        {
            return null;
        }
        else
        {
            CategoriaFakeDB.Categorias.Remove(original);
            return original;
        }
        
    }
}
