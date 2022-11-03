namespace Estoque.Dominio
{
    public abstract class BaseAncestral
    {
        protected int id;
        protected string descricao = string.Empty;
        protected string endereco= string.Empty;
        protected string nome= string.Empty;


        public int Id
        {
            get => this.id;
            set => this.id = value;
        }

        public string Descricao
        {
            get => this.descricao;
            set => this.descricao = value;
        }

        public string Endereco
        {
            get => this.endereco;
            set => this.endereco = value;
        }
         public string Nome
        {
            get => this.nome;
            set => this.nome = value;
        }

        public BaseAncestral()
        {}

        public BaseAncestral(int id, string descricao, string endereco, string nome)
        {
            this.id = id;
            this.descricao = descricao;
            this.endereco = endereco;
            this.nome = nome;
        }

    }
}

