// Build a "MusicPlaylist" class with a doubly linked list structure to efficiently add, remove, and play songs.

using System;
using System.Collections.Generic;

class MusicPlaylist
{
    private List<string> songs = new List<string>();

    public static void Main()
    {
        MusicPlaylist playlist = new MusicPlaylist();
        playlist.AddSong("Song 1");
        playlist.AddSong("Song 2");
        playlist.AddSong("Song 3");

        playlist.PlaySongs();

        playlist.RemoveSong("Song 2");
        playlist.PlaySongs();
    }

    public void AddSong(string song)
    {
        songs.Add(song);
    }

    public void RemoveSong(string song)
    {
        songs.Remove(song);
    }

    public void PlaySongs()
    {
        foreach (var song in songs)
        {
            Console.WriteLine("Playing: " + song);
        }
    }
}