namespace CleanCodeBase.Solution
{
    internal partial class Class1
    {
        internal class VerboseProblemCaseSolution
        {
            public void VerboseProblem(string permission)
            {
                bool hasPermission;
                string[] currentPermissions = new string[] { "admin", "guest" };
                hasPermission = currentPermissions.Contains(permission);
            }
        }



    }
}
