using NotesApplication.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.UseCases.NewNoteObserver
{
    public class NewNotePublisher : INewNotePublisher
    {
        private List<INewNoteSubscriber> _subscribers = new();

        public void Subscribe(INewNoteSubscriber subscriber) => _subscribers.Add(subscriber);
        public void Unsubscribe(INewNoteSubscriber subscriber) => _subscribers.Remove(subscriber);
        public void Notify(Note note)
        {
            foreach (INewNoteSubscriber subscriber in _subscribers)
            {
                subscriber.NewNoteSubscribe(note);
            }
        }
    }
}
