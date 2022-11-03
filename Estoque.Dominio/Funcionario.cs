namespace Estoque.Dominio;

public class Funcionario : BasePessoa
{
    private string contaCorrente;
    private string matricula;

    public string ContaCorrente 
    {
        get => this.contaCorrente;
        set => this.contaCorrente = value;
    }

    public string Matricula
    {
        get => this.matricula;
        set => this.matricula = value;
    }

    public Funcionario() : base()
    {}

    public Funcionario(DateTime dataNascimento, string email, Endereco enderecoPes, long id, string nome, string senha, string telefone, string usuario, string contaCorrente, string matricula)
        : base(dataNascimento, email, enderecoPes, id, nome, senha, telefone, usuario)
    {
        this.contaCorrente = contaCorrente;
        this.matricula = matricula;
    }
}
