using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate XmlDocument and load XML from file
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\nate.arms\Downloads\Sync Timecard Header CRM to SL - Dev.dts");

            // get a list of nodes - in this case, I'm selecting all <AID> nodes under
            // the <GroupAIDs> node - change to suit your needs
            XmlNodeList aNodes = doc.SelectNodes("/DTS/DataProviders/DataProvider");

            // loop through all AID nodes
            foreach (XmlNode aNode in aNodes)
            {
                // grab the "id" attribute
                XmlAttribute idAttribute = aNode.Attributes["GUID"];

                // check if that attribute even exists...
                if (idAttribute != null)
                {
                    // if yes - read its current value
                    string currentValue = idAttribute.Value;

                    // here, you can now decide what to do - for demo purposes,
                    // I just set the ID value to a fixed value if it was empty before
                    if (string.IsNullOrEmpty(currentValue))
                    {
                        idAttribute.Value = "515";
                    }
                }
            }

            // save the XmlDocument back to disk
            doc.Save(@"C:\Users\nate.arms\Downloads\Sync Timecard Header CRM to SL - Dev.dts");
        }
    }
}
