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
            //Ia path-ul asta "E:\Projects\XmlExample\bin\Debug\net6.0"
            var root = System.AppDomain.CurrentDomain.BaseDirectory;

            var inputUrl = root + "InputFile.xml";
            var xsltUrl = root + "XsltFile.xslt";
            var outputUrl = root + "OutputFile.xml";

            //Ii da load la fisierul xml dupa path-ul respectiv
            XPathDocument InputXml = new XPathDocument(inputUrl);

            //Creeaza o instanta de Xslt
            XslCompiledTransform Xslt = new XslCompiledTransform();

            //Ii da load la stylesheet in instanta
            Xslt.Load(xsltUrl);

            //Creeaza o instanta de document writer(si ii dai si path-ul)
            XmlTextWriter myWriter = new XmlTextWriter(outputUrl, null);

            //Aplica transformarea pe fisierul de input si il scrie in output
            Xslt.Transform(InputXml, null, myWriter);

        }
    }
}