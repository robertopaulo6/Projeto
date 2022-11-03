namespace Estoque.Dominio
{
    public class Categoria : BaseAncestral
    {
        public Categoria() : base()
        {}


        public Categoria(int codigo, string descricao, string nome, string endereco) 
            : base(codigo, descricao, nome,endereco)
        {
        }
    }
}

