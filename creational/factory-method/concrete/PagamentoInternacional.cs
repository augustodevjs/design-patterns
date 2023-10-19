using factory_method.abstractions;

namespace factory_method.concrete;

public class PagamentoInternacional : PagamentoProduct
{
    public PagamentoInternacional()
    {
        _descricao = "compra internacional";
        _tipo = "cartão de crédito";
    }
    
    public override void Pagar(double valor)
    {
        Console.WriteLine($"A conta {_descricao} foi paga via {_tipo} no valor de {valor} dólares.");
    }
}