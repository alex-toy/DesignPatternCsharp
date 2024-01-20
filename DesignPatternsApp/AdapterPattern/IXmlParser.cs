namespace AdapterPattern
{
    public interface IXmlParser<T>
    {
        T Parse(string data);
        string ConvertToXml(T obj);
    }
}
