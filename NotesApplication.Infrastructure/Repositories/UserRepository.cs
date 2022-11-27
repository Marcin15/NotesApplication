using Microsoft.EntityFrameworkCore;
using NotesApplication.Domain.Aggregates;
using NotesApplication.UseCases.Repositories;

namespace NotesApplication.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        private readonly DbSet<User> _users;

        public UserRepository(DataContext dbContext): base(dbContext)
        {
            _users = dbContext.Users;
        }

        public async Task<IEnumerable<User>> GetAll() => await _users.AsNoTracking()
                                                                     .ToListAsync();

        public async Task<User> GetFirstUser() => await _users.FirstOrDefaultAsync();

        public async Task<User> GetById(Guid id) => await _users.FirstOrDefaultAsync(x => x.Id == id);
    }
}
