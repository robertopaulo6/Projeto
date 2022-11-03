namespace Estoque.Dominio
{
    public class Produto : BaseAncestral
    {
        private int codigoCategoria;
        private int codigoSubcategoria;

        public Produto() : base()
        {}

        public Produto(int codigo, string descricao, string nome,string endereco, int codigoCategoria, int codigoSubcategoria)
        : base(codigo, descricao, nome,endereco)
        {
            this.codigoCategoria = codigoCategoria;
            this.codigoSubcategoria = codigoSubcategoria;
        }

        public int CodigoCategoria
        {
            get => this.codigoCategoria;
            set => this.codigoCategoria = value;
        }

        public int CodigoSubcategoria
        {
            get => this.codigoSubcategoria;
            set => this.codigoSubcategoria = value;
        }
    }

}

