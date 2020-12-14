using System;
using System.Threading.Tasks;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        // Task<User> ChangePassword(Guid userId, string oldPassword, string NewPassword);
        Task<int> ChangePassword(Guid userId, string oldPassword, string NewPassword);
        Task<bool> UserExists(string username);
        void Save();
    }
}