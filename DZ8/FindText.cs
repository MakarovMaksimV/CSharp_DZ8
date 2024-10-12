using System;
using System.IO;

namespace DZ8
{
	public class FindText
	{
        public static void Find(List<string> list, string word)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Файл с запрашиваемым расширение не найден");
            }
            foreach(var l in list)
            {
                using (FileStream fs = new FileStream(l, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string[] line = sr.ReadToEnd().Split("\n");

                        foreach (var el in line)
                        {
                            if (el.Contains(word))
                            {
                                Console.WriteLine($"Название файла {fs.Name},\nстрока {el.Replace(word, word.ToUpper())}\n");
                            }
                        }
                    }
                }
            }
        }
    }
}

