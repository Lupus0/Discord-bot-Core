using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using static System.IO.Directory;

namespace DiscordBot_Core.Storage.implementations
{
    public class JsonStoragecs : IDataStorage
    {
        public T RestoreObject<T>(string key)
        {
            var Json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(Json);
        }

        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            CreateDirectory(Path.GetDirectoryName(file));
            var Json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, Json);
        }
    }
}
