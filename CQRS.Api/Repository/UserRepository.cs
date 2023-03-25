using CQRS.Api.Data;
using CQRS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataDB _dataDB;
        public UserRepository(DataDB dataDB)
        {
            _dataDB = dataDB;
        }
        public async Task<User> AddUserAsync(User user)
        {
            var result = _dataDB.User.Add(user);
            await _dataDB.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<long> DeleteUserAsync(long Id)
        {
            var filterData = _dataDB.User.Where(x => x.Id == Id).FirstOrDefault();
            _dataDB.User.Remove(filterData);
            return await _dataDB.SaveChangesAsync();
        }

        public async Task<User> GetUserByIdAsync(long Id)
        {
            return await _dataDB.User.Where(x => x.Id == Id).FirstOrDefaultAsync();  
        }

        public async Task<List<User>> GetUserListAsync()
        {
           return await _dataDB.User.ToListAsync();
        }

        public async Task<long> UpdateUserAsync(User user)
        {
            _dataDB.User.Update(user);
            return await _dataDB.SaveChangesAsync();
        }
    }
}
