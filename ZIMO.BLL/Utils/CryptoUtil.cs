namespace ZIMO.BLL.Utils
{
    internal class CryptoUtil
    {
        // Gets Random Salt To Hash
        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(12);
        }

        // Hashes given string value and returns it hashed
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        // Validates a string with hashed pass
        public static bool ValidatePassword(string password, string correctHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, correctHash);
        }
    }
}
