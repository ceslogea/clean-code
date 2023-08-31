namespace CleanCodeBase
{
    internal class DefaultValueAssignmentCase
    {
        // ☀(⌐▨_▨)🌴  
        public void DefaultValueAssignment(string message)
        {
            if (message is null)
            {
                message = "default message";
            }
        }
    }
}
