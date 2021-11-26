namespace DesignPatterns.FactoryMethod.Models
{
    public class MotorcycleFactory : TransportationFactory
    {
        protected override ITransportation Create()
        {
            return new Motorcycle();
        }
    }
}
