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
    public class NoteDisplayerViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }
        public ICommand DeleteNoteCommand { get; set; }
    }
}
