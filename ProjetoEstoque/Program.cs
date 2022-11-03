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
                Console.Clear();
                Console.WriteLine("\nBem Vindo!");
                Console.WriteLine("Escoha uma opção");
                Console.WriteLine("1-Escolher Resturante");
                Console.WriteLine("2-Entrar como empresa");
                Console.WriteLine("3-Entrar como pessoa");
                Console.WriteLine("0-Para sair");
                int opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1 :
                        Console.Clear();
                        //Escoher restaurane();
                        CategoriaOperacao operacao = new CategoriaOperacao();
                        operacao.ListarTodos();
                        Console.WriteLine("\nEscolha um dos restaurantes e Digite o código do restaurante escolhido:");
                        int rest = Convert.ToInt32(Console.ReadLine());
                        operacao.EscolherRestaurante(rest);
                        //CategoriaOperacao opera = new CategoriaOperacao();
                        //AddRestaurante(opera);
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