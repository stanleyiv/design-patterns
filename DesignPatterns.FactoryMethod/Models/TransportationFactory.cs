namespace DesignPatterns.FactoryMethod.Models
{
    public abstract class TransportationFactory
    {
        protected abstract ITransportation Create();

        public string SomeOperation()
        {
            var t = Create();

            return $"Object created with classification: {t.GetClassification()}.";
        }
    }
}
