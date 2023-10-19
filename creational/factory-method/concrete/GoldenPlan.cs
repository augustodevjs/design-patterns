using factory_method.abstractions;

namespace factory_method.concrete;

public class GoldenPlan : SubscriptionPlan
{
    public void DisplaySelectedPlan()
    {
        Console.WriteLine("Golden plan is selected");
    }
}