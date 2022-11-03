namespace Estoque.Dominio
{
    public abstract class BaseAncestral
    {
        protected int codigo;
        protected string descricao = string.Empty;
        protected string nome= string.Empty;

        public int Codigo
        {
            get => this.codigo;
            set => this.codigo = value;
        }

        public string Descricao
        {
            get => this.descricao;
            set => this.descricao = value;
        }

        public string Nome
        {
            get => this.nome;
            set => this.nome = value;
        }

        public BaseAncestral()
        {}

        public BaseAncestral(int codigo, string descricao, string nome)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.nome = nome;
        }

    }
}

