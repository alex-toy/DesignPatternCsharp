using AdapterPattern.FormatAdapter.Json;
using AdapterPattern.FormatAdapter.Xml;

public class XmlToJsonAdapter<T> : IJsonParser<T>
{
    public string ObjectToJson(T obj)
    {
        IJsonParser<T> jsonParser = new JsonParser<T>();
        return jsonParser.ObjectToJson(obj);
    }

    public T JsonToObject(string xmlData)
    {
        IXmlParser<T> xmlParser = new XmlParser<T>();
        return xmlParser.XmlToObject(xmlData);
    }
}