namespace ProjetoEstoque.Consumo;

using Estoque.Dominio;
using Estoque.Servico;
public class CardapioRestaurante
{
    private CategoriaServ cardapio;

    public CardapioRestaurante()
    {
        this.cardapio = new CategoriaServ();
    }
    public void ListarCardapio()
    {
        List<Categoria> cats = this.cardapio.Browse();
        Console.WriteLine("Listar todas os Restaurantes:");
        foreach (Categoria item in cats)
        {
            Console.WriteLine("Codigo: {0} - Nome: {1}", item.Id, item.Nome);
        }
    }

}
