namespace AdapterPattern;

public interface IJsonParser<T>
{
    T Parse(string data);
    String ConvertToJson(T obj);
}