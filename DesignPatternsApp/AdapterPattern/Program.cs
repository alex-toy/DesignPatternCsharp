using AdapterPattern;

Console.WriteLine("Adapter Pattern");


string xmlNote = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
                    <note>
                        <to>John</to>
                        <from>Jane</from>
                        <heading>Reminder</heading>
                        <body>Remember to pick me up at work!</body>
                    </note>";

IJsonParser<Note> parser = new XmlToJsonAdapter<Note>();
Note note = parser.Parse(xmlNote);
string jsonNote = parser.ConvertToJson(note);

Console.WriteLine(jsonNote);