using NotesApplication.UseCases.Models;
using NotesApplication.UseCases.Services;
using NotesApplication.UseCases.Stores;
using NotesApplication.UseCases.ViewModels.Base;
using System.Diagnostics;

namespace NotesApplication.UseCases.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private readonly IAccountStore _accountStore;
        private readonly IUserService _userService;

        public INewNoteViewModel NewNoteViewModel { get; }

        public string FirstName { get; set; } = "unknown";
        public string LastName { get; set; } = "unknown";

        public Guid UserId { get; set; }

        public MainViewModel() { }

        public MainViewModel(IAccountStore accountStore, IUserService userService, INewNoteViewModel newNoteViewModel)
        {
            _accountStore = accountStore;
            _userService = userService;
            this.NewNoteViewModel = newNoteViewModel;

            Task.Run(async () => await SetInitialAccout()).Wait();
        }

        public async Task SetInitialAccout()
        {
            var user = await _userService.GetInitialUser();
            var account = new Account
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };

            FirstName = account.FirstName;
            LastName = account.LastName;

            _accountStore.Update(account);
            Debug.WriteLine(user);
        }
    }
}
