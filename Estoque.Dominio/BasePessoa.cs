namespace Estoque.Dominio;

public abstract class BasePessoa
{
    protected DateTime dataNascimento;
    protected string email;
    protected Endereco enderecoPessoal;
    protected long id;
    protected string nome;
    protected string senha;
    protected string telefone;
    protected string usuario;

    public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    public string Email { get => email; set => email = value; }
    public Endereco EnderecoPessoal { get => enderecoPessoal; set => enderecoPessoal = value; }    
    public long Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Senha { get => senha; set => senha = value; }
    public string Telefone { get => telefone; set => telefone = value; }
    public string Usuario { get => usuario; set => usuario = value; }

    public BasePessoa()
    {}

    public BasePessoa(DateTime dataNascimento, string email, Endereco enderecoPes, long id, string nome, string senha, string telefone, string usuario)
    {
        this.dataNascimento = dataNascimento;
        this.email = email;
        this.enderecoPessoal = enderecoPes;
        this.id = id;
        this.nome = nome;
        this.senha = senha;
        this.telefone = telefone;
        this.usuario = usuario;
    }
}
