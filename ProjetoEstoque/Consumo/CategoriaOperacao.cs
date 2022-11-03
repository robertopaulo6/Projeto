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
        Console.WriteLine("Listar todas os Restaurantes:");
        foreach (Categoria item in cats)
        {
            Console.WriteLine("Codigo: {0} - Nome: {1}", item.Id, item.Nome);
        }
    }
    /*public void EscolherRestaurante(int escolheu)
    {
        List<Categoria> cats = this.servico.Browse();
        foreach (Categoria item in cats)
        {
            if(item.Id == escolheu){
                Console.Clear();
                Console.WriteLine("Você Selecionou o Restaurante:{0}",item.Id);
                Console.WriteLine(" - Nome: {0} \n - Descrição: {1}\n - Endereço: {2}", item.Nome, item.Descricao, item.Endereco);
                bool sair = false;
                while (sair == false)
                {
                    Console.WriteLine("1-Solicitar o cardápio");
                    Console.WriteLine("2-Fazer um pedido");
                    Console.WriteLine("0-Para sair");
                    int rest = Convert.ToInt32(Console.ReadLine());
                    switch (rest)
                    {
                        case 1 :
                            Console.Clear();
                            //Motrar cardapio();
                            //CategoriaOperacao operacao = new CategoriaOperacao();
                            //operacao.ListarTodos();
                            //int escolheu = Convert.ToInt32(Console.ReadLine());
                            //operacao.EscolherRestaurante(escolheu);
                            break;
                        case 2 :
                            Console.Clear();
                            //escolher item do cardapio();
                            break;
                        case 0 :
                            Console.WriteLine("Vc escolheu Sair deste restaurante.");
                            Console.WriteLine("Até logo.");
                            sair = true;
                            break;
                        default:
                            Console.WriteLine("Opção inválida, escolha uma das opões adequadas.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }    
                }
            }
        }
    }*/
    
}
