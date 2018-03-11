using System;

namespace m.AppLogger
{
    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss - ") + text);
        }
    }
}
