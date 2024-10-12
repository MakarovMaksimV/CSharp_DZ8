using System;
namespace DZ8
{
	public class FindFile
	{
        public static List<string> listFile = new List<string>();

        public static List<string> Find(string path, string name)
        {
            List<string> list = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(path);

            var direct = dir.GetDirectories();
            var file = dir.GetFiles();
            foreach (var f in file)
            {
                if (f.FullName.Contains(name))
                {
                    listFile.Add(f.FullName);
                }
            }
            foreach (var d in direct)
            {
                list.AddRange(Find(d.FullName, name));
            }
            return listFile;
        }
    }
}

