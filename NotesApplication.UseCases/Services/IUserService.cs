using NotesApplication.Domain.Aggregates;

namespace NotesApplication.UseCases.Services
{
    public interface IUserService
    {
        Task<User> GetInitialUser();
    }
}