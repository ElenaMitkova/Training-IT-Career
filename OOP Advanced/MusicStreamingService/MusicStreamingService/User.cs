using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class User
{
    public string Username { get; set; }
    public int Age { get; set; }
    public List<Playlist> playlists;
    public User(string username, int age)
    {
        if (username.Length < 3 || username.Length > 30)
        {
            throw new ArgumentException("Username should be between 3 and 30 characters!");
        }
        if (age < 13)
        {
            throw new ArgumentException("User must be at least 13 years old!");
        }
        this.Username = username;
        this.Age = age;
        this.playlists = new List<Playlist>();
    }
    public void AddPlaylist(Playlist playlist)
    {
        playlists.Add(playlist);
    }
    public Playlist GetPlaylistByTitle(string title)
    {
        return playlists.Where(play => play.Title == title).First();
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Username: {Username}");
        stringBuilder.AppendLine($"Age: {Age}");
        stringBuilder.Append($"Total Playlists: {playlists.Count}");
        return stringBuilder.ToString();
    }
}