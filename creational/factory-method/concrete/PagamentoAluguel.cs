using factory_method.abstractions;

namespace factory_method.concrete;

// ConcreteProduct
public class PagamentoAluguel : PagamentoProduct
{
    public PagamentoAluguel()
    {
        _descricao = "aluguel";
        _tipo = "boleto";
    }
    
    public override void Pagar(double valor)
    {
        Console.WriteLine($"A conta {_descricao} foi paga via {_tipo} no valor de {valor}");
    }
}