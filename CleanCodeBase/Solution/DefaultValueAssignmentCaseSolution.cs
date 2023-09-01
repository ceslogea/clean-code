namespace CleanCodeBase.Solution
{
    internal partial class Class1
    {
        internal class DefaultValueAssignmentCaseSolution
        {
            public void DefaultValueAssignment_1(string? message = "default message")
            {

            }

            public void DefaultValueAssignment(string message)
            {
                message ??= "default message";
            }
        }



    }
}
