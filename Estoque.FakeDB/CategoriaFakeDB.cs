using Estoque.Dominio;

namespace Estoque.FakeDB
{
    public static class CategoriaFakeDB
    {
        private static List<Categoria>? categorias;

        public static List<Categoria> Categorias
        {
            get
            {
                if (categorias == null)
                {
                    categorias = new List<Categoria>();
                    Preencher();
                }
                return categorias;
            }
        }

        private static void Preencher()
        {
            if(categorias == null){
                Console.WriteLine("\nCategoria == NULL");
            }else{
                categorias.Add(new Categoria(1, "Comida cara, gurmetizada ","Casa Colonial", "Rua Dom João VI, 1806"));
                categorias.Add(new Categoria(2, "Lanche Barato pouco saudável","Jerônimo", "Rua Dom Pedro I, 1822"));
                categorias.Add(new Categoria(3, "Lugar alternativo comida cara","Funky Fresh", "Rua Imperatriz Leopoldina, 1822"));
                categorias.Add(new Categoria(4, "Comida Boa, um pouco mais barata por quilo","Sesc", "Rua Princesa Isabel, 1888"));
            }
        }
    }
}