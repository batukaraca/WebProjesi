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
            List<Word> Word = new List<Word>();
            Deserialize(Word);
            return View(Word);
        }
        static void Deserialize(List<Word> Deneme)
        {
            FileStream fs = new FileStream(@"C:\Users\Toshiba\source\repos\ConsoleApp1\ConsoleApp1\bin\Debug\Word.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(List<Word>));
            xs.Deserialize(fs);
            fs.Close();
        }


    }
}