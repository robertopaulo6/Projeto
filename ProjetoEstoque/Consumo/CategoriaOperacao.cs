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
        Console.Clear();
        Console.WriteLine("\nListar todas os Restaurantes:");
        foreach (Categoria item in cats)
        {
            Console.WriteLine("\nRestaurante {0}:  Nome: {1} \n - {2} \n - {3}", item.Codigo,item.Nome, item.Descricao, item.Endereco);
        }
    }
    public void EscolherRestaurante(int rest)
    {
        List<Categoria> cats = this.servico.Browse();
        Console.Clear();
        foreach (Categoria item in cats)
        {
            if(item.Codigo == rest){
                Console.WriteLine("Você escolheu o Restaurante:{0} - {1} \n - {2} \n - {3}", item.Codigo,item.Nome, item.Descricao, item.Endereco);
                
                bool sair = false;
                while (sair == false)
                {
                    Console.WriteLine("\nO que você deseja?");
                    Console.WriteLine("1-Solicitar o cardápio");
                    Console.WriteLine("2-Fazer um pedido");
                    Console.WriteLine("3-Ver endereco do restaurante");
                    Console.WriteLine("4-Alterar Endereco");
                    Console.WriteLine("0-Para sair do restaurante");
                    int opera = Convert.ToInt32(Console.ReadLine());
                    switch (opera)
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
                        case 3 :
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
    }
    
    
}
