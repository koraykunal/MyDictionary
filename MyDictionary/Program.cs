using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> programmingLangs = new MyDictionary<int, string> { };
            programmingLangs.Add(1, "Python");
            programmingLangs.Add(2, "C#");
            programmingLangs.Add(3, "Java");
            programmingLangs.Add(4, "JavaScript");
            programmingLangs.Add(5, "Lua");
            programmingLangs.Listing();
        }
    }
}
