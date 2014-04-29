/// <summary>
/// 从文件读取歌曲文件信息，保存歌曲文件信息
/// </summary>
class MusicInfo
{
    static void UpdateInfo(Song song, string singer, string album)
    {
        song.Album = album;
        song.Singer = singer;
    }
    static string ReadSinger(Song song) 
    {
        string singer = "";
        //从MP3文件读取歌手信息
        song.Singer = singer;
        return singer;
    }
    static string ReadAlbum(Song song)
    {
        string album = "";
        //从MP3文件读取歌手信息
        song.Album = album;
        return album;
    }
    static void ReadImage(Song song) { }
}
