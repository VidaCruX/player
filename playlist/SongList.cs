using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// 通用播放列表
/// </summary>
public class SongList
{
    protected LinkedList<Song> songList = new LinkedList<Song>();
    protected Song lastPlaySong = null;
    public Song LastPlaySong { get { return lastPlaySong; } }
    public void Add(Song song)
    {
        songList.AddLast(song);
        lastPlaySong = song;
    }
    public void Remove(Song song)
    {
        songList.Remove(song);
    }
    public void Move(Song previousSong, Song song)
    {
        songList.Remove(song);
        songList.AddAfter(songList.Find(previousSong), song);
    }
    /// <summary>
    /// 使用linq转成数组让其能被序列化成XML
    /// </summary>
    public Song[] GetSongArray()
    {
        return songList.ToArray();
    }
    /// <summary>
    /// 从XML反序列化成的数组赋值给List
    /// </summary>
    public void SongArrayToList(Song[] songs)
    {
        foreach(Song song in songs)
        {
            songList.AddLast(song);
        }
    }
}

