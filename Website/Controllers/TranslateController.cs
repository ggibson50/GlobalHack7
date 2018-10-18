using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Google.Cloud.Translation.V2;

namespace Website.Controllers
{
    public class TranslateController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string inputLanguage, string outputLanguage, string text)
        {
            TranslationClient client = TranslationClient.Create();
            TranslationResult response = client.TranslateText(
                text: text,
                targetLanguage: outputLanguage,
                sourceLanguage: inputLanguage
                );
            return View(response.TranslatedText);
        }
        //public ActionResult Index2(string inputLanguage, string outputLanguage, string[] text)
        //{
        //    TranslationClient client = TranslationClient.Create();
        //    var response = client.TranslateText(
        //        text: text,
        //        targetLanguage: outputLanguage,
        //        sourceLanguage: inputLanguage
        //        );
        //    return View(response.TranslatedText);
        //}
    }
}