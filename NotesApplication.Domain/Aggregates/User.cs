using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.Domain.Aggregates
{
    public class User
    {
        private readonly List<Note> _notes;

        private User() { }
        public Guid Id { get; set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime LastUploadDate { get; private set; }
        public IEnumerable<Note> Notes { get => _notes; }

        public static User CreateUser(string firstName, string lastName)
        {
            return new User()
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
            };
        }

        public void AddNote(Note note)
        {
            _notes.Add(note);
            LastUploadDate = DateTime.Now;
        }

        public void UpdateNote(Note newNote)
        {
            var note = _notes.FirstOrDefault(x => x.Id == newNote.Id);
            if (note is not null)
            {
                note.UpdateNote(newNote.Title, newNote.Content);
                LastUploadDate = DateTime.Now;
            }
        }

        public void RemoveNote(Note note)
        {
            _notes.Remove(note);
        }
    }
}
