using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

namespace vdv
{
    public class XmlParser
    {
        public string XmlText { get; set; }
        XmlDocument XmlDocument { get; set; }

        public XmlParser (string _xmlText)
        {
            XmlText = _xmlText;
            XmlDocument = new XmlDocument ();
        }

        public void ConvertToJson(int indent=2)
        {
            XmlDocument.LoadXml(XmlText);
            string jsonText = JsonConvert.SerializeXmlNode(XmlDocument, Newtonsoft.Json.Formatting.Indented, true);
            Console.WriteLine(jsonText);
        }
    }
}