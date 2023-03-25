using CQRS.Api.Controllers;
using CQRS.Api.Data;
using CQRS.Api.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace UnitTest
{
    public class UserTesting
    {
        private readonly UserController _userController;
        private readonly IUserRepository _userRepository;
        private readonly DataDB _dataDB;

        public UserTesting()
        {
            _userRepository = new UserRepository(_dataDB);
            _userController = new UserController();

        }
        [Fact]
        public void Get_OK()
        {
            var result = _userController.GetListUsersAsync();
            Assert.IsType<OkObjectResult>(result);
        }
    }
}