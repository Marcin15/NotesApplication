using NotesApplication.UseCases.Helpers;
using NotesApplication.UseCases.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ICommand ClearCommand { get; set; }
        //{
        //    get
        //    {
        //        return _clearCommand ?? new RelayCommand(x => Clear());
        //    }
        //}

        public NewNoteViewModel()
        {
            ClearCommand = new RelayCommand(x => Clear());
        }

        public void Clear()
        {
            Title = string.Empty;
            Content = string.Empty;
        }

        public void AddNote()
        {

        }
    }
}
