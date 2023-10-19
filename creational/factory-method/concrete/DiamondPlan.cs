using factory_method.abstractions;

namespace factory_method.concrete;

public class DiamondPlan : SubscriptionPlan
{
    public void DisplaySelectedPlan()
    {
        Console.WriteLine("Diamond plan is selected");
    }
}