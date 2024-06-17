using System;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = @"
        {
            ""store"": {
                ""book"": [
                    { ""category"": ""fiction"", ""author"": ""Herman Melville"", ""title"": ""Moby Dick"", ""price"": 8.99 },
                    { ""category"": ""fiction"", ""author"": ""J.K. Rowling"", ""title"": ""Harry Potter and the Philosopher's Stone"", ""price"": 9.99 }
                ],
                ""bicycle"": {
                    ""color"": ""red"",
                    ""price"": 19.95
                }
            }
        }";

        using JsonDocument document = JsonDocument.Parse(json);
        XElement xml = JsonToXml(document.RootElement);
        Console.WriteLine(xml.ToString());
    }

    static XElement JsonToXml(JsonElement element)
    {
        if (element.ValueKind == JsonValueKind.Object)
        {
            XElement xml = new XElement(element.GetProperty("category").GetString());
            foreach (JsonProperty property in element.EnumerateObject())
            {
                if (property.Name != "category")
                {
                    xml.Add(JsonToXml(property.Value));
                }
            }
            return xml;
        }
        else if (element.ValueKind == JsonValueKind.Array)
        {
            XElement xml = new XElement("items");
            foreach (JsonElement item in element.EnumerateArray())
            {
                xml.Add(JsonToXml(item));
            }
            return xml;
        }
        else
        {
            return new XElement("value", element.ToString());
        }
    }
}