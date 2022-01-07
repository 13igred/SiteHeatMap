using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace HeatMap
{
    class UpdateXML
    {
        public UpdateXML(string ID, string area, string desc, int x, int y, string file)
        {
            string filepath = file + ".xml";
            XmlDocument doc = new XmlDocument();

            if (!File.Exists(filepath))
            {
                // Create the XmlDocument.
                
                doc.LoadXml("<Site><Equipment><ID></ID><Area></Area><Description></Description><CoordinateX></CoordinateX><CoordinateY></CoordinateY></Equipment></Site>"); //Your string here

                // Save the document to a file and auto-indent the output.
                XmlTextWriter writer = new XmlTextWriter(filepath, null);
                writer.Formatting = Formatting.Indented;
                doc.Save(writer);
                writer.Close();
            }

            doc.Load(filepath);
            XmlNode nl = doc.SelectSingleNode("//Site");
            XmlDocument xmlDoc2 = new XmlDocument();
            xmlDoc2.LoadXml("<Equipment><ID>" + ID + "</ID><Area>" + area + "</Area><Description>" + desc + "</Description><CoordinateX>" + x.ToString() + "</CoordinateX><CoordinateY>" + y.ToString() + "</CoordinateY></Equipment>");
            XmlNode n = doc.ImportNode(xmlDoc2.FirstChild,true);
            nl.AppendChild(n);
            doc.Save(filepath);
        }
    }
}
