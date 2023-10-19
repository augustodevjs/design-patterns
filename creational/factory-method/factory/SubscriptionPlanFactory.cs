using factory_method.abstractions;
using factory_method.concrete;

namespace factory_method.factory;

public class SubscriptionPlanFactory
{
    public static SubscriptionPlan SelectPlan(string type)
    {
        switch (type)
        {
            case "platinum":
                return new PlatinumPlan();
            case "diamond":
                return new DiamondPlan();
            case "golden":
                return new GoldenPlan();
            default:
                throw new ArgumentException("Invalid plan type.");
        }
    }
}