namespace CleanCodeBase
{
    internal class VerboseProblemCase
    {
        // ༼ ༎ຶ ෴ ༎ຶ༽  
        public void VerboseProblem(string permission)
        {
            bool hasPermission;
            string[] currentPermissions = new string[] { "admin", "guest" };

            if (currentPermissions.Contains(permission))
            {
                hasPermission = true;
            }
            else
            {
                hasPermission = false;
            }
        }
    }
}
