using Estoque.Dominio;

namespace Estoque.FakeDB
{
    public static class SubcategoriaFakeDB
    {

        private static List<Subcategoria>? subcategorias;

        public static List<Subcategoria> Subcategorias
        {
            get
            {
                if (subcategorias == null)
                {
                    subcategorias = new List<Subcategoria>();
                }
                return subcategorias;
            }
        }

        private static void Preencher()
        {
            if(subcategorias == null){
                
            }else{
                subcategorias.Add(new Subcategoria(1, "Comida cara, gurmetizada ", "Rua Dom João VI, 1806","Casa Colonial",1));
                subcategorias.Add(new Subcategoria(2, "Lanche Barato pouco saudável", "Rua Dom Pedro I, 1822","Jerônimo",1));
                subcategorias.Add(new Subcategoria(3, "Lugar alternativo comida cara", "Rua Imperatriz Leopoldina, 1822","Funky Fresh",1));
                subcategorias.Add(new Subcategoria(4, "Comida Boa, um pouco mais barata por quilo", "Rua Princesa Isabel, 1888","Sesc", 1));
            }
        }
    }
}
