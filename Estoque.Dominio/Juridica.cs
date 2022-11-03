namespace Estoque.Dominio;

public class Juridica : BasePessoa
{
    private string cnpj= string.Empty;

    public string Cnpj 
    {
        get => this.cnpj;
        set => this.cnpj = value;
    }

    public Juridica() : base()
    {}

    public Juridica(string nome,string email, string telefone,DateTime dataNascimento, string cidade, long id,  string senha, string cnpj) 
        : base(nome,email,telefone,dataNascimento,  cidade, id,  senha)
    {
        this.cnpj = cnpj;
    }
}
