using factory_method.abstractions;
using factory_method.concrete;

namespace factory_method.factory;

public class PagamentoFactory : Creator
{
    public override PagamentoProduct FactoryMethod(string pagamento)
    {
        switch (pagamento)
        {
            case "internacional":
                return new PagamentoInternacional();
            case "aluguel":
                return new PagamentoAluguel();
            default:
                throw new ArgumentException($"Tipo de pagamento desconhecido: {pagamento}");
        }
    }
}