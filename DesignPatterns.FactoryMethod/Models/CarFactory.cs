namespace DesignPatterns.FactoryMethod.Models
{
    public class CarFactory : TransportationFactory
    {
        protected override ITransportation Create()
        {
            return new Car();
        }
    }
}
