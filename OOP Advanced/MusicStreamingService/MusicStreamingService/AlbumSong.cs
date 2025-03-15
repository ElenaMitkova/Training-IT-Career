using System;
using System.Collections.Generic;
using System.Text;
public class AlbumSong : Song
{
    public string AlbumName { get; set; }
    public AlbumSong(string title, int duration, string artist, string genre, string albumName)
        : base(title, duration, artist, genre)
    {
        if (albumName.Length < 3 || albumName.Length > 100)
        {
            throw new ArgumentException("Album name should be between 3 and 100 characters!");
        }
        this.AlbumName = albumName;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine(base.ToString());
        stringBuilder.Append($"Album: {AlbumName}");
        return stringBuilder.ToString();
    }
}