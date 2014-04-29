using System;
[Serializable]
public class Song
{
    public Song() { }
    public Song(String file)
    {
        filePath = file;
    }
    private String filePath;
    public String FilePath { get { return filePath; } set { filePath = value; } }
    public String LastPlayTime { get; set; }
    public String Singer { get; set; }
    public String Album { get; set; }
}

