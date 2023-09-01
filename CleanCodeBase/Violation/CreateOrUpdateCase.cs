using static CleanCodeBase.DoNotRepeatYourselfCase;

namespace CleanCodeBase.Violation
{
    internal class CreateOrUpdateCase
    {
        internal class CustomerRepository
        {
            // ╾━╤デ╦︻( ▀ Ĺ ▀├┬┴┬┬┴┬  
            public void CreateOrUpdate(Customer customer, bool create)
            {
                if (create)
                {
                }
                else
                {
                }
            }
        }
    }
}
