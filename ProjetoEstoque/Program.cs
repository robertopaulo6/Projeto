using System;

using ProjetoEstoque.Consumo;
namespace ProjetoEstoque
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("\nBem Vindo");
                Console.WriteLine("Escoha uma opção");
                Console.WriteLine("1-Escolher Resturante");
                Console.WriteLine("2-Solicitar o cardápio");
                Console.WriteLine("3-Fazer um pedido");
                Console.WriteLine("0-Para sair");
                int opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1 :
                        Console.Clear();
                        //Escoher restaurane();
                        CategoriaOperacao operacao = new CategoriaOperacao();
                        operacao.ListarTodos();
                        int escolheu = Convert.ToInt32(Console.ReadLine());
                        //operacao.EscolherRestaurante(escolheu);
                        break;
                    case 2 :
                        Console.Clear();
                        //motrar  cardápio();
                        break;
                    case 3 :
                        Console.Clear();
                        //fazer pedido();
                        break;
                    case 0 :
                        Console.WriteLine("Vc escolheu Sair.");
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