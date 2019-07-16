using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeihanLi.AspNetMvc.MvcSimplePager;

namespace TestPager
{
    public class HomeController : Controller
    {
        public IActionResult Index(int pageIndex)
        {
            var list = new List<ValueTuple<string, string, string>>()
            {
                ValueTuple.Create("01","张1","21"),
                ValueTuple.Create("02","张2","31"),
                ValueTuple.Create("03","张3","41"),
                ValueTuple.Create("04","张4","51"),
                ValueTuple.Create("05","张5","22"),
                ValueTuple.Create("06","张6","32"),
                ValueTuple.Create("07","张7","34"),
                ValueTuple.Create("08","张8","52"),
                ValueTuple.Create("09","张9","23"),
                ValueTuple.Create("10","张10","14"),
            };

            var pageList = list.Skip((pageIndex - 1) * 3).Take(3).ToPagedList(pageIndex, 3, list.Count);

            return View(pageList);
        }
    }
}