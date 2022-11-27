
namespace NotesApplication.UseCases.ViewModels
{
    public interface IMainViewModel
    {
        Guid UserId { get; set; }

        Task SetInitialAccout();
    }
}