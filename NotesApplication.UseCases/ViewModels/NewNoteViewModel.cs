using NotesApplication.UseCases.Helpers;
using NotesApplication.UseCases.Services;
using NotesApplication.UseCases.ViewModels.Base;
using System.Windows.Input;

namespace NotesApplication.UseCases.ViewModels
{
    public class NewNoteViewModel : BaseViewModel, INewNoteViewModel
    {
        private string _title;
        public string Title 
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _content;
        public string Content
        {
            get { return _content; }
            set
            {
                _content = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _clearCommand;

        public ICommand ClearCommand
        {
            get
            {
                if (_clearCommand is null)
                {
                    _clearCommand = new RelayCommand(x => Clear());
                }

                return _clearCommand;
            }
        }

        private RelayCommand _addNewNoteCommand;
        
        public ICommand AddNewNoteCommand
        {
            get
            {
                if(_addNewNoteCommand is null)
                {
                    _addNewNoteCommand = new RelayCommand(x => AddNote());
                }

                return _addNewNoteCommand;
            }
        }

        private readonly INoteService _noteService;

        //public NewNoteViewModel() { }

        public NewNoteViewModel(INoteService noteService)
        {
            _noteService = noteService;
        }

        public void Clear()
        {
            Title = string.Empty;
            Content = string.Empty;
        }

        public async void AddNote()
        {
            await _noteService.AddNewNote(_title, _content);
            Clear();
        }
    }
}
