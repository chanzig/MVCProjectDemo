using MvcApplication1.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class EnumTestController : Controller
    {
        //
        // GET: /EnumTest/
        public enum DiseaseDiagnosis
        {
            [Description("精神分裂症")]
            Schizophrenia = 1,
            [Description("双相情感障碍")]
            BipolarDisorder = 2,
            [Description("抑郁症")]
            Depression = 3,
            [Description("强迫症")]
            Obsession = 4,
            [Description("广泛性焦虑障碍")]
            Anxiety = 5,
            [Description("ADHD")]
            Adhd = 6,
            [Description("神经性贪食症")]
            BulimiaNervosa = 7,
            [Description("其他")]
            Others = 8,
        }

        public ActionResult Index()
        {
            var mm = EnumHelper.GetNVCFromEnumValue(typeof( DiseaseDiagnosis));
            ViewBag.mmm = mm;
            return View();
        }

    }
}
