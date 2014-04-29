using System.Collections.Generic;

/// <summary>
/// 存放非插播的播放列表
/// 由于会经常调整播放列表顺序，所以使用链表存放提高效率
/// 实现playlist接口，适配PlaylistStack
/// </summary>
public class LinkedSongList : PlaylistAdapter
{
    private static LinkedSongList instance;
    private LinkedList<SongList> linkedlist = new LinkedList<SongList>();
    private SongList lastPlaySongList;

    /// <summary>
    /// 指向当前的播放歌曲列表，插播完毕可以恢复
    /// </summary>
    public SongList LastPlaySongList
    {
        get { return lastPlaySongList;}
    }
    /// <summary>
    /// 指向当前的播放歌曲，插播完毕可以恢复
    /// </summary>
    public Song LastPlaySong
    {
        get { return lastPlaySongList.LastPlaySong; }
    }
    public LinkedSongList()
    {
        SongList defaultSongList = new SongList(); //默认播放列表
        lastPlaySongList = defaultSongList;
        linkedlist.AddFirst(defaultSongList);
    }
    /// <returns>LinkedSongList实例</returns>
    public static LinkedSongList GetInstance()
    {
        if (instance == null)
        {
            instance = new LinkedSongList();
        }
        return instance;
    }
    /// <summary>
    /// 添加播放列表
    /// </summary>
    public void Add(SongList songlist)
    {
        linkedlist.AddLast(songlist);
        lastPlaySongList = songlist;
    }
    /// <summary>
    /// 移除播放列表
    /// </summary>
    public void Remove(SongList songlist)
    {
        linkedlist.Remove(songlist);
    }
    /// <summary>
    /// 移动播放列表
    /// </summary>
    /// <param name="previousSonglist">前一个播放列表</param>
    public void Move(SongList previousSonglist, SongList songlist) 
    {
        linkedlist.Remove(songlist);
        linkedlist.AddAfter(linkedlist.Find(previousSonglist), songlist);
    }
}

