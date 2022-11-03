namespace Estoque.Dominio
{
    public abstract class BaseAncestral
    {
        protected int codigo;
        protected string descricao = string.Empty;
        protected string nome= string.Empty;
        protected string endereco= string.Empty;

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
        public string Endereco
        {
            get => this.endereco;
            set => this.endereco = value;
        }

        public BaseAncestral()
        {}

        public BaseAncestral(int codigo, string descricao, string nome, string endereco)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.nome = nome;
            this.endereco = endereco;
        }

    }
}

