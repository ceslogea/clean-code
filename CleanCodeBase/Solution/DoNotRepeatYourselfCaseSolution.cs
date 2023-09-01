namespace CleanCodeBase.Solution
{
    internal class DoNotRepeatYourselfCaseSolution
    {
        public class Address
        {
            public string BillingZipCode { get; set; }
            public string BillingStreet { get; set; }
            public string BillingNumber { get; set; }
            public string BillingNeighborhood { get; set; }
            public string BillingCity { get; set; }
            public string BillingState { get; set; }
            public string BillingCountry { get; set; }
        }

        public class Customer
        {
            public Address BillingAddress { get; set; }
            public Address ShippingAddress { get; set; }

            public void ChangeBillingAddress() { }
            public void ChangeShippingAddress() { }
        }
    }
}
