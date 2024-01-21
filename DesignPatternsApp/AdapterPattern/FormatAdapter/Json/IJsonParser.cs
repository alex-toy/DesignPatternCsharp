namespace AdapterPattern.FormatAdapter.Json;

public interface IJsonParser<T>
{
    T JsonToObject(string data);
    string ObjectToJson(T obj);
}