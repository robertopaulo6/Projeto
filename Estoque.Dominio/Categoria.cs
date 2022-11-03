namespace Estoque.Dominio
{
    public class Categoria : BaseAncestral
    {
        public Categoria() : base()
        {}


        public Categoria(int id, string descricao, string endereco,string nome) 
            : base(id, descricao,endereco, nome)
        {
        }
    }
}

