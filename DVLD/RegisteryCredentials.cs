using Microsoft.Win32;


namespace DVLD
{
    public static class RegistryCredentials
    {
        private const string RegistryPath = @"SOFTWARE\DVLDApp\Login";

        public static void SaveCredentials(string username, string password)
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.SetValue("Username", username);
                key.SetValue("Password", password);
            }
        }

        public static (string Username, string Password) LoadCredentials()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key != null)
                {
                    string username = key.GetValue("Username", "").ToString();
                    string password = key.GetValue("Password", "").ToString();
                    return (username, password);
                }
                return (string.Empty, string.Empty);
            }
        }

        public static void DeleteCredentials()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryPath))
            {
                key.DeleteValue("Username", false);
                key.DeleteValue("Password", false);
            }
        }
    }
}
