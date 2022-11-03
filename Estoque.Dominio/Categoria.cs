namespace Estoque.Dominio
{
    public class Categoria : BaseAncestral
    {
        public Categoria() : base()
        {}


        public Categoria(int codigo, string descricao, string nome) 
            : base(codigo, descricao, nome)
        {
        }
    }
}

