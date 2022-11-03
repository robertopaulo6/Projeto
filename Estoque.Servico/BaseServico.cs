namespace Estoque.Servico;

public abstract class BaseServico<TDominio> where TDominio : class
{
    public abstract List<TDominio> Browse();

    public abstract TDominio Read(int codigo);

    public abstract TDominio Edit(TDominio instancia);

    public abstract TDominio Add(TDominio instancia);

    public abstract TDominio Delete(TDominio instancia);
}
