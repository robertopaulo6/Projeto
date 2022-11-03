namespace Estoque.Dominio
{
    public class Subcategoria : BaseAncestral
    {
        private int codigoCategoria;

        public Subcategoria(int id, string descricao,string endereco, string nome, int codigoCategoria)
        : base(id, descricao,endereco, nome)
        {
            this.codigoCategoria = codigoCategoria;
        }

        public Subcategoria() : base()
        {}

        public int CodigoCategoria
        {
            get => this.codigoCategoria;
            set => this.codigoCategoria = value;
        }
    }
}

