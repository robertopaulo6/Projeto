namespace Estoque.Servico;

using System.Collections.Generic;
using Estoque.Dominio;
using Estoque.Repositorio;

public class CategoriaServ : BaseServico<Categoria>
{
    private CategoriaRepo repositorio;

    public CategoriaServ() : base()
    {
        this.repositorio = new CategoriaRepo();
    }

    public override List<Categoria> Browse()
    {
        return this.repositorio.ReadAll();
    }

    public override Categoria Read(int codigo)
    {
        return this.repositorio.ReadOne(codigo);
    }

    public override Categoria Edit(Categoria instancia)
    {
        return this.repositorio.Update(instancia);
    }

    public override Categoria Add(Categoria instancia)
    {
        return this.repositorio.Create(instancia);
    }

    public override Categoria Delete(Categoria instancia)
    {
        return this.repositorio.Delete(instancia);
    }
}
