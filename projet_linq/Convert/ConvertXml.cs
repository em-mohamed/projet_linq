namespace projet_linq.Convert;
using System.Xml;

public class ConvertXml
{
    public static XmlDocument CreateXmlDocument<T>(List<T> statistics)
    {
        var xmlDocument = new XmlDocument();

        var rootElement = xmlDocument.CreateElement($"{typeof(T).Name}s");
        xmlDocument.AppendChild(rootElement);

        foreach (var stat in statistics)
        {
            var statElement = xmlDocument.CreateElement($"{typeof(T).Name}");

            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(stat)?.ToString() ?? string.Empty;
                statElement.SetAttribute(property.Name, value);
            }

            rootElement.AppendChild(statElement);
        }

        return xmlDocument;
    }
    
    public static void SaveXmlDocument(XmlDocument xmlDocument)
    {
        xmlDocument.Save("./Data/OpEpisode.xml");
    }
    
}
