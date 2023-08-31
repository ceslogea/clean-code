namespace CleanCodeBase
{
    internal class FailFastGuardClausesCase
    {
        // ( •_•)>⌐■-■
        public bool FailFastGuardClauses(string? password)
        {
            bool hasValue = !string.IsNullOrEmpty(password);
            if (hasValue == true)
            {
                bool hasSpescialCharacter = password.Any(c => !char.IsLetterOrDigit(c));
                if (hasSpescialCharacter == true)
                {
                    bool longEnough = password.Length > 20;
                    if (longEnough)
                    {
                        return true;
                    }
                    else
                    {
                        throw new ArgumentException("Must be at Least 10 characters");
                    }
                }
                else
                {
                    throw new ArgumentException("Must have at Least 1 special character");
                }
            }
            else
            {
                throw new ArgumentException("Password must have a value");
            }
        }
    }
}
