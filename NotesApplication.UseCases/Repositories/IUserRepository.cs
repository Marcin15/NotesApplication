using NotesApplication.Domain.Aggregates;

namespace NotesApplication.UseCases.Repositories
{
    public interface IUserRepository : IRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
        Task<User> GetFirstUser();
    }
}
