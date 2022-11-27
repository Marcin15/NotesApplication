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
        public Guid UserId { get; private set; }
        public User User { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime DateCreated { get; private set; }
        public DateTime LastModified { get; private  set; }

        public static Note CreateNote(Guid userId, string title, string content)
        {
            return new Note
            {
                UserId = userId,
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
