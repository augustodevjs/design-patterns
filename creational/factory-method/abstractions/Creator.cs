namespace factory_method.abstractions;

public abstract class Creator
{
    public abstract PagamentoProduct FactoryMethod(string pagamento);
}