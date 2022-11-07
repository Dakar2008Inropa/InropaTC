using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace InropaTC
{
    public static class JSONHelper
    {
        public static string GetGlobalMutexName(this string filePath)
        {
            string globalMutexName = filePath.GetHashCode().ToString();
            return globalMutexName;
        }
        //Serialize generic object to JSON and save it to disks
        public static void SerializeObject<T>(T objectToSerialize, string fileName)
        {
            string json = JsonConvert.SerializeObject(objectToSerialize, Formatting.Indented);
            File.WriteAllText(fileName, json);
        }

        //Deserialize JSON to generic object
        public static T DeserializeObject<T>(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<T>(json);
        }
        
        public static JToken LoadJsonData(string Path)
        {
            JToken root = null;
            if (File.Exists(Path))
            {
                using (Mutex mutex = new Mutex(false, Path.GetGlobalMutexName()))
                {
                    try
                    {
                        mutex.WaitOne();
                        using (var reader = new StreamReader(Path))
                        using (var jsonReader = new JsonTextReader(reader))
                        {
                            root = JToken.Load(jsonReader);
                        }
                    }
                    finally
                    {
                        mutex.ReleaseMutex();
                    }
                }
            }
            return root;
        }

        public static void WriteToJsonFile(JToken root, string path, bool isClassification = false)
        {
            string data = JsonConvert.SerializeObject(root, Formatting.Indented);
            using (Mutex mutex = new Mutex(false, path.GetGlobalMutexName()))
            {
                try
                {
                    mutex.WaitOne();
                    File.WriteAllText(path, data);
                }
                catch (Exception ex)
                {
                    LogHelper.LogError(ex.Message);
                    throw;
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}