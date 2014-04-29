using System.Collections.Generic;

/// <summary>
/// 播放栈，用来实现插播功能
/// </summary>
public class PlaylistStack
{
    private static PlaylistStack instance;
    private Stack<PlaylistAdapter> stack;
    private PlaylistStack() 
    {
        stack  = new Stack<PlaylistAdapter>();
        stack.Push(LinkedSongList.GetInstance());//非插播列表始终存在
    }
    public static PlaylistStack GetInstance() 
    {
        if (instance == null)
        {
            instance = new PlaylistStack();
        }
        return instance;
    }
    /// <summary>
    /// 添加插播列表
    /// </summary>
    public void Push(PlaylistAdapter playlist)
    {
        stack.Push(playlist);
    }

    /// <summary>
    /// 弹出插播列表
    /// 保证LinkedSongList不被弹出
    /// </summary>
    public void Pop()
    {
        if (stack.Count > 1)
        {
            stack.Pop();
        }
        else 
        { 
            throw new System.InvalidOperationException();
        }
    }
    /// <summary>
    /// 返回最先插播列表
    /// </summary>
    public PlaylistAdapter Peek()
    {
        return stack.Peek();
    }
}
