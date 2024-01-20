using AdapterPattern;

public class XmlToJsonAdapter<T> : IJsonParser<T>
{
    public string ConvertToJson(T obj)
    {
        IJsonParser<T> jsonParser = new JsonParser<T>();
        return jsonParser.ConvertToJson(obj);
    }

    public T Parse(string data)
    {
        IXmlParser<T> xmlParser = new XmlParser<T>();
        return xmlParser.Parse(data);
    }
}