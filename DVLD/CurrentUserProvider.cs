using Core.Models;

namespace DVLD.Session
{
    public static class CurrentUserProvider
    {
        private static User _currentUser;
        public static User CurrentUser => _currentUser;

        public static void SetCurrentUser(User user)
        {
            _currentUser = user;
        }
    }
}