using Proje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml;
using System.Xml.Serialization;

namespace Proje.Controllers
{
    public class WordController : Controller
    {
       

        // domain/Word/List 

        public ActionResult List()
        {

            List<Word> word = null;
            string path = "Word.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Word>));

            StreamReader reader = new StreamReader(path);
            word = (List<Word>)serializer.Deserialize(reader);
            reader.Close();
            return View(word);
        }
       

    }
}