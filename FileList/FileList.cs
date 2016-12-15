using System.Collections.Generic;
using System.IO;

public class FileList
{
    public static List<FileInfo> GetFiles(string rootDir, string searchPattern)
    {
        List<FileInfo> list = new List<FileInfo>();
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
                foreach (var file in next) list.Add(new FileInfo(file));
            try
            {
                next = Directory.GetDirectories(path);
                foreach (var subdir in next) pending.Push(subdir);
            }
            catch
            {

            }
        }
        return list;
    }

    public static List<FileInfo> GetFiles(string rootDir, string[] searchPatterns)
    {
        List<FileInfo> list = new List<FileInfo>();
        Stack<string> pending = new Stack<string>();
        pending.Push(rootDir);
        while (pending.Count != 0)
        {
            var path = pending.Pop();
            List<string> next = new List<string>();
            try
            {
                foreach (var searchPattern in searchPatterns)
                    next.AddRange(Directory.GetFiles(path, searchPattern));
            }
            catch
            {

            }
            if (next != null && next.Count != 0)
                foreach (var file in next) list.Add(new FileInfo(file));
            try
            {
                next.Clear();
                next.AddRange(Directory.GetDirectories(path));
                foreach (var subdir in next) pending.Push(subdir);
            }
            catch
            {

            }
        }
        return list;
    }
}