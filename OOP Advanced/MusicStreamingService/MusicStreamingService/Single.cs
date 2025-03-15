using System;
using System.Collections.Generic;
using System.Text;
public class Single : Song
{
    public DateTime ReleaseDate { get; set; }
    public Single(string title, int duration, string artist, string genre, DateTime releaseDate)
        : base(title, duration, artist, genre)
    {
        this.ReleaseDate = releaseDate;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.Append($"Release Date: {ReleaseDate}");
        return stringBuilder.ToString();
    }
}