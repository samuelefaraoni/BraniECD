using System;
using System.Collections.Generic;
using System.Text;

namespace BraniECD.Classes
{
    public record Brano
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public TimeOnly Length { get; private set; }
        public Guid Id { get; private set; }

        public Brano(string title, string author, int lengthHours, int lengthMinutes, int lengthSeconds)
        {
            Title = title;
            Author = author;
            Length = new TimeOnly(lengthHours, lengthMinutes, lengthSeconds);
            Id = new Guid();
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Length: {Length.ToString()}";
        }
    }
}
