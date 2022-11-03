namespace Estoque.Dominio;

public class Fisica : BasePessoa
{
    private string cpf= string.Empty;

    public string Cpf { get => cpf; set => cpf = value; }

    public Fisica() : base()
    {}

    public Fisica(string nome,string email, string telefone,DateTime dataNascimento, string cidade, long id,  string senha, string cpf)
        : base(nome,email,telefone,dataNascimento,  cidade, id,  senha)
    {
        this.cpf = cpf;
    }
}
