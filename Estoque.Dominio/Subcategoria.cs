namespace Estoque.Dominio
{
    public class Subcategoria : BaseAncestral
    {
        private int codigoCategoria;

        public Subcategoria(int codigo, string descricao, string nome, int codigoCategoria)
        : base(codigo, descricao, nome)
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

