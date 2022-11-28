using NotesApplication.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.UseCases.NewNoteObserver
{
    public interface INewNoteSubscriber
    {
        void NewNoteSubscribe(Note note);
    }
}
