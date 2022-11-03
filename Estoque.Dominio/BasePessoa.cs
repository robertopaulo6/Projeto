namespace Estoque.Dominio;

public abstract class BasePessoa
{
    protected string nome =string.Empty;
    protected string email= string.Empty;
    protected string telefone= string.Empty;
    protected DateTime dataNascimento;
    protected string cidade= string.Empty;
    protected long id;
    protected string senha= string.Empty;

    public string Nome { get => nome; set => nome = value; }
    public string Email { get => email; set => email = value; }
    public string Telefone { get => telefone; set => telefone = value; }
    public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    public string Cidade { get => cidade; set => cidade = value; }    
    public long Id { get => id; set => id = value; }
    public string Senha { get => senha; set => senha = value; }

    public BasePessoa()
    {}

    public BasePessoa(string nome, string email,string telefone,  DateTime dataNascimento,  string cidade, long id,string senha  )
    {
        this.nome = nome;
        this.email = email;
        this.telefone = telefone;
        this.dataNascimento = dataNascimento;
        this.cidade = cidade;
        this.id = id;
        this.senha = senha;
    }
}
