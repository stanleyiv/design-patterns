namespace DesignPatterns.FactoryMethod.Models
{
    public class Motorcycle : ITransportation
    {
        public string GetClassification()
        {
            return "Motorcycle";
        }
    }
}
