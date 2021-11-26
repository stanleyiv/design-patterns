namespace DesignPatterns.FactoryMethod.Models
{
    public class Car : ITransportation
    {
        public string GetClassification()
        {
            return "Car";
        }
    }
}
