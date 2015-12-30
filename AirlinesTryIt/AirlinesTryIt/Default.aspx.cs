using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Collections;

namespace AirlinesTryIt
{
    public partial class _Default : Page
    {
        public XmlDocument document = new XmlDocument();
        public XmlNode node;
        public XmlTextReader reader = null;
        public List<string> nodeValues = new List<string>();
        public List<string> finalValues = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public List<string> saveDetails(string xml) {
            reader = new XmlTextReader(xml);
            reader.WhitespaceHandling = WhitespaceHandling.None;

            while (reader.Read())
            {
                nodeValues.Add("Type = " + reader.NodeType + "\t Name = " + reader.Name + "\t Value = " + reader.Value);
                if (reader.AttributeCount > 0)
                {
                    while (reader.MoveToNextAttribute())
                    {
                        nodeValues.Add("Type = " + reader.NodeType + "\t Name = " + reader.Name + "\t Value = " + reader.Value);
                    }
                }
            }

            return nodeValues;
        }

        public List<string> saveXMLDetails(string xml) {
            reader = new XmlTextReader(xml);
            reader.WhitespaceHandling = WhitespaceHandling.None;

            while (reader.Read())
            {
                if (reader.AttributeCount > 0) {
                    while (reader.MoveToNextAttribute()) {
                        string attr = Convert.ToString(reader.NodeType);

                        if (attr.Equals("Attribute") && (reader.Name.Trim().Equals("InternationalFlight") || reader.Name.Trim().Equals("zip")))
                        {
                            nodeValues.Add(reader.Value + "\t\t");
                        }
                    }
                }

                string attribute = Convert.ToString(reader.NodeType);

                if (attribute.Equals("Element") && (reader.Name.Trim().Equals("Name") || reader.Name.Trim().Equals("Phone") || reader.Name.Trim().Equals("Url") || reader.Name.Trim().Equals("City") || reader.Name.Trim().Equals("State") || reader.Name.Trim().Equals("Alliance")))
                {
                    reader.Read();
                    if (reader.NodeType.Equals("Text")) {
                        nodeValues.Add(reader.Value);
                    }
                    nodeValues.Add(reader.Value);
                } else if (attribute.Equals("EndElement") && reader.Name.Trim().Equals("Airline"))
                {
                    finalValues.Add(String.Join(" ", nodeValues));
                    nodeValues.Clear();
                }
            }
            return finalValues;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string xml = TextBox1.Text;

            finalValues.Add("InternationFlight Name Reservation\\Phone Reservation\\Url Headquarter\\Zip Headquarter\\City Headquarter\\State Alliance");
            finalValues = saveXMLDetails(xml);

            TextBox2.Text = String.Join("\n", finalValues.ToArray());
        }
    }
}
