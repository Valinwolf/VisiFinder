using System.Collections.Generic;
using System.IO;

public class FileList
{
public static IEnumerable<FileInfo> GetFiles(string rootDir, string searchPattern)
{
    Stack<string> pending = new Stack<string>();
    pending.Push(rootDir);
    while (pending.Count != 0)
    {
        var path = pending.Pop();
        string[] next = null;
        try
        {
            next = Directory.GetFiles(path, searchPattern);
        }
        catch
        {

        }
        if (next != null && next.Length != 0)
            foreach (var file in next) yield return new FileInfo(file);
        try
        {
            next = Directory.GetDirectories(path);
            foreach (var subdir in next) pending.Push(subdir);
        }
        catch
        {

        }
    }
}}