using Certification.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Chapter3.Objective1
{
    [Listing("XML and XSD")]
    public class Listing_3_16 : IRunnable
    {
        public void Run()
        {
            ValidateXML(@"Resources\person.xml");
            ValidateXML(@"Resources\bad_person.xml");
            ValidateXML(@"Resources\bad_person2.xml");
        }

        public void ValidateXML(string xmlPath)
        {
            string xsdPath = @"Resources\person.xsd";
            Console.WriteLine("Validating " + xmlPath);

            XmlReader reader = XmlReader.Create(xmlPath);
            XmlDocument document = new XmlDocument();
            document.Schemas.Add("", xsdPath);
            document.Load(reader);
            document.Validate(ValidationEventHandler);
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    Console.WriteLine("Error: {0}", e.Message);
                    break;
                case XmlSeverityType.Warning:
                    Console.WriteLine("Warning {0}", e.Message);
                    break;
            }
        }
    }
}
