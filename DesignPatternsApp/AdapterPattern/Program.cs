using AdapterPattern.FormatAdapter.Json;
using AdapterPattern.PowerAdapter;

Console.WriteLine("Adapter Pattern");

//FormatAdapter();

OutletAdapter();

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

static void OutletAdapter()
{
    MaleOutlet maleOutlet = new MaleOutlet() { Sizes = new List<int> { 1, 2, 3, 4, 5 }, MaleConnectorCount = 4 };
    FemaleOutlet femaleOutlet = new FemaleOutlet() { Size = 6, FemaleConnectorCount = 2, Outlet = maleOutlet };
    Console.WriteLine($"Fits : {(femaleOutlet.Fit() ? "yes" : "no")}");

    HybridOutlet hybridOutlet = new HybridOutlet() { Size = 3, FemaleConnectorCount = 2, MaleConnectorCount = 2 };
    //femaleOutlet = new FemaleOutlet() { Size = 6, FemaleConnectorCount = 2, Outlet = hybridOutlet }; // doesn't compile
    HybridOutletAdapter hybridOutletAdapter = new HybridOutletAdapter() { HybridOutlet = hybridOutlet };
    femaleOutlet = new FemaleOutlet() { Size = 6, FemaleConnectorCount = 2, Outlet = hybridOutletAdapter };

    Console.WriteLine($"Fits : {(femaleOutlet.Fit() ? "yes" : "no")}");
}