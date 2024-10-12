namespace DZ8;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<string> list = FindFile.Find(args[0], args[1]);
            FindText.Find(list, args[2]);
        }
        catch (IndexOutOfRangeException)
        {
            throw new Exception("Не введены необходимые элементы");
        }
        catch (Exception)
        {
            throw new Exception();
        }
    }
}

