using System;
using System.Collections.Generic;
using System.Text;
public abstract class Song
{
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public Song(string title, int duration, string artist, string genre)
    {
        if (title.Length < 2 || title.Length > 100)
        {
            throw new ArgumentException("Title should be between 2 and 100 characters!");
        }
        if (duration < 0)
        {
            throw new ArgumentException("Duration should be positive!");
        }
        if (artist.Length < 3 || artist.Length > 50)
        {
            throw new ArgumentException("Artist name should be between 3 and 50 characters!");
        }
        this.Title = title;
        this.Duration = duration;
        this.Artist = artist;
        this.Genre = genre;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Title: {Title}");
        stringBuilder.AppendLine($"Duration: {Duration} seconds");
        stringBuilder.Append($"Artist: {Artist}");
        return stringBuilder.ToString();
    }
}