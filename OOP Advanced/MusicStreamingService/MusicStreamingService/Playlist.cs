using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Playlist
{
    public string Title { get; set; }
    private List<Song> songs;
    public Playlist(string title)
    {
        if (title.Length < 3 || title.Length > 50)
        {
            throw new ArgumentException("Playlist title should be between 3 and 50 characters!");
        }
        this.Title = title;
        this.songs = new List<Song>();
    }
    public void AddSong(Song song)
    {
        songs.Add(song);
    }
    public double TotalDuration()
    {
        return songs.Sum(song => song.Duration);
    }
    public List<Song> GetSongsByArtist(string artist)
    {
        return songs.Where(song => song.Artist == artist).OrderBy(song => song.Title).ToList();
    }
    public List<Song> GetSongsByGenre(string genre)
    {
        return songs.Where(song => song.Genre == genre).OrderBy(song => song.Title).ToList();
    }
    public List<Song> GetSongsAboveDuration(int duration)
    {
        return songs.Where(song => song.Duration >= duration).OrderByDescending(song => song.Duration).ToList();
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Playlist: {Title}");
        stringBuilder.Append($"Total Songs: {songs.Count}");
        return stringBuilder.ToString();
    }
}