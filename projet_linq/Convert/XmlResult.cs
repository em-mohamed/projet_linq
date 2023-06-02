using System.Xml;
using Microsoft.AspNetCore.Mvc;

public class XmlResult : ContentResult
{
    public XmlResult(XmlDocument xmlDocument)
    {
        Content = xmlDocument.OuterXml;
        ContentType = "application/xml";
    }
}