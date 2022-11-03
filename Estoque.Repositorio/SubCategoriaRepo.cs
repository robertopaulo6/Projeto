namespace Estoque.Repositorio;

using System.Collections.Generic;
using Estoque.Dominio;
using Estoque.FakeDB;

public class SubCategoriaRepo : BaseRepositorio<Subcategoria>
{
    public override Subcategoria Create(Subcategoria instancia)
    {
        int codigo = SubcategoriaFakeDB.Subcategorias.Last().Id + 1;
        instancia.Id = codigo;
        SubcategoriaFakeDB.Subcategorias.Add(instancia);
        return instancia;
    }

    public override Subcategoria ReadOne(int chave)
    {
        return SubcategoriaFakeDB.Subcategorias.
            SingleOrDefault(cat => cat.Id == chave);
    }

    public override List<Subcategoria> ReadAll()
    {
        return SubcategoriaFakeDB.Subcategorias;
    }

    public override Subcategoria Update(Subcategoria instancia)
    {
        Subcategoria original = this.ReadOne(instancia.Id);
        if (original == null)
        {
            return null;
        }
        else
        {
            original.Descricao = instancia.Descricao;
            original.Endereco = instancia.Endereco;
            return original;
        }
    }

    public override Subcategoria Delete(Subcategoria instancia)
    {
        Subcategoria original = this.ReadOne(instancia.Id);
        if (original == null)
        {
            return null;
        }
        else
        {
            SubcategoriaFakeDB.Subcategorias.Remove(original);
            return original;
        }
        
    }
}
