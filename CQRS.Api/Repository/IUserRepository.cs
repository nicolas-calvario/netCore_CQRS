﻿using CQRS.Api.Models;

namespace CQRS.Api.Repository
{
    public interface IUserRepository
    {
        public Task<List<User>> GetUserListAsync();
        public Task<User> GetUserByIdAsync(long Id);
        public Task<User> AddUserAsync(User user);
        public Task<long> UpdateUserAsync(User user);
        public Task<long> DeleteUserAsync(long Id);
    }
}
