using Estoque.Dominio;

namespace Estoque.FakeDB
{
    public static class CategoriaFakeDB
    {
        private static List<Categoria> categorias;

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
            categorias.Add(new Categoria(1, "Comida cara, gurmetizada ", "Rua Dom João VI, 1806","Casa Colonial"));
            categorias.Add(new Categoria(2, "Lanche Barato pouco saudável", "Rua Dom Pedro I, 1822","Jerônimo"));
            categorias.Add(new Categoria(3, "Lugar alternativo comida cara", "Rua Imperatriz Leopoldina, 1822","Funky Fresh"));
            categorias.Add(new Categoria(4, "Comida Boa, um pouco mais barata por quilo", "Rua Princesa Isabel, 1888","Sesc"));
        }
    }
}