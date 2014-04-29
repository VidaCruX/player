using NAudio.Wave;
using System;
class Player
{
    private PlaylistStack playlistStack = PlaylistStack.GetInstance();
    private LinkedSongList linkedSongList = LinkedSongList.GetInstance();
    Status CurrentStatus { get; set; }
    public Player()
    {
    }
    public void Play() 
    {
        Console.WriteLine("播放：" + playlistStack.Peek().LastPlaySong.FilePath);
    }
    public void PlayFromLastTime()
    {
        Console.WriteLine("播放：" + playlistStack.Peek().LastPlaySong.FilePath + playlistStack.Peek().LastPlaySong.LastPlayTime);
    }
    public void Pause() { }
    public void Stop() { }
    public void OnSongPlayEnd() { }
    public void OnPlaylistEnd() { }
}

