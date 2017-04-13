using System.IO;


namespace Costa
{
    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            const string path = @"C:\Users\ivanov\Desktop\Bournemouth-Chelsea.html";
            string text = File.ReadAllText(path);
        }

        // https://ru.stackoverflow.com/questions/420354/Как-распарсить-html-в-net

        #endregion
    }
}