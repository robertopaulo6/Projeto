namespace Estoque.Dominio;

public class Passageiro : BasePessoa
{
    private string documentoPessoal;
    private string numeroCartao;

    public string DocumentoPessoal { get => documentoPessoal; set => documentoPessoal = value; }
    public string NumeroCartao { get => numeroCartao; set => numeroCartao = value; }

    public Passageiro() : base()
    {}

    public Passageiro(DateTime dataNascimento, string email, Endereco enderecoPes, long id, string nome, string senha, string telefone, string usuario, string documentoPessoal, string numeroCartao)
        : base(dataNascimento, email, enderecoPes, id, nome, senha, telefone, usuario)
    {
        this.documentoPessoal = documentoPessoal;
        this.numeroCartao = numeroCartao;
    }
}
