﻿namespace AdapterPattern.FormatAdapter.Xml
{
    public interface IXmlParser<T>
    {
        T XmlToObject(string data);
        string ObjectToXml(T obj);
    }
}
