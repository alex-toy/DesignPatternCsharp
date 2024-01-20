using System.Text.Json;

namespace AdapterPattern.Json
{
    public class JsonParser<T> : IJsonParser<T>
    {
        public T JsonToObject(string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }

        public string ObjectToJson(T obj)
        {
            return JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
        }
    }
}
