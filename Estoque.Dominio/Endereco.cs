namespace Estoque.Dominio;

public class Endereco
{
    private string bairro = string.Empty;
    private string cidade = string.Empty;
    private string complemento = string.Empty;
    private string estado = string.Empty;
    private long id;
    private int numero;
    private string pais = string.Empty;
    private string rua = string.Empty;

    public string Bairro { get => bairro; set => bairro = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Complemento { get => complemento; set => complemento = value; }
    public string Estado { get => estado; set => estado = value; }
    public long Id { get => id; set => id = value; }
    public int Numero { get => numero; set => numero = value; }
    public string Pais { get => pais; set => pais = value; }
    public string Rua { get => rua; set => rua = value; }

    public Endereco()
    {}

    public Endereco(string bairro, string cidade, string complemento, string estado, long id, int numero, string pais, string rua)
    {
        this.bairro = bairro;
        this.cidade = cidade;
        this.complemento = complemento;
        this.estado = estado;
        this.id = id;
        this.numero = numero;
        this.pais = pais;
        this.rua = rua;
    }
}
