using AdapterPattern.FormatAdapter.Json;

Console.WriteLine("Adapter Pattern");

FormatAdapter();

static void FormatAdapter()
{
    string xmlNote = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

    // doesn't work because JsonToObject expects a Json formated string
    IJsonParser<Note> jsonParser = new JsonParser<Note>();

    // works thanks to the adapter
    //IJsonParser<Note> jsonParser = new XmlToJsonAdapter<Note>();

    // identical code
    Note note = jsonParser.JsonToObject(xmlNote);
    string jsonNote = jsonParser.ObjectToJson(note);
    Console.WriteLine(jsonNote);
}