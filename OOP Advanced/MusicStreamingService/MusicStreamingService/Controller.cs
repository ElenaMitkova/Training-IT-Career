using System;
using System.Collections.Generic;
public class Controller
{
    private Dictionary<string, User> users = new Dictionary<string, User>();
    public string AddUser(List<string> args)
    {
        string username = args[0];
        int age = int.Parse(args[1]);
        if (users.ContainsKey(username))
        {
            return string.Empty;
        }
        users[username] = new User(username, age);
        return $"Created User {username}!";
    }
    public string AddPlaylist(List<string> args)
    {
        string username = args[0];
        string title = args[1];
        Playlist playlist = new Playlist(title);
        if (users.ContainsKey(username))
        {
            users[username].AddPlaylist(playlist);
            return $"Created Playlist {title} for User {username}!";
        }
        return string.Empty;
    }
    public string AddSongToPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        string songTitle = args[2];
        int duration = int.Parse(args[3]);
        string artist = args[4];
        string genre = args[5];
        
        string type = args[6];
        Song song = null;
        if (type == "Single")
        {
            DateTime dateTime = DateTime.Parse(args[7]);
            song = new Single(songTitle, duration, artist, genre, dateTime);
        }
        else if (type == "AlbumSong")
        {
            string albumName = args[7];
            song = new AlbumSong(songTitle, duration, artist, genre, albumName);
        }
        users[username].GetPlaylistByTitle(playlistTitle).AddSong(song);
        return $"Added song {songTitle} to Playlist {playlistTitle}!";
    }
    public string GetTotalDurationOfPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        Playlist playlist = users[username].GetPlaylistByTitle(playlistTitle);
        return $"Total duration of {playlistTitle}: {playlist.TotalDuration()} seconds";
    }
    public string GetSongsByArtistFromPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        string artist = args[2];

        return string.Join(Environment.NewLine, users[username].GetPlaylistByTitle(playlistTitle).GetSongsByArtist(artist));
    }
    public string GetSongsByGenreFromPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        string genre = args[2];
        return string.Join(Environment.NewLine, users[username].GetPlaylistByTitle(playlistTitle).GetSongsByGenre(genre));
    }
    public string GetSongsAboveDurationFromPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        int duration = int.Parse(args[2]);
        var s = users[username].GetPlaylistByTitle(playlistTitle).GetSongsAboveDuration(duration);
        return string.Join(Environment.NewLine, s);
    }
}