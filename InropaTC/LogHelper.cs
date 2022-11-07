namespace InropaTC
{
    public static class LogHelper
    {
        public static void LogError(string message)
        {
            using (StreamWriter sw = File.AppendText(@"C:\ProgramData\Inropa\InropaTC\ErrorLog.txt"))
            {
                sw.Write($"{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")} ERROR: {message}");
            }
        }
    }
}