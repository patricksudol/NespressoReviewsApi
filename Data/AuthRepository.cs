using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NespressoReviewsApi.Models;

namespace NespressoReviewsApi.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);

            if (user == null)
                return null;
            
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return user;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        // TODO: Hack code to get it working. Need to think about what to return
        public async Task<int> ChangePassword(Guid userId, string oldPassword, string NewPassword)
        {
            var updatedUser = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
            Console.WriteLine(updatedUser.UserName);
            
            if (updatedUser == null)
                return 404;
            Console.WriteLine(!VerifyPasswordHash(oldPassword, updatedUser.PasswordHash, updatedUser.PasswordSalt));
            if (!VerifyPasswordHash(oldPassword, updatedUser.PasswordHash, updatedUser.PasswordSalt))
                return 404;
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(NewPassword, out passwordHash, out passwordSalt);

            updatedUser.PasswordHash = passwordHash;
            updatedUser.PasswordSalt = passwordSalt;

            await _context.SaveChangesAsync();

            return 200;

        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.UserName == username))
                return true;

            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
                return true;
            }
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}