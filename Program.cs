using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace XmlExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = System.AppDomain.CurrentDomain.BaseDirectory;

            var inputUrl = root + "InputFile.xml";
            var xsltUrl = root + "XsltFile.xslt";
            var outputUrl = root + "OutputFile.xml";

            XPathDocument InputXml = new XPathDocument(inputUrl);
            XslCompiledTransform Xslt = new XslCompiledTransform();
            Xslt.Load(xsltUrl);
            XmlTextWriter myWriter = new XmlTextWriter(outputUrl, null);
            Xslt.Transform(InputXml, null, myWriter);

        }
    }
}