using NotesApplication.Domain.Aggregates;
using NotesApplication.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.UseCases.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetInitialUser()
        {
            return await _userRepository.GetFirstUser();
        }
    }
}
