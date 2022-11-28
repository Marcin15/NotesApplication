using NotesApplication.Domain.Aggregates;

namespace NotesApplication.UseCases.NewNoteObserver
{
    public interface INewNotePublisher
    {
        void Notify(Note note);
        void Subscribe(INewNoteSubscriber subscriber);
        void Unsubscribe(INewNoteSubscriber subscriber);
    }
}