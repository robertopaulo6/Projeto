namespace ProjetoEstoque.Consumo;

using Estoque.Dominio;
using Estoque.Servico;

public class CategoriaOperacao
{
    private CategoriaServ servico;

    public CategoriaOperacao()
    {
        this.servico = new CategoriaServ();
    }

    public void ListarTodos()
    {
        List<Categoria> cats = this.servico.Browse();
        Console.WriteLine("Listar todas as Categorias:");
        foreach (Categoria item in cats)
        {
            Console.WriteLine("Codigo: {0} - Nome: {1}", item.Codigo, item.Descricao);
        }
    }
}
