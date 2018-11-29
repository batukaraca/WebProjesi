using System.Web;
using System.Xml.Serialization;

namespace Proje.Models
{


    public class Word
    {

        [XmlAttribute(AttributeName = "text")]

        public string Words { get; set; }

        [XmlAttribute(AttributeName = "count")]

        public int Count { get; set; }
    }
}