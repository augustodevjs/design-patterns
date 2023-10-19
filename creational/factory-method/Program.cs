using factory_method.abstractions;
using factory_method.factory;

Creator creator = new PagamentoFactory();
SubscriptionPlan subscription = SubscriptionPlanFactory.SelectPlan("platinum");

var pagamento = creator.FactoryMethod("internacional");
pagamento.Pagar(2000);

subscription.DisplaySelectedPlan();

