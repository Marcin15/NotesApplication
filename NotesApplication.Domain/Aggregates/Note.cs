using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.Domain.Aggregates
{
    public class Note
    {
        private Note() { }

        public Guid Id { get; set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private  set; }

        public Note CreateNote(string title, string content)
        {
            return new Note
            {
                Id = Guid.NewGuid(),
                Title = title,
                Content = content,
                DateCreated = DateTime.Now,
                LastModified = DateTime.Now
            };
        }

        public void UpdateNote(string title, string content)
        {
            Title = title;
            Content = content;
            LastModified = DateTime.Now;
        }
    }
}
