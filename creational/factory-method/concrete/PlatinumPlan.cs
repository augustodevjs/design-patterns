using factory_method.abstractions;

namespace factory_method.concrete;

public class PlatinumPlan : SubscriptionPlan
{
    public void DisplaySelectedPlan()
    {
        Console.WriteLine("Platinum plan is selected");
    }
}