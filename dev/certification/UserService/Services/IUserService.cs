using UserService.Dtos;
using UserService.Models;
using System.Collections.Generic;

namespace UserService.Services
{
    public interface IUserService
    {
        ServiceResult Register(UserDto userDto);
        ServiceResult Authenticate(UserDto userDto);
        IEnumerable<User> GetAll();
        ServiceResult Delete(Guid id);
    }
}

