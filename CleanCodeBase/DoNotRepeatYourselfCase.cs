namespace CleanCodeBase
{
    internal class DoNotRepeatYourselfCase
    {
        // d(ﾟｰﾟ@)
        public class Customer
        {
            public string BillingZipCode { get; set; }
            public string BillingStreet { get; set; }
            public string BillingNumber { get; set; }
            public string BillingNeighborhood { get; set; }
            public string BillingCity { get; set; }
            public string BillingState { get; set; }
            public string BillingCountry { get; set; }

            public string ShippingZipCode { get; set; }
            public string ShippingStreet { get; set; }
            public string ShippingNumber { get; set; }
            public string ShippingNeighborhood { get; set; }
            public string ShippingCity { get; set; }
            public string ShippingState { get; set; }
            public string ShippingCountry { get; set; }

            public void ChangeBillingAddress() { }
            public void ChangeShippingAddress() { }
        }
    }
}
