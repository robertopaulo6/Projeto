namespace Estoque.Servico;

using System.Collections.Generic;
using Estoque.Dominio;
using Estoque.Repositorio;

public class SubCategoriaServ : BaseServico<Subcategoria>
{
    private SubCategoriaRepo repositorio;

    public SubCategoriaServ() : base()
    {
        this.repositorio = new SubCategoriaRepo();
    }

    public override List<Subcategoria> Browse()
    {
        return this.repositorio.ReadAll();
    }

    public override Subcategoria Read(int codigo)
    {
        return this.repositorio.ReadOne(codigo);
    }

    public override Subcategoria Edit(Subcategoria instancia)
    {
        return this.repositorio.Update(instancia);
    }

    public override Subcategoria Add(Subcategoria instancia)
    {
        return this.repositorio.Create(instancia);
    }

    public override Subcategoria Delete(Subcategoria instancia)
    {
        return this.repositorio.Delete(instancia);
    }
}
